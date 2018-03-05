using System;
using System.Collections.Generic;
using System.Text;

namespace Lotfi.OnlineShoping.Domain.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public int CategoryID { get; set; }

        public Category category { get; set; }//Navigation property

    }
}
