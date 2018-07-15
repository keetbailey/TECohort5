using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSGeek.Models
{
    public class ShoppingCart
    {
        public List<ShoppingCartItem> Items { get; set; } = new List<ShoppingCartItem>();

        //will want property that can add up total of all subtotal values 
        //will want method that can alter cart (add to likely) 

        public class ShoppingCartItem
        {
            public Product Product { get; set; }
            public int Quantity { get; set; }

            
            public double Subtotal //product price*quantity
            {
                get
                {
                    if (Product == null)
                    {
                        return 0.00;
                    }
                    else
                    {
                        return Product.Price * Quantity;
                    }
                }
            }
        }
    }
}