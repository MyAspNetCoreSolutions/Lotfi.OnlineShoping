using System;
using System.Collections.Generic;
using System.Text;

namespace Lotfi.DataAccessLayer
{
    public class Order
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public DateTime OrderDate { get; set; }

        public Customer Customer { get; set; }
        public Product Product { get; set; }
    }
}
