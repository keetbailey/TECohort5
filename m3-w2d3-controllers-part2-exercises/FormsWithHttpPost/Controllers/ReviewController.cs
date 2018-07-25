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
    public class ReviewController : Controller
    {
        private readonly IReviewDAL reviewDal;

        public ReviewController(IReviewDAL reviewDal) //dependency injection - ninject 
        {
            this.reviewDal = reviewDal;
        }

        //public ReviewController()  //without dependency injection 
        //{
        //    reviewDal = new ReviewSqlDAL(ConfigurationManager.ConnectionStrings["SquirrelConnectionString"].ConnectionString);

        //}


        // GET: Review
        public ActionResult Index()
        {

            return View("Index");
        }

        [HttpPost]
        public ActionResult Index(Review newReview)
        {
            reviewDal.SaveReview(newReview);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Confirmation()
        {
            return View("Confirmation");
        }
    }
}