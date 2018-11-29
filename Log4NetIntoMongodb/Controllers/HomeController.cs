using Log4NetIntoMongodb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Xml;
using log4net;
using log4net.Config;
using log4net.Core;
using log4net.Layout;
using log4net.Repository;
using Log4Mongo;

//[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]
namespace Log4NetIntoMongodb.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //            XmlDocument log4netConfig = new XmlDocument();
            //            #region Load log4netConfig
            //
            //            string xml = string.Format(
            //                @"<appender name=""MongoDBAppender"" type=""Log4Mongo.MongoDBAppender,Log4Mongo"">
            //                        <connectionString value=""mongodb://root:123456@127.0.0.1:27017""/>
            //                        <DatabaseName value=""{0}""/>
            //                        <CollectionName value=""{1}""/>
            //                        <field>
            //                        <name type=""userId""/>
            //                        <layout type=""log4net.Layout.RawPropertyLayout"">
            //                        <key type=""userId""/>
            //                        </layout>
            //                        </field>
            //                        <field>
            //                        <name type=""userName""/>
            //                        <layout type=""log4net.Layout.RawPropertyLayout"">
            //                        <key type=""userName""/>
            //                        </layout>
            //                        </field>
            //                        <field>
            //                        <name type=""userType""/>
            //                        <layout type=""log4net.Layout.RawPropertyLayout"">
            //                        <key type=""userType""/>
            //                        </layout>
            //                        </field>
            //                        <field>
            //                        <name type=""status""/>
            //                        <layout type=""log4net.Layout.RawPropertyLayout"">
            //                        <key type=""status""/>
            //                        </layout>
            //                        </field>
            //                        <field>
            //                        <name type=""failPwd""/>
            //                        <layout type=""log4net.Layout.RawPropertyLayout"">
            //                        <key type=""failPwd""/>
            //                        </layout>
            //                        </field>
            //                        <field>
            //                        <name type=""myLogIP""/>
            //                        <layout type=""log4net.Layout.RawPropertyLayout"">
            //                        <key type=""myLogIP""/>
            //                        </layout>
            //                        </field>
            //                        <field>
            //                        <name type=""myLogIPLocation""/>
            //                        <layout type=""log4net.Layout.RawPropertyLayout"">
            //                        <key type=""myLogIPLocation""/>
            //                        </layout>
            //                        </field>
            //                        <field>
            //                        <name type=""userAgent""/>
            //                        <layout type=""log4net.Layout.RawPropertyLayout"">
            //                        <key type=""userAgent""/>
            //                        </layout>
            //                        </field>
            //                        <field>
            //                        <name type=""referrer""/>
            //                        <layout type=""log4net.Layout.RawPropertyLayout"">
            //                        <key value=""referrer""/>
            //                        </layout>
            //                        </field>
            //                        <field>
            //                        <name value=""CreateTime""/>
            //                        <layout type=""log4net.Layout.RawPropertyLayout"">
            //                        <key value=""CreateTime""/>
            //                        </layout>
            //                        </field>
            //                        <field>
            //                        <name value=""DateTime""/>
            //                        <layout type=""log4net.Layout.RawTimeStampLayout""/>
            //                        </field>
            //                        <field>
            //                        <name value=""level""/>
            //                        <layout type=""log4net.Layout.PatternLayout"" value=""%level""/>
            //                        </field>
            //                        <field>
            //                        <name value=""thread""/>
            //                        <layout type=""log4net.Layout.PatternLayout"" value=""%thread""/>
            //                        </field>
            //                        <field>
            //                        <name value=""logger""/>
            //                        <layout type=""log4net.Layout.PatternLayout"" value=""%logger""/>
            //                        </field>
            //                        <field>
            //                        <name value=""message""/>
            //                        <layout type=""log4net.Layout.PatternLayout"" value=""%message""/>
            //                        </field>
            //                        <field>
            //                        <name value=""logIP""/>
            //                        <layout type=""log4net.Layout.PatternLayout"" value=""%logIP""/>
            //                        </field>
            //                        </appender>", DateTime.Now.ToString("yyyyMM"), DateTime.Now.ToString("yyyyMMdd"));
            //            log4netConfig.LoadXml(xml);
            //            #endregion


            //                        XmlConfigurator.Configure(rep, log4netConfig["log4net"]);
            //                        ILog log = LogManager.GetLogger(rep.Name, "syslog");

            XmlConfigurator.Configure();
            LogInfo info = new LogInfo
            {
                UserName = "admin",
                UserType = "1",
                Status = "2",
                FailPwd = "FailPwd",
                LogIp = Request.UserHostAddress,
                LogIpLocation = Request.Url.ToString(),
                UserAgent =
                    "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36",
                Referrer = "www.baidu.com"
            };
            ILog log = LogManager.GetLogger("syslog");

            //                       MongoDBAppender appender = new MongoDBAppender();
            //                       appender.CollectionName = DateTime.Now.ToString("yyyyMMdd");
            //                       appender.ConnectionString = "mongodb://root:123456@127.0.0.1:27017";
            //                       appender.Name = "MongoDBAppender";
            //                       MongoAppenderFileld filled = new MongoAppenderFileld();
            //                       filled.Name = "userName";
            //                       filled.Layout = new RawPropertyLayout { Key = "userName" };
            //                       appender.AddField(filled);
            //            
            //                       MongoAppenderFileld filled1 = new MongoAppenderFileld();
            //                       filled1.Name = "userType";
            //                       filled1.Layout = new RawPropertyLayout { Key = "userType" };
            //                       appender.AddField(filled1);
            //                       MongoAppenderFileld filled2 = new MongoAppenderFileld();
            //                       filled2.Name = "status";
            //            
            //                       filled2.Layout = new RawPropertyLayout { Key = "status" };
            //                       appender.AddField(filled2);
            //                       MongoAppenderFileld filled3 = new MongoAppenderFileld();
            //                       filled3.Name = "failPwd";
            //                       filled3.Layout = new RawPropertyLayout { Key = "failPwd" };
            //                       appender.AddField(filled3);
            //                       MongoAppenderFileld filled4= new MongoAppenderFileld();
            //                       filled4.Name = "myLogIP";
            //                       filled4.Layout = new RawPropertyLayout { Key = "myLogIP" };
            //                       appender.AddField(filled4);
            //                       MongoAppenderFileld filled5 = new MongoAppenderFileld();
            //                       filled5.Name = "myLogIPLocation";
            //                       filled5.Layout = new RawPropertyLayout { Key = "myLogIPLocation" };
            //                       appender.AddField(filled5);
            //                       MongoAppenderFileld filled6 = new MongoAppenderFileld();
            //                       filled6.Name = "userAgent";
            //                       filled6.Layout = new RawPropertyLayout { Key = "userAgent" };
            //                       appender.AddField(filled6);
            //                       MongoAppenderFileld filled7 = new MongoAppenderFileld();
            //                       filled7.Name = "referrer";
            //                       filled7.Layout = new RawPropertyLayout { Key = "referrer" };
            //                       appender.AddField(filled7);
            //                       MongoAppenderFileld filled8 = new MongoAppenderFileld();
            //                       filled8.Name = "CreateTime";
            //                       filled8.Layout = new RawPropertyLayout { Key = "CreateTime" };
            //                       appender.AddField(filled8);
            //            
