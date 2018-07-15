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
        private IReviewDAL reviewDal;


        //public ReviewController(IReviewDAL reviewDal)
        //{
        //    this.reviewDal = reviewDal;
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

            return RedirectToAction("Confirmation", "Review");
        }

        [HttpGet]
        public ActionResult Confirmation()
        {
            return View("Confirmation");
        }
    }
}