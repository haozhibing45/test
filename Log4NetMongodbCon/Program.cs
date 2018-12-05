using System;
using System.Diagnostics;
using System.Reflection;
using log4net;
using TestMogonDbCURD;

namespace Log4NetMongodbCon
{
    class Program
    {
        static void Main(string[] args)
        {

            info();
           
          
            //            ILog log = new MongodbLog().RetLog(info);
            //            log.Info("测试");
            //            Console.Write(log.Logger.Name+"........");
            Console.ReadLine();
        }
        public static void info()
        {

            MongoDbHelper<LogInfoTest> mg = new MongoDbHelper<LogInfoTest>();

            for (int i = 0; i < 2; i++)
            {
                StackTrace ss = new StackTrace(true);
                //index:0为本身的方法；1为调用方法；2为其上上层，依次类推
                MethodBase mb = ss.GetFrame(1).GetMethod();
                string systemModule = Environment.NewLine;
                systemModule += "模块名:" + mb.Module + Environment.NewLine;
                systemModule += "命名空间名:" + mb.ReflectedType.Namespace + Environment.NewLine;
                //完全限定名，包括命名空间
                systemModule += "类名:" + mb.ReflectedType.FullName + Environment.NewLine;
                systemModule += "方法名:" + mb.Name;
                StackFrame[] sfs = ss.GetFrames();
                LogInfoTest info = new LogInfoTest
                {
                    UserName = "admin",
                    UserType = i.ToString(),
                    Status = "2",
                    FailPwd = systemModule,
                    LogIp = "123",
                    LogIpLocation = "1325",
                    UserAgent =
                        "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36",
                    Referrer = null
                };
                mg.Insert(info);
              
            }
            var list = mg.QueryAll();
            foreach (var item in list)
            {
                Console.WriteLine(item.Id);
            }

        }

    }
    internal class LogInfoTest:BaseEntity
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
