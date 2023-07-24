using ECM.Api.Authorization;
using ECM.Api.Models;
using ECM.Repo.Domain;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECM.Repo.Services
{
    public interface ICacheService
    {
       object? GetCache(string key);
        void SetCache(string key, object value);
    }
    public class CacheService : ICacheService
    {
        private readonly IMemoryCache memoryCachekey;

        public CacheService(IMemoryCache memoryCachekey)
        {
            this.memoryCachekey = memoryCachekey;
        }
        public object? GetCache(string key)
        {
            memoryCachekey.TryGetValue(key, out var value);
            return value;
        }

        public void SetCache(string key, object value)
        {
            var cacheExpiryOptions = new MemoryCacheEntryOptions
            {
                AbsoluteExpiration = DateTime.Now.AddMinutes(5),
                Priority = CacheItemPriority.High,
                SlidingExpiration = TimeSpan.FromMinutes(2),
                Size = 1024
            };
            memoryCachekey.Set(key, value);
        }
    }


}
