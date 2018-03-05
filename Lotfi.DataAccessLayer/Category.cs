using System;
using System.Collections.Generic;
using System.Text;

namespace Lotfi.DataAccessLayer
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int? ParentID { get; set; }

        ICollection<Category> Categories { get; set; }
    }
}
