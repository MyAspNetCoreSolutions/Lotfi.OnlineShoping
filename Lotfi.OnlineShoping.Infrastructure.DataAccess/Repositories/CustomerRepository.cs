using Lotfi.OnlineShoping.Domain.Contract.ApplicationService;
using Lotfi.OnlineShoping.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lotfi.OnlineShoping.Infrastructure.DataAccess
{
    public class CustomerRepository : ICustomerRepository
    {
        #region Fields
        private MyShopContext _context;
        #endregion

        #region Constractor
        public CustomerRepository(MyShopContext context)
        {
            _context = context;
        }
        #endregion

        #region Methods
        public void Delete(Customer entity)
        {
            _context.Customers.Remove(entity);
        }

        public Customer Find(int id)
        {
            return _context.Customers.Find(id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers.AsEnumerable();
        }

        public void Insert(Customer entity)
        {
            _context.Customers.Add(entity);
        }

        public void Update(Customer entity)
        {
            _context.Update(entity);
        } 
        #endregion
    }
}
