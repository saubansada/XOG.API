using System.ComponentModel.DataAnnotations;
using XOG.AppCode.Models;

namespace XOG.Models.ViewModels
{
    public class WeekDayStatusRequestVM : BaseModel
    {
        public byte DayId { get; set; }
        public bool IsDayActive { get; set; }
        public string DayName { get; set; }

        public DeliveryTimingRequestVM DeliveryTimings { get; set; }
    }

    public class DeliveryTimingRequestVM : BaseModel
    {
        public short Id { get; set; }
        public byte DayId { get; set; }
        public short FromHours { get; set; }
        public short FromMinutes { get; set; }
        public short ToHours { get; set; }
        public short ToMinutes { get; set; }
        public bool IsActive { get; set; }
    }
}