//            ILoggerRepository rep = LogManager.CreateRepository(Guid.NewGuid().ToString());
            //                       BasicConfigurator.Configure(rep, appender);
            //BasicConfigurator.Configure(appender);
            GlobalContext.Properties["userName"] = info.UserName;
            GlobalContext.Properties["userType"] = info.UserType;
            GlobalContext.Properties["status"] = info.Status;
            GlobalContext.Properties["failPwd"] = info.FailPwd;
            GlobalContext.Properties["myLogIP"] = info.LogIp;
            GlobalContext.Properties["myLogIPLocation"] = info.LogIpLocation;
            GlobalContext.Properties["userAgent"] = info.UserAgent;
            GlobalContext.Properties["referrer"] = info.Referrer;
            GlobalContext.Properties["CreateTime"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
//            ILog log = LogManager.GetLogger(rep.Name,"syslog");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                log.InfoFormat("测试记录{0}", i);
            }
            //            ILog log = new MongodbLog().RetLog(info);
            //            log.Info("测试");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            LogInfo info = new LogInfo
            {
                UserName = "admin",
                UserType = "1",
                Status = "2",
                FailPwd = "FailPwd",
                LogIp = Request.UserHostAddress,
                LogIpLocation = Request.Url.ToString(),
                UserAgent =
                    "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36",
                Referrer = "www.baidu.com"
            };
            ILog log = new MongodbLog().RetLog(info);
            log.Info("测试");
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}