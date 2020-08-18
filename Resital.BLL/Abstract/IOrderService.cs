using System;
using System.Collections.Generic;
using System.Text;
using Dto;

namespace BLL.Abstract
{
    public interface IOrderService
    {
        void Create(OrderDTO entity);
        List<OrderDTO> GetOrders(string userId);
    }
}
