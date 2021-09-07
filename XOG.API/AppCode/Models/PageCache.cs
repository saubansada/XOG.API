using System.Web;

namespace XOG.Models
{
    public class PageCache
    {
        public string ID
        {
            get;
            set;
        }

        public HttpCacheability Location
        {
            get;
            set;
        }

        public int Minutes
        {
            get;
            set;
        }
    }
}
