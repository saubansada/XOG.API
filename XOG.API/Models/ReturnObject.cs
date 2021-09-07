using System;

namespace XOG.Models
{
    public class ReturnObject<T>
    {
        public bool IsSuccess { get; set; }

        public string Message { get; set; }

        public ApiResult Result { get; set; }

        public T Data { get; set; }

        public Exception Error { get; set; }
    }
}