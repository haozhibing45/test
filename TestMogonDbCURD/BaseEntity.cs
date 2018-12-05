using System;

namespace TestMogonDbCURD
{
    public class BaseEntity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string State { get; set; }

        public string CreateTime { get; set; }

        public string UpdateTime { get; set; }
    }
}