using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SSGeek.DAL;
using SSGeek.Models;

namespace SSGeek.Controllers
{
    public class ShoppingCartController : Controller
    {
        private string ShoppingCartSession = "ShoppingCart"; //assigned variable to access active ShoppingCart in ViewCart method 
        // GET: ShoppingCart
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult ViewCart()
        {
            ShoppingCart model = new ShoppingCart();
            if(Session[ShoppingCartSession] != null) //checks to confirm session is active, if active, assign to "model" and send "model" through View
            {
                model = (ShoppingCart)Session[ShoppingCartSession];
            }

            return View("ViewCart", model);
        }
    }
}