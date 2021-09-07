//using System;
//using SendGrid;
//using SendGrid.SmtpApi;
//using System.Collections.Generic;
//using System.Threading.Tasks;
//using XOG.AppCode.OFrame;

//namespace XOG.AppCode.Helpers
//{
//    namespace SendGridEmailServiceHelper
//    {
//        public class SendgridEmailSender
//        {
//            public static bool SendMail(SendGridSettings settings, string To, string Subject, string MarkupFile, params KeyValuePair<string, string>[] Substitutions)
//            {
//                try
//                {
//                    var FileMarkupString = System.IO.File.ReadAllText(MarkupFile);
//                    var Message = EMailBuilder.Build(FileMarkupString, Substitutions);
//                    return SendMail(settings, To, Subject, Message);
//                }
//                catch (Exception ex) { throw (ex); }
//            }

//            public static bool SendMail(SendGridSettings settings, String To, string Subject, string Message, string footerTemplate = "")
//            {
//                try
//                {
//                    var apiKey = AppConfig.SendGridAPIKey;

//                    apiKey = apiKey.Replace(" ", "");
//                    var sg = new SendGridAPIClient(apiKey);

//                    var from = new Email(settings.SenderEmail, settings.SenderName);
//                    var subject = Subject;
//                    var to = new Email(To);

//                    var content = new Content();
//                    content = new Content
//                    {
//                        Type = "text/html",
//                        Value = Message
//                    };
//                    var mail = new Mail(from, subject, to, content);

//                    var mailSettings = new MailSettings();
//                    if (footerTemplate != "")
//                    {
//                        var footerSettings = new FooterSettings
//                        {
//                            Enable = true,
//                            Html = footerTemplate
//                        };
//                        mailSettings.FooterSettings = footerSettings;
//                        mail.MailSettings = mailSettings;
//                    }
//                    var response = sg.client.mail.send.post(requestBody: mail.Get());
//                    return true;
//                }
//                catch (Exception ex) { throw (ex); }
//            }

//            public static async Task<bool> SendMailAsync(SendGridSettings settings, string To, string Subject, string MarkupFile, params KeyValuePair<string, string>[] Substitutions)
//            {
//                try
//                {
//                    var FileMarkupString = System.IO.File.ReadAllText(MarkupFile);
//                    var Message = EMailBuilder.Build(FileMarkupString, Substitutions);
//                    return await SendMailAsync(settings, To, Subject, Message);
//                }
//                catch (Exception ex) { throw (ex); }
//            }

//            public static async Task<bool> SendMailAsync(SendGridSettings settings, String To, string Subject, string Message, string footerTemplate = "")
//            {
//                try
//                {
//                    var apiKey = AppConfig.SendGridAPIKey;

//                    apiKey = apiKey.Replace(" ", "");
//                    var sg = new SendGridAPIClient(apiKey);

//                    var from = new Email(settings.SenderEmail, settings.SenderName);
//                    var subject = Subject;
//                    var to = new Email(To);

//                    var content = new Content();
//                    content = new Content
//                    {
//                        Type = "text/html",
//                        Value = Message
//                    };
//                    var mail = new Mail(from, subject, to, content);

//                    var mailSettings = new MailSettings();
//                    if (footerTemplate != "")
//                    {
//                        var footerSettings = new FooterSettings
//                        {
//                            Enable = true,
//                            Html = footerTemplate
//                        };
//                        mailSettings.FooterSettings = footerSettings;
//                        mail.MailSettings = mailSettings;
//                    }
//                    var response = await sg.client.mail.send.post(requestBody: mail.Get());
//                    return true;
//                }
//                catch (Exception ex) { throw (ex); }
//            }

//            public static async Task<bool> SendMailSmtpAsync(SendGridSettings settings, String To, string Subject, string Message, string footerTemplate = "")
//            {
//                try
//                {
//                    var apiKey = AppConfig.SendGridAPIKey;

//                    apiKey = apiKey.Replace(" ", "");
//                    var sg = new SendGridAPIClient(apiKey);

//                    var from = new Email(settings.SenderEmail, settings.SenderName);
//                    var subject = Subject;
//                    var to = new Email(To);

//                    var content = new Content();
//                    content = new Content
//                    {
//                        Type = "text/html",
//                        Value = Message
//                    };
//                    var mail = new Mail(from, subject, to, content);

//                    var mailSettings = new MailSettings();
//                    if (footerTemplate != "")
//                    {
//                        var footerSettings = new FooterSettings
//                        {
//                            Enable = true,
//                            Html = footerTemplate
//                        };
//                        mailSettings.FooterSettings = footerSettings;
//                        mail.MailSettings = mailSettings;
//                    }
//                    var response = await sg.client.mail.send.post(requestBody: mail.Get());
//                    return true;
//                }
//                catch (Exception ex) { throw (ex); }
//            }

//            public static bool SendMailToMultiple(SendGridSettings settings, List<string> To, string Subject, string MarkupFile, params KeyValuePair<string, string>[] Substitutions)
//            {
//                try
//                {
//                    var FileMarkupString = System.IO.File.ReadAllText(MarkupFile);
//                    var Message = EMailBuilder.Build(FileMarkupString, Substitutions);
//                    return SendMailToMultiple(settings, To, Subject, Message);
//                }
//                catch (Exception ex) { throw (ex); }
//            }

//            public static bool SendMailToMultiple(SendGridSettings settings, List<string> To, string Subject, string Message)
//            {
//                try
//                {
//                    foreach (string recipiant in To) SendMail(settings, recipiant, Subject, Message);
//                    return true;
//                }
//                catch (Exception) { throw; }
//            }

//            public static async Task<bool> SendMailToMultipleAsync(SendGridSettings settings, List<string> To, string Subject, string MarkupFile, params KeyValuePair<string, string>[] Substitutions)
//            {
//                try
//                {
//                    var FileMarkupString = System.IO.File.ReadAllText(MarkupFile);
//                    var Message = EMailBuilder.Build(FileMarkupString, Substitutions);
//                    return await SendMailToMultipleAsync(settings, To, Subject, Message);
//                }
//                catch (Exception ex) { throw (ex); }
//            }

//            public static async Task<bool> SendMailToMultipleAsync(SendGridSettings settings, List<string> To, string Subject, string Message)
//            {
//                try
//                {
//                    foreach (string recipiant in To) await SendMailAsync(settings, recipiant, Subject, Message);
//                    return true;
//                }
//                catch (Exception) { throw; }
//            }
//        }

//        public class SendGridSettings
//        {
//            public string SenderEmail { get; set; }

//            public string SenderName { get; set; }

//            public string SendGridApiKey { get; set; }
//        }
//    }
//}
