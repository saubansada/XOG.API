using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using XOG.AppCode.Models;

namespace XOG.Models.ViewModels.RequestViewModels.Data
{
    public class SettingsVM : BaseModel
    {
        public string Taxes { get; set; }
    }
}