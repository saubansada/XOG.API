using System;

namespace XOG.Models
{
    [Serializable]
    public class SerializableSession
    {
        public object SessionObject
        {
            get;
            set;
        }
    }
}
