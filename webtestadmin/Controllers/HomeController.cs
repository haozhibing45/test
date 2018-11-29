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
            log4net.Config.XmlConfigurator.Configure();
            ILog log = LogManager.GetLogger("syslog");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                log.InfoFormat("测试记录{0}", i);
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