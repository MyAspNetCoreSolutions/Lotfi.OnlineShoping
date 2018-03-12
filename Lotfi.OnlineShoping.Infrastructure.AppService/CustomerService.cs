using Lotfi.OnlineShoping.Domain.Contract.ApplicationService;
using Lotfi.OnlineShoping.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lotfi.OnlineShoping.Infrastructure.AppService
{
    public class CustomerService : ICustomerService
    {
        #region Fileds
        ICustomerRepository _customerRepository;
        #endregion

        #region Constractor
        public CustomerService(ICustomerRepository customerRepository)
        {
            this._customerRepository = customerRepository;
        }
        #endregion

        #region Property
        #endregion

        #region Methods
        public void Add(Customer customer)
        {
            _customerRepository.Insert(customer);
        }

        public Customer Find(int id)
        {
            return _customerRepository.Find(id);
        }

        public IEnumerable<Customer> Get()
        {
            return _customerRepository.GetAll();
        }
        #endregion
    }
}
