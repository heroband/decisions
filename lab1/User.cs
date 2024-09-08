using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace decisions
{
    public class User
    {
        public string? UserName { get; set; }
        public IStorage UserStorage { get; set; }

        public User(string userName, IStorage storage)
        {
            UserName = userName;
            UserStorage = storage;
        }

        public void UploadUserFile(string filePath)
        {
            UserStorage.Upload(filePath);
        }

        public void DownloadUserFile(string fileName)
        {
            UserStorage.Download(fileName);
        }
    }
}