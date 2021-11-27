using System.Web.UI;

namespace XOG.Models
{
    public class OListItem
    {
        public string Text { get; set; }
        public string Value { get; set; }
        public bool Selected { get; set; }
        public bool Disabled { get; set; }
        public dynamic Extras { get; set; }
        public AttributeCollection Attributes { get; set; }
    }
}
