using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab6
{
    public class SimpleDownloader : IDownloader
    {
        public void Download(string url)
        {
            Console.WriteLine($"Downloading {url} using SimpleDownloader");
        }
    }
}