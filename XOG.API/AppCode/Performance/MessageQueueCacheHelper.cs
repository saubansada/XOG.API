using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace XOG.AppCode.Performance
{
    public class MessageQueueCacheHelper
    {
        private DateTimeOffset defaultOffset = DateTimeOffset.Now.AddMinutes(30);

        private static readonly Lazy<MessageQueueCacheHelper> _instance = new Lazy<MessageQueueCacheHelper>(() => new MessageQueueCacheHelper());

        private readonly MemoryCache _cache;

        private MessageQueueCacheHelper()
        {
            _cache = MemoryCache.Default;
        }

        public static MessageQueueCacheHelper Instance
        {
            get { return _instance.Value; }
        }

        public void Add<T>(string cacheKey, T message)
        {
            var queue = GetOrAdd(cacheKey, () => new Queue<T>(), defaultOffset);

            queue.Enqueue(message);
            _cache.Set(cacheKey, queue, defaultOffset);             
        }

        public T Get<T>(string cacheKey)
        {
            T item = Activator.CreateInstance<T>();
            var queue = _cache.Get(cacheKey) as Queue<T>;
            if(queue != null)
            {
                item = queue.Dequeue();
            }
            return item;
        }

        public List<T> GetAll<T>(string cacheKey)
        {
            var listItems = new List<T>();

            var queue = _cache.Get(cacheKey) as Queue<T>;
            if (queue != null)
            {
                while (queue.Count > 0)
                {
                    var item = queue.Dequeue();

                    listItems.Add(item);
                }
                 
                _cache.Remove(cacheKey);
            }
            return listItems;
        }

        public T GetOrAdd<T>(string key, Func<T> valueFactory, DateTimeOffset absoluteExpiration)
        {
            var newValue = new Lazy<T>(valueFactory);
            var oldValue = _cache.AddOrGetExisting(key, newValue, absoluteExpiration) as Lazy<T>;
            return (oldValue ?? newValue).Value;
        }

        public async Task<T> GetOrAddAsync<T>(string key, Func<Task<T>> valueFactory, DateTimeOffset absoluteExpiration)
        {
            var newValue = new Lazy<Task<T>>(valueFactory);
            var oldValue = _cache.AddOrGetExisting(key, newValue, absoluteExpiration) as Lazy<Task<T>>;
            return await (oldValue ?? newValue).Value;
        }
    }
}
