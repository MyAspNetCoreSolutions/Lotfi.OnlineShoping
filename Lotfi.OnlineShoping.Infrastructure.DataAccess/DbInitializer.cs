using Lotfi.OnlineShoping.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lotfi.OnlineShoping.Infrastructure.DataAccess
{
    public static class DbInitializer
    {
        public static void Initialize(MyShopContext context)
        {
            context.Database.EnsureCreated();

            if (context.Products.Any())
            {
                //BD has been Seed
                return;
            }

            var categories = new Category[]
                {
                    new Category(){CategoryName="c1"},
                    new Category(){CategoryName="c2"},
                    new Category(){CategoryName="c3"},
                    new Category(){CategoryName="c4"}
                };
            foreach (Category category in categories)
            {
                context.Categories.Add(category);
            }
            context.SaveChanges();

            var products = new Product[] 
                {
                    new Product(){Title="Title1",SubTitle="SubTitle1",CategoryID=1,Price=1000,ImageUrl="ImageUrl1"},
                    new Product(){Title="Title2",SubTitle="SubTitle2",CategoryID=1,Price=1000,ImageUrl="ImageUrl2"},
                    new Product(){Title="Title3",SubTitle="SubTitle3",CategoryID=2,Price=1000,ImageUrl="ImageUrl3"},
                    new Product(){Title="Title4",SubTitle="SubTitle4",CategoryID=3,Price=1000,ImageUrl="ImageUrl4"},
                    new Product(){Title="Title5",SubTitle="SubTitle5",CategoryID=2,Price=1000,ImageUrl="ImageUrl5"},
                    new Product(){Title="Title6",SubTitle="SubTitle6",CategoryID=2,Price=1000,ImageUrl="ImageUrl6"}
                };

            foreach (Product product in products)
            {
                context.Products.Add(product);
            }
            context.SaveChanges();

            var customers = new Customer[]
            {
                new Customer(){UserName="lotfi1008",FirsName="Mohammad",LastName="Lotfi",Email="Lotfi.engin@gmail.com",RegisterDate=DateTime.Now,Password="123456789"},
                new Customer(){UserName="lotfi1009",FirsName="Mahan",LastName="Lotfi",Email="Lotfi.Mahan@gmail.com",RegisterDate=DateTime.Now,Password="123456789"}
            };

            foreach (Customer customer in customers)
            {
                context.Customers.Add(customer);
            }
            context.SaveChanges();

        }
    }
}
