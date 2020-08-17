using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using AutoMapper;
using BLL.Abstract;
using Dto;
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

        public CartDTO GetCartByUserId(string userId)
        {
            var a = _uow.GetRepository<Cart>().GetById(z => z.UserId == userId);
            return _mapper.Map<CartDTO>(a);
        }

        public void AddToCart(string userId, int productId, int quantity)
        {
            throw new NotImplementedException();
        }

        public void DeleteFromCart(Guid userId, Guid roomId)
        {
            var a = _uow.GetRepository<Cart>().GetById(z => z.UserId == userId);
            var itemList = a.CartItems.Where(z => z.RoomId == roomId).ToList();
            foreach (var item in itemList)
            {
                a.CartItems.Remove(item);
            }
            _uow.GetRepository<Cart>().Update(a);
        }

        public void ClearCart(Guid cartId)
        {
            var a = _uow.GetRepository<Cart>().GetById(z => z.Id == cartId);
            a.CartItems.Clear();
            _uow.GetRepository<Cart>().Update(a);
            _uow.SaveChanges();
        }
    }
}
