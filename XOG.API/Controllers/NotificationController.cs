using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.Caching;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using XOG.Abstracts;
using XOG.AppCode.BLL;
using XOG.AppCode.Mappers;
using XOG.AppCode.Models.FilterModels;
using XOG.AppCode.Performance;
using XOG.Factories;
using XOG.Filters;
using XOG.Models;
using XOG.Models.ViewModels;
using XOG.Models.ViewModels.RequestViewModels.Data;
using XOG.Models.ViewModels.RequestViewModels.Filters;
using XOG.Util;

namespace XOG.Controllers
{
    [RoutePrefix("api/app-notification")]
    public class NotificationController : ApiController
    {
        public NotificationController() { }

        public NotificationController(ApplicationUserManager _userManager)
        {
            UserManager = _userManager;
        }

        private ApplicationUserManager _userManager;

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? Request.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        /*
         * This is to keep track to users' token Id generated from Firebase from client site
         */
        [HttpPost]
        [Route("save-system-key")]
        [OFAuthorize(Roles = "Developer, Admin, SubAdmin, Staff")]
        public async Task<IHttpActionResult> SaveFirebaseToken(SaveFirebaseTokenRequestVM request)
        {

            var userName = HttpContext.Current.User.Identity.Name;

            if (userName == null)
            {
                var obj = new ReturnObject<object>();
                obj.IsSuccess = false;
                obj.Data = null;
                return Ok(await Task.FromResult(obj));
            }

            var res = new ReturnObject<DBStatus>();

            var entity = new AppCode.DAL.AspNetUserNotificationToken();

            if (userName != null)
            {

                string userId = (await UserManager.FindByNameAsync(userName)).Id;

                entity.UserId = userId;

                entity.NotificationToken = request.UserToken;

                res.Data = await NotificationBL.Instance.SaveFirebaseToken(entity);

                res.IsSuccess = res.Data == DBStatus.Success;
            }

            return Ok(await Task.FromResult(res));
        }

        /*
         * This is to let administrator or state to manually create any notification for advertisement, offeres, notice 
         * or compaining.
         */
        [HttpPost]
        [Route("create-notification")]
        public async Task<IHttpActionResult> CreateNotification([FromBody] CreateNotificationRequestVM request)
        {
            var res = new ReturnObject<object>();

            var bl = NotificationBL.Instance;

            var entity = new AppCode.DAL.Notification();

            entity.NotificationTitle = request.NotificationTitle;
            entity.IsArchived = request.IsArchived;
            entity.IsSMS = request.IsSMS;
            entity.IsEmail = request.IsEmail;
            //entity.NavigationUrl = request.NavigatioUrl;
            entity.NotificationAspect = request.NotificationAspect;
            entity.RecipientUserId = request.RecipientUserId;
            entity.NotificationMessage = request.NotificationMessage;
            entity.AspectRecordId = request.AspectRecordId;
            entity.IsPushNotification = request.IsPushNotification;
            entity.NotificationIconUrl = request.NotificationIconUrl;
            entity.ActionUserId = request.ActionUserId;

            res.Data = await bl.CreateNotification(entity);

            return Ok(await Task.FromResult(res));
        }

        /*
         * When User receives notificaction on their system or device, this Id of that notification will be saved in the Database
         * This is make sure the system will have a track of each notificaion received by user in the device / system
         */
        [HttpPost]
        [Route("save-pushed-notification")]
        public async Task<IHttpActionResult> SavePushedNotification([FromBody] PushNotificationRequestVM request)
        {
            var res = new ReturnObject<object>();

            var bl = NotificationBL.Instance;

            var entity = new AppCode.DAL.PushNotification();

            entity.NotificationToken = request.NotificationToken;
            entity.NotificationId = request.NotificationId;
            entity.IsBackground = request.IsBackground;
            entity.IsForeground = request.IsForeground;
            entity.IsNotified = request.IsNotified;
            entity.IsViewed = request.IsViewed;

            res.Data = await bl.SavePushedNotification(entity);

            return Ok(await Task.FromResult(res));
        }

        [HttpGet]
        [Route("fetch-notification")]
        public async Task<IHttpActionResult> FetchNotifications()
        {
            var userName = HttpContext.Current.User.Identity.Name;

            if (userName == null)
            {
                var obj = new ReturnObject<object>();
                obj.IsSuccess = false;
                obj.Data = null;
                return Ok(await Task.FromResult(obj));
            }

            var userId = (await UserManager.FindByNameAsync(userName)).Id;

            var res = new ReturnObject<object>();

            var entities = MessageQueueCacheHelper.Instance.GetAll<AppCode.DAL.Notification>(userId);

            List<NotificationViewModel> list = new List<NotificationViewModel>();

            entities.ForEach((entity) =>
            {
                var item = new NotificationViewModel();
                item.NotificationTitle = entity.NotificationTitle;
                item.IsArchived = entity.IsArchived;
                item.IsSMS = entity.IsSMS;
                item.IsEmail = entity.IsEmail;
                //item.NavigationUrl = entity.NavigatioUrl;
                item.NotificationAspect = entity.NotificationAspect;
                item.RecipientUserId = entity.RecipientUserId;
                item.NotificationMessage = entity.NotificationMessage;
                item.AspectRecordId = entity.AspectRecordId;
                item.IsPushNotification = entity.IsPushNotification;
                item.NotificationIconUrl = entity.NotificationIconUrl;
                item.ActionUserId = entity.ActionUserId;
                list.Add(item);
            });

            res.Data = list;

            res.IsSuccess = true;

            return Ok(await Task.FromResult(res));
        }
    }
}
