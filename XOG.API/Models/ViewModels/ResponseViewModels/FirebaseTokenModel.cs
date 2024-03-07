using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XOG.AppCode.Models;

namespace XOG.Models.ViewModels.RequestViewModels.Data
{
    public class SaveFirebaseTokenViewModel : BaseModel
    {
        public string UserToken { get; set; }

        public string UserId { get; set; }
    }
}
