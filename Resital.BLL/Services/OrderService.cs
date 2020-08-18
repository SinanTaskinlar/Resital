using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using BLL.Abstract;
using Dto;
using Model;
using Resital.Core.Data.UnitOfWork;
using Resital.DTO;
using Resital.Model;

namespace BLL.Services
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public OrderService(IUnitOfWork uow, IMapper mapper)
        {
            this._uow = uow;
            this._mapper = mapper;
        }
        public void Create(OrderDTO entity)
        {
            var order = _mapper.Map<Order>(entity);
            _uow.GetRepository<Order>().Insert(order);
            _uow.SaveChanges();
        }

        public List<OrderDTO> GetOrders(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
