using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace decisions
{
    public class StorageManager
    {
        private static StorageManager _instance;
        private IStorage _storage;

        private StorageManager(IStorage? storage = null) {
            _storage = storage ?? new LocalDiskStorage();
        }

        public static StorageManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new StorageManager();
            }
            return _instance;
        }

        public void SetStorage(IStorage storage)
        {
            _storage = storage;
        }

        public IStorage GetStorage()
        {
            return _storage;
        }
    }
}