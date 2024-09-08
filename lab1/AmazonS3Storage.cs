using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace decisions
{
    public class AmazonS3Storage : IStorage
    {
        public void Download(string fileName)
        {
            // download file from AmazonS3
        }

        public void Upload(string filePath)
        {
            // upload file to AmazonS3
        }
    }
}