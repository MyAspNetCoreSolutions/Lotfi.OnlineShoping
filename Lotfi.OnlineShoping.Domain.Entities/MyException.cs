using System;
using System.Collections.Generic;
using System.Text;

namespace Lotfi.OnlineShoping.Domain.Entities
{
    public class MyException:BaseEntity
    {
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; }
        public string InnerMessage { get; set; }
        public bool IsReaded { get; set; }
        public string Model { get; set; }
    }
}
