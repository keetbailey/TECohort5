using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SSGeek.DAL;
using SSGeek.Models;
using System.Configuration;

namespace SSGeek.Controllers
{
    public class ShoppingCartController : Controller
    {
        private string ShoppingCartSession = "ShoppingCart"; //assigned variable to access active ShoppingCart in ViewCart method 
        private readonly IProductDAL productDAL;

        public ShoppingCartController()
        {
            productDAL = new ProductSqlDAL(ConfigurationManager.ConnectionStrings["SSGeek"].ConnectionString);
        }

        // GET: ShoppingCart
        public ActionResult Index()
        {
            var getProducts = productDAL.GetProducts();

            return View("Index", getProducts);
        }

        public ActionResult Detail(int? id)
        {
            var product = productDAL.GetProduct(id);

            if (product == null)
            {
                return new HttpNotFoundResult();

            }
            return View("Detail", product);
        }

        [HttpPost]
        public ActionResult AddToCart(int productID, int quantity)
        {
            var selection = productDAL.GetProduct(productID);

            if (selection == null)
            {
                return new HttpNotFoundResult();
            }

            if (Session[ShoppingCartSession] == null)
            {
                Session[ShoppingCartSession] = new ShoppingCart();
            }

            var shoppingCart = (ShoppingCart)Session[ShoppingCartSession];
            shoppingCart.AddUpdateCart(selection, quantity);

            Session[ShoppingCartSession] = shoppingCart;

            return RedirectToAction("ViewCart");
        }

        public ActionResult ViewCart()
        {
            ShoppingCart model = new ShoppingCart();
            if (Session[ShoppingCartSession] != null) //checks to confirm session is active, if active, assign to "model" and send "model" through View
            {
                model = (ShoppingCart)Session[ShoppingCartSession];
            }

            return View("ViewCart", model);
        }
    }
}