using System;
using System.Collections.Generic;
using AutoMapper;
using BLL.Abstract;
using Dto;
using Model;
using Resital.Core.Data.UnitOfWork;

namespace BLL.Services
{
    public class OrderService : IOrderService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public OrderService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
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