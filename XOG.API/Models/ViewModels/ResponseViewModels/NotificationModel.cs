using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XOG.AppCode.Models;

namespace XOG.Models.ViewModels.RequestViewModels.Data
{
    public class NotificationViewModel : BaseModel
    {
        public long NotificationId { get; set; }
        public bool IsBackground { get; set; }
        public bool IsForeground { get; set; }
        public bool IsNotified { get; set; }
        public string ActionUserId { get; set; }
        public string RecipientUserId { get; set; }
        public byte NotificationAspect { get; set; }
        public long AspectRecordId { get; set; }
        public string NavigatioUrl { get; set; }
        public string NotificationTitle { get; set; }
        public string NotificationMessage { get; set; }
        public string NotificationIconUrl { get; set; }
        public bool IsArchived { get; set; }
        public bool IsEmail { get; set; }
        public bool IsSMS { get; set; }
        public bool IsPushNotification { get; set; }
    }
}
