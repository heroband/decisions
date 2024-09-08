using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace decisions
{
    public class LocalDiskStorage : IStorage
    {
        public void Download(string fileName)
        {
            // download file from local disk
        }

        public void Upload(string filePath)
        {
            // upload file to local disk   
        }
    }
}