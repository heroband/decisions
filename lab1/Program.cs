using System;
using decisions;

User denys = new User("Denys", new LocalDiskStorage());
User alex = new User("Alex", new AmazonS3Storage());

denys.UploadUserFile("path/toLocal/file.txt");
alex.UploadUserFile("path/toAmazonS3/file.txt");

StorageManager storageManager = StorageManager.GetInstance();
Console.WriteLine($"storageManager: {storageManager.GetStorage()}");

storageManager.SetStorage(new AmazonS3Storage());
Console.WriteLine($"storageManager: {storageManager.GetStorage()}");

denys.DownloadUserFile("file_from_local.txt");
alex.DownloadUserFile("file_from_s3.txt");
