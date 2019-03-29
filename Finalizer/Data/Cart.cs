using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finalizer.Data
{
    public class Cart
    {
        public Cart()
        {
            this.CartItems = new HashSet<CartItem>();
        }

        public int ID { get; set; }
        public Guid CookieIdentifier { get; set; }

        public RegisteredUser RegisteredUser { get; set; }
        public ICollection<CartItem> CartItems { get; set; }
    }
}