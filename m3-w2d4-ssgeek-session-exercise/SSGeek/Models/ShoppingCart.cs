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

        public double Total //product price*quantity
        {
            get
            {
                return Items.Sum(item => item.Subtotal);
            }
        }

        public void AddUpdateCart(Product product, int quantity)
        {
            var currentItem = Items.Where(item => item.Product.ProductId == product.ProductId).FirstOrDefault();

            if(currentItem != null)
            {
                currentItem.Quantity = quantity;
            }
            else
            {
                Items.Add(new ShoppingCartItem()
                {
                    Product = product,
                    Quantity = quantity
                });
            }
        }
    }

    public class ShoppingCartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public double Subtotal
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
