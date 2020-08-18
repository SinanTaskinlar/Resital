using System;
using Model;
using Resital.Core.Services;

namespace BLL.Abstract
{
    public interface ICartService : IServiceBase
    {
        void InitCart(Guid userId);
        Cart GetCartByUserId(Guid userId);
        void AddToCart(Guid userId, Guid productId, int quantity);
        void DeleteFromCart(Guid userId, Guid productId);
        void ClearCart(Guid cartId);
    }
}