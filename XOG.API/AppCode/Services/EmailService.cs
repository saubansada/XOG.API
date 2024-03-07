using Microsoft.AspNet.Identity;
using XOG.Helpers;
using System.Threading.Tasks;

namespace XOG.Services
{
    public class EmailService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            return MailHelper.SendAsync(message);
        }
    }
}
