using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Log4netMongodb;

namespace Log4NetMongodbCon
{
    class Program
    {
        static void Main(string[] args)
        {
            LogInfo info = new LogInfo
            {
                UserName = "admin",
                UserType = "1",
                Status = "2",
                FailPwd = "FailPwd",
                LogIp =  "123",
                LogIpLocation = "1325",
                UserAgent =
                    "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36",
                Referrer = "www.baidu.com"
            };
            ILog log = new MongodbLog().RetLog(info);
            log.Info("测试");
            Console.Write(log.Logger.Name+"........");
            Console.ReadLine();
        }
    }

    internal class LogInfo
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
