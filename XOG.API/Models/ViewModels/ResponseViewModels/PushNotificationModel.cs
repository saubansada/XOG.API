using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XOG.AppCode.Models;

namespace XOG.Models.ViewModels.RequestViewModels.Data
{
    public class PushNotificationViewModel : BaseModel
    {
        public long NotificationToken { get; set; }
        public long NotificationId { get; set; }
        public bool IsBackground { get; set; }
        public bool IsForeground { get; set; }
        public bool IsNotified { get; set; }
        public bool IsViewed { get; set; }
    }
}
