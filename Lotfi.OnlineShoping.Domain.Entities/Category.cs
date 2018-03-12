using System;
using System.Collections.Generic;
using System.Text;

namespace Lotfi.OnlineShoping.Domain.Entities
{
    public class Category:BaseEntity
    {
        public string CategoryName { get; set; }
        public int? ParentID { get; set; }

        ICollection<Category> Categories { get; set; }
    }
}
