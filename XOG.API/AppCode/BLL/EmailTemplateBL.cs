using XOG.AppCode.DAL; 
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using XOG.AppCode.Models;

namespace XOG.Areas.MyAdmin.BL
{
    public class EmailTemplateBL
    {
        public static List<EmailTemplateModel> GetAllEmailModels()
        {
            var EmailTemplates = new List<EmailTemplateModel>();
            using (var Context = new XOGEntities())
            {
                foreach (var template in (from t in Context.EmailTemplates select t).ToList())
                {
                    EmailTemplates.Add(new EmailTemplateModel { ID = template.Id, TemplateCategory = template.TemplateCategory, TemplateName = template.TemplateName, HtmlMarkup = template.HtmlMarkup, Description = template.Description });
                }
            }
            return EmailTemplates;
            //ForTest...
            //return new List<EmailTemplateModel>() {
            //    new EmailTemplateModel() {  HtmlMarkup = "<html><body>Hello {USERNAME}!<br><br><p>Welcome to PerSquared</p></body></html>", TemplateName = "WelcomeTemplate", Description = "This Template will be used for Sending Welcome Emails", TemplateCategory=1 },
            //    new EmailTemplateModel() {  HtmlMarkup = "<html><body>Hello {USERNAME}!<br><br><p>Your Payment is Seccussfull, You Have Purchased {PlanName} of {COST} KD fro {YEARS} Years </p></body></html>",TemplateName = "PaymentConfirmationTemplate", Description = "This Template will be used for Send Payment Infromation",   TemplateCategory=2 },
            //    new EmailTemplateModel() {  HtmlMarkup = "<html><body>Hello {USERNAME}!<br><br><p>Check out what you can do in PerSquared - <a href='{link}'>click here'</a></p></body></html>", TemplateName = "DocumentationTemplate", Description = "This Template will used to send the email of documentation", TemplateCategory=3 }
            //};
        }

        public static string GetEmailMarkup(EmailType Category)
        {
            using (var context = new XOGEntities())
            {
                return context.EmailTemplates.Where(i => i.TemplateCategory == (int)Category).Select(i => i.HtmlMarkup).FirstOrDefault();
            }
        }

        public static async Task<string> GetEmailMarkupAsync(EmailType Category)
        {
            using (var context = new XOGEntities())
            {
                return await context.EmailTemplates.Where(i => i.TemplateCategory == (int)Category).Select(i => i.HtmlMarkup).FirstOrDefaultAsync();
            }
        }

        public static EmailTemplateModel GetEmailTemplateById(int ID)
        {
            var emailTemplateModel = new EmailTemplateModel();
            using (var Context = new XOGEntities())
            {
                var template = (from c in Context.EmailTemplates where c.Id == ID select c).Single();
                emailTemplateModel = new EmailTemplateModel { ID = template.Id, TemplateCategory = template.TemplateCategory, TemplateName = template.TemplateName, HtmlMarkup = template.HtmlMarkup, Description = template.Description };
            }
            return emailTemplateModel;
            //The below return statement must be replaced by above code..
            // For Test
            // return new EmailTemplateModel() { HtmlMarkup = "<html><body>Hello {USERNAME}!<br><br><p>Check out what you can do in PerSquared - <a href='{link}'>click here'</a></p></body></html>", Description = "This Template will used to send the email of documentation", TemplateCategory = 3 };
        }

        internal static void EditEmailTemplate(EmailTemplateModel emailTemplateModel)
        {
            try
            {
                using (var Context = new XOGEntities())
                {
                    var template = (from c in Context.EmailTemplates where c.Id == emailTemplateModel.ID select c).SingleOrDefault();
                    template.TemplateName = emailTemplateModel.TemplateName;
                    template.TemplateCategory = emailTemplateModel.TemplateCategory;
                    template.HtmlMarkup = emailTemplateModel.HtmlMarkup;
                    template.Description = emailTemplateModel.Description;
                    Context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}
