using System;
using System.Collections.Generic;
using System.Text;

namespace Lotfi.OnlineShoping.Domain.Entities
{
    public class Order:BaseEntity
    {
        
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public DateTime OrderDate { get; set; }

        public Customer Customer { get; set; }
        public Product Product { get; set; }
    }
}
