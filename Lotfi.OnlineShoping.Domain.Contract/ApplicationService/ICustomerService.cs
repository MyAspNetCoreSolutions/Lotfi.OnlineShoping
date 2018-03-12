using Lotfi.OnlineShoping.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lotfi.OnlineShoping.Domain.Contract.ApplicationService
{
    public interface ICustomerService
    {
        void Add(Customer customer);
        IEnumerable<Customer> Get();
        Customer Find(int id);
    }
}
