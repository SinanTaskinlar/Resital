using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models
{
    public class CartModel
    {
        public Guid CartId { get; set; }
        public List<CartItemModel> CartItems { get; set; }
    }

    public class CartItemModel
    {
        public Guid CartItemId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
