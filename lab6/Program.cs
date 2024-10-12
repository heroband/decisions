using lab6;

string fileUrl = "http://example.com/file.txt";

IDownloader simpleDownloader = new SimpleDownloader();
IDownloader cachingDownloader = new CachingDownloader(simpleDownloader);

cachingDownloader.Download(fileUrl); // downloading url using simpleDownloader
cachingDownloader.Download(fileUrl); // downloading url using cache

