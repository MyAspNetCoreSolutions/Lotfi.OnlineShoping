using System;
using System.Collections.Generic;
using System.Text;

namespace Lotfi.DataAccessLayer
{
    public class Peyment
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        //
        public Order Order { get; set; }
    }
}
