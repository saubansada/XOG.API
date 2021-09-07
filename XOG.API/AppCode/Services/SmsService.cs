using Microsoft.AspNet.Identity;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Web;

namespace XOG.Services
{
    public class SmsService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            switch (AppConfig.SMSServiceName)
            {
                //case "TWILIO":
                //    {
                //        // Twilio Begin
                //        var Twilio = new TwilioRestClient(AppConfig.SMSAccountIdentification, AppConfig.SMSAccountPassword);

                //        var result = Twilio.SendMessage(AppConfig.SMSAccountFrom, message.Destination, message.Body);
                //        //Status is one of Queued, Sending, Sent, Failed or null if the number is not valid
                //        Trace.TraceInformation(result.Status);
                //        //Twilio doesn't currently have an async API, so return success.
                //        // Twilio End
                //        break;
                //    }
                case "ASPSMS":
                    {
                        //// ASPSMS Begin
                        //var soapSms = new ASPSMSX2.ASPSMSX2SoapClient("ASPSMSX2Soap");
                        //soapSms.SendSimpleTexXOGS(
                        //  System.Configuration.ConfigurationManager.AppSettings["SMSAccountIdentification"],
                        //  System.Configuration.ConfigurationManager.AppSettings["SMSAccountPassword"],
                        //  message.Destination,
                        //  System.Configuration.ConfigurationManager.AppSettings["SMSAccountFrom"],
                        //  message.Body);
                        //soapSms.Close();
                        //return Task.FromResult(0);
                        //// ASPSMS End
                        break;
                    }

                case "TEXTLOCAL":
                    {
                        message.Body = HttpUtility.UrlEncode(message.Body);

                        if (!AppConfig.IsProduction.ToLower().Equals("True"))
                        {

                            using (StreamWriter writetext = new StreamWriter(@"C:\OTP.txt"))
                            {
                                writetext.WriteLine(message.Body);
                            }
                        }
                        else
                        {
                            //using (var wb = new WebClient())
                            //{
                            //    byte[] response = wb.UploadValues("http://sms.questersms.com/api/mt/SendSMS", new NameValueCollection()
                            //    {
                            //        {"APIKey" , AppConfig.QuesterSMSAPIKey},
                            //        {"senderid" , "XOGOTP"},
                            //        {"channel", "Trans" },
                            //        {"DCS", "0" },
                            //        {"number" , message.Destination},
                            //        {"message" , message.Body },
                            //        {"route", "1" }
                            //    });
                            //    string result = System.Text.Encoding.UTF8.GetString(response);

                            //}

                            using (var wb = new WebClient())
                            {
                                byte[] response = wb.UploadValues("https://api.textlocal.in/send/", new NameValueCollection()
                                {
                                    {"apikey" , AppConfig.TextLocalAPIKey},
                                    {"numbers" , message.Destination},
                                    {"message" , message.Body },
                                    {"sender" , "TXTLCL"}
                                });
                                string result = System.Text.Encoding.UTF8.GetString(response);

                            }


                        }
                        break;
                    }
            }

            return Task.FromResult(0);
        }
    }
}
