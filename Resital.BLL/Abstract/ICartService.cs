using System;
using System.Collections.Generic;
using System.Text;
using Resital.Core.Services;

namespace BLL.Abstract
{
    public interface ICartService : IServiceBase
    {
        void InitCart(string userId);
    }
}
