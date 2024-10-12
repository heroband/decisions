using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab6
{
    public class CachingDownloader : IDownloader
    {
        private readonly IDownloader _simpleDownloader;
        private readonly HashSet<string> _cache;

        public CachingDownloader(IDownloader simpleDownloader)
        {
            _simpleDownloader = simpleDownloader;
            _cache = new HashSet<string>();
        }

        public void Download(string url)
        {
            if (_cache.Contains(url))
            {
                System.Console.WriteLine($"Downloading {url} using cache");
                return;
            }

            _simpleDownloader.Download(url);
            _cache.Add(url);
        }
    }
}