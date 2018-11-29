
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Log4NetIntoMongodb.Models
{
    public class LogInfo
    {
        public  string UserId { get; set; }
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