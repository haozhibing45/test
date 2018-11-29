using System;
using System.Configuration;
using System.Reflection;
using log4net;
using log4net.Config;
using log4net.Layout;
using log4net.Repository;

namespace Log4netMongodb
{
    /// <summary>
    /// 动态输出日志需要在WebConfig配置链接字符串和数据库名称
    /// </summary>
    public class MongodbLog
    {
        /// <summary>
        /// 默认返回
        /// </summary>
        public ILog RetLog()
        {
            MongoDBAppender appender = new MongoDBAppender
            {
                DatabaseName = ConfigurationManager.AppSettings["MongodbDatabaseName"],
                CollectionName = DateTime.Now.ToString("yyyyMMdd")+"log",
                ConnectionStringName = "MongodbConnection",
                Name = "MongoDBAppender"
            };
            var rep = LogManager.CreateRepository(Guid.NewGuid().ToString());
            BasicConfigurator.Configure(rep, appender);
            return LogManager.GetLogger(rep.Name, "syslog");
        }
        /// <summary>
        /// 自定义属性
        /// </summary>
        /// <typeparam name="T">传入实体对象</typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public ILog RetLog<T>(T t)
        {
            MongoDBAppender appender = new MongoDBAppender
            {
                DatabaseName = ConfigurationManager.AppSettings["MongodbDatabaseName"],
                CollectionName = DateTime.Now.ToString("yyyyMMdd") + "log",
                ConnectionStringName = "MongodbConnection",
                Name = "MongoDBAppender"
            };
           
            PropertyInfo[] info = t.GetType().GetProperties();
            ILoggerRepository rep = LogManager.CreateRepository(Guid.NewGuid().ToString());
            foreach (var item in info)
            {
                MongoAppenderFileld filled = new MongoAppenderFileld();
                filled.Name = item.Name;
                var layout = new RawPropertyLayout {Key = item.Name};
                filled.Layout = layout;
                appender.AddField(filled);
            }
            BasicConfigurator.Configure(rep, appender);
            foreach (var item in info)
            {
               ThreadContext.Properties[item.Name]= item.GetValue(t, null);
                //GlobalContext.Properties[item.Name] = item.GetValue(t, null);
            }
            return LogManager.GetLogger(rep.Name, "syslog");
        }
    }
}