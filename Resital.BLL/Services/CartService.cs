using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using BLL.Abstract;
using Model;
using Resital.Core.Data.UnitOfWork;

namespace BLL.Services
{
    public class CartService : ICartService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public CartService(IUnitOfWork uow, IMapper mapper)
        {
            this._uow = uow;
            this._mapper = mapper;
        }
        public void InitCart(string userId)
        {
            _uow.GetRepository<Cart>().Insert(new Cart()
            {
                UserId = userId
            });
        }
    }
}
