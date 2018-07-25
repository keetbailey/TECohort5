using FormsWithHttpPost.DAL;
using FormsWithHttpPost.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormsWithHttpPost.Controllers
{
    public class HomeController : Controller
    {
        private IReviewDAL reviewDAL;

        public HomeController()
        {
            reviewDAL = new ReviewSqlDAL(ConfigurationManager.ConnectionStrings["SquirrelConnectionString"].ConnectionString);
        }
        public ActionResult Index()
        {
            IList<Review> getReviews = reviewDAL.GetAllReviews();
            return View("Index", getReviews);
        }
       
    }
}


