using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace decisions
{
    public interface IStorage
    {
        void Upload(string filePath);
        void Download(string fileName);
    }
}