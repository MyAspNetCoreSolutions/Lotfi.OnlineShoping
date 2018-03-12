using Lotfi.OnlineShoping.Domain.Contract.ApplicationService;
using Lotfi.OnlineShoping.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lotfi.OnlineShoping.Infrastructure.AppService
{
    public class OrderServce : IOrderService
    {
        #region Fileds
        IOrderRepository _orderRepository;
        #endregion

        #region Constractor
        public OrderServce(IOrderRepository orderRepository)
        {
            this._orderRepository = orderRepository;
        }
        #endregion

        #region Property
        #endregion

        #region Methods
        public void Add(Order order)
        {
            _orderRepository.Insert(order);
        }
        #endregion
    }
}
