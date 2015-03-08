using ImgMobileLib.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgMobileLib.RequestService
{
    class ImgurRouteCache
    {
        private const int CacheCapacity = 250;
        private static LRUCache<ImgurRequest<Object>> _cache = new LRUCache<ImgurRequest<object>>(CacheCapacity);

        public static bool TryGetCached(String route, out ImgurRequest<Object> result)
        {
            foreach (var cached in _cache)
            {
                if (cached.Route == route)
                {
                    result = cached;
                    return true;
                }
            }

            result = null;
            return false;
        }

        public static void Add(ImgurRequest<Object> request)
        {
            _cache.Add(request);
        }
    }
}
