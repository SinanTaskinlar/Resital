using AutoMapper;
using BLL.Abstract;
using Model;
using Resital.Core.Data.UnitOfWork;
using System;
using System.Linq;

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

        public void InitCart(Guid userId)
        {
            _uow.GetRepository<Cart>().Insert(new Cart()
            {
                UserId = userId
            });
        }

        public Cart GetCartByUserId(Guid userId)
        {
            var a = _uow.GetRepository<Cart>().GetById(z => z.UserId == userId);
            //return _mapper.Map<CartDTO>(a);
            return a;
        }

        public void AddToCart(Guid userId, Guid roomId, int quantity)
        {
            var cart = GetCartByUserId(userId);

            if (cart != null)
            {
                var index = cart.CartItems.FindIndex(i => i.RoomId == roomId);
                if (index < 0)
                {
                    cart.CartItems.Add(new CartItem()
                    {
                        RoomId = roomId,
                        Quantity = quantity,
                        CardId = cart.Id
                    });
                }
                else
                {
                    cart.CartItems[index].Quantity += quantity;
                }

                _uow.GetRepository<Cart>().Update(cart);
            }
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