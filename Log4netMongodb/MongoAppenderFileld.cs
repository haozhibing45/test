using log4net.Layout;

namespace Log4netMongodb
{
    public class MongoAppenderFileld
    {

        public string Name { get; set; }
        public IRawLayout Layout { get; set; }
    }
}