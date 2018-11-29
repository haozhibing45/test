using System;
using log4net;

namespace Log4NetMongodbCon
{
    class Program
    {
        static void Main(string[] args)
        {
      
            MongoDbHelper<LogInfo> mg = new MongoDbHelper<LogInfo>();
           
            for (int i = 0; i < 10; i++)
            {
                LogInfo info = new LogInfo
                {
                    UserName = "admin",
                    UserType = i.ToString(),
                    Status = "2",
                    FailPwd = "FailPwd",
                    LogIp = "123",
                    LogIpLocation = "1325",
                    UserAgent =
                        "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36",
                    Referrer = "www.baidu.com"
                };
                mg.Insert(info);
            }

            var list = mg.QueryAll();
            foreach (var item in list)
            {
                Console.WriteLine(item.Id);
            }
          
            //            ILog log = new MongodbLog().RetLog(info);
            //            log.Info("测试");
            //            Console.Write(log.Logger.Name+"........");
            Console.ReadLine();
        }
    }

    internal class LogInfo:BaseEntity
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserType { get; set; }
        public string Status { get; set; }
        public string FailPwd { get; set; }
        public string LogIp { get; set; }
        public string LogIpLocation { get; set; }
        public string UserAgent { get; set; }
        public string Referrer { get; set; }
    }
}
