using Lotfi.OnlineShoping.Domain.Contract.ApplicationService;
using Lotfi.OnlineShoping.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lotfi.OnlineShoping.Infrastructure.AppService
{
    public class OrderServce : IOrderService
    {
        IOrderRepository _orderRepository;
        public OrderServce(IOrderRepository orderRepository)
        {
            this._orderRepository = orderRepository;
        }
        public void Add(Order order)
        {
            _orderRepository.Insert(order);
        }
    }
}
