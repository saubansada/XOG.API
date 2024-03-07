using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using XOG.AppCode.DAL;
using XOG.Util;

namespace XOG.AppCode.BLL
{
    public class NotificationBL
    {
        private static readonly Uri FireBasePushNotificationsURL = new Uri("https://fcm.googleapis.com/fcm/send");

        private static readonly string ServerKey = "AAAAnOdTlXU:APA91bHgs-nxMf_Ueu1y63OB0RBvfNTL4H0T_wbkLy2oX_5xOyE5Iqwo8nQAE5gC13o688Zvw9adCbfb0wToEUlohXG-QKsDRDGg225s9LyAmsnUxtbt1Jm4koATGMvttNYilWncn73i";

        private static readonly NotificationBL instance;

        // Static constructor to initialize the instance
        static NotificationBL()
        {
            instance = new NotificationBL();
        }

        private NotificationBL()
        {
            // Do some initialization here
        }

        // Static read-only property to access the instance
        public static NotificationBL Instance
        {
            get { return instance; }
        }

        internal static XOGEntities GetXOGContext()
        {
            return new XOGEntities();
        }

        internal async Task<DBStatus> SaveFirebaseToken(AspNetUserNotificationToken model, XOGEntities context = null)
        {
            try
            {
                if (context == null)
                {
                    using (var _context = new XOGEntities())
                    {
                        if (_context == null)
                        {
                            throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                        }
                        return await SaveFirebaseToken(model, _context);
                    }
                }
                var exist = context.AspNetUserNotificationTokens.Any(i => i.UserId == model.UserId && i.NotificationToken == model.NotificationToken);

                if (!exist)
                {
                    context.AspNetUserNotificationTokens.Add(model);

                    await context.SaveChangesAsync();
                }

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_ADDING_NOTIFICATION_TOKEN.ColonNextLine() + ex.ToString());

                return await Task.FromResult(DBStatus.Error);
            }
        }

        internal async Task<long> CreateNotification(Notification model, XOGEntities context = null)
        {
            try
            {
                if (context == null)
                {
                    using (var _context = new XOGEntities())
                    {
                        if (_context == null)
                        {
                            throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                        }
                        return await CreateNotification(model, _context);
                    }
                }

                context.Notifications.Add(model);

                await context.SaveChangesAsync();

                return model.Id;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_ADDING_NOTIFICATION.ColonNextLine() + ex.ToString());

                return await Task.FromResult(0);
            }
        }


        internal async Task<DBStatus> SavePushedNotification(PushNotification model, XOGEntities context = null)
        {
            try
            {
                if (context == null)
                {
                    using (var _context = new XOGEntities())
                    {
                        if (_context == null)
                        {
                            throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                        }
                        return await SavePushedNotification(model, _context);
                    }
                }

                context.PushNotifications.Add(model);

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_ADDING_PUSH_NOTIFICATION.ColonNextLine() + ex.ToString());

                return await Task.FromResult(DBStatus.Error);
            }
        }

        public async Task<int> SendPushNotification(string[] deviceTokens,
            string title,
            string body,
            long data,
            byte aspeectId,
            string recipientUserId)
        {
            var sentCount = 0;
            bool sent = false;

            var entity = new AppCode.DAL.Notification();

            entity.NotificationTitle = title;
            entity.IsArchived = false;
            entity.IsSMS = true;
            entity.IsEmail = true;
            entity.NavigatioUrl = "/";
            entity.NotificationAspect = aspeectId;
            entity.RecipientUserId = recipientUserId;
            entity.NotificationMessage = body;
            entity.AspectRecordId = data;
            entity.IsPushNotification = true;
            entity.NotificationIconUrl = "/";
            entity.ActionUserId = recipientUserId;

            long res = await Instance.CreateNotification(entity);

            if (res != 0 && deviceTokens.Count() > 0)
            {
                foreach (string token in deviceTokens)
                {
                    //Object creation

                    var messageInformation = new
                    {
                        to = token,
                        notification = new
                        {
                            body = body,
                            OrganizationId = "2",
                            content_available = true,
                            priority = "high",
                            subtitle = "--",
                            title = title
                        },
                        data = new
                        {
                            priority = "high",
                            sound = "",
                            content_available = true,
                            bodyText = body,
                            organization = "Modern Mart"
                        }
                    };

                    //Object to JSON STRUCTURE => using Newtonsoft.Json;
                    string jsonMessage = JsonConvert.SerializeObject(messageInformation);

                    //Create request to Firebase API
                    var request = new HttpRequestMessage(HttpMethod.Post, FireBasePushNotificationsURL);

                    request.Headers.TryAddWithoutValidation("Authorization", "bearer " + ServerKey);
                    request.Content = new StringContent(jsonMessage, Encoding.UTF8, "application/json");

                    HttpResponseMessage result;
                    using (var client = new HttpClient())
                    {
                        result = await client.SendAsync(request);
                        sent = sent && result.IsSuccessStatusCode;
                        var message = result.StatusCode;
                    }
                    if (sent) sentCount++;
                    sent = false;
                }
            }

            return sentCount;
        }
    }
}
