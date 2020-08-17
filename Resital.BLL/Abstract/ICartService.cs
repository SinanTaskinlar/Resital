using System;
using System.Collections.Generic;
using System.Text;
using Dto;
using Resital.Core.Services;

namespace BLL.Abstract
{
    public interface ICartService : IServiceBase
    {
        void InitCart(string userId);
        CartDTO GetCartByUserId(string userId);
        void AddToCart(string userId, int productId, int quantity);
        void DeleteFromCart(string userId, int productId);
        void ClearCart(int cartId);
    }
}
