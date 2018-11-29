using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using log4net;

namespace webtestadmin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
//            LogInfo info = new LogInfo
//            {
//                UserName = "admin",
//                UserType = "1",
//                Status = "2",
//                FailPwd = "FailPwd",
//                LogIp = Request.UserHostAddress,
//                LogIpLocation = Request.Url.ToString(),
//                UserAgent =
//                    "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36",
//                Referrer = "www.baidu.com"
//            };
//            log4net.Config.XmlConfigurator.Configure();
//            GlobalContext.Properties["userName"] = info.UserName;
//            GlobalContext.Properties["userType"] = info.UserType;
//            GlobalContext.Properties["status"] = info.Status;
//            GlobalContext.Properties["failPwd"] = info.FailPwd;
//            GlobalContext.Properties["myLogIP"] = info.LogIp;
//            GlobalContext.Properties["myLogIPLocation"] = info.LogIpLocation;
//            GlobalContext.Properties["userAgent"] = info.UserAgent;
//            GlobalContext.Properties["referrer"] = info.Referrer;
//            GlobalContext.Properties["CreateTime"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
//            ILog log = LogManager.GetLogger("syslog");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
//                log.InfoFormat("测试记录{0}", i);
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}