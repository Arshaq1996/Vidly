using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using  Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        //public ActionResult Random()
        //{
        //    var movie = new Movie() {Name = "Avengers Infinity War"};
        //    return View(movie);

        //  //  return Content("Hello World!!!");
        //    //return HttpNotFound(); 
        //   // return  new EmptyResult();

        //   // return RedirectToAction("Index", "Home",new {page=1,sortby ="name"});
        //}

        //public ActionResult Edit(int id)
        //{
        //    return Content("id="+id);
        //}

        //public ActionResult Index(int? pageIndex, string sortby)
        //{
        //    if (!pageIndex.HasValue)
        //    {
        //        pageIndex = 1;
        //    }

        //    if (string.IsNullOrWhiteSpace(sortby))
        //    {
        //        sortby = "Name";
        //    }

        //    return Content(string.Format("PageIndex={0}&SortBy={1}",pageIndex,sortby));

        //}
        //[Route("movies/released/{year}/{month :regex (\\d={4}):range (1-12)} ")]
        //public ActionResult Random(int year,int month)
        //{

        //    return Content(year + "/"+month);
        //}



//
//        public ActionResult Random()
//        {
//            var  movie = new Movie() {Name="The Killer!!!!"};
//            var viewResult = new ViewResult();
//           // viewResult.ViewData.Model
//
//            var Customers = new List<Customer>
//            {
//
//                new Customer {Name = "Customer 1"},
//                new Customer {Name = "Customer 2"}
//            };
//
//
//            var viewModel = new RandomMovieViewModel
//            {
//                Movie = movie,
//                customers = Customers
//
//
//            };
//                
//            return View(viewModel);
//        }

        public ActionResult Random()

        {
            var customer = new Customer() {Name = "Customer"};
            var viewResult = new  ViewResult();
            var Customer = new List<Customer>
            {
                new Customer { Name="John Smith"},
                new  Customer {Name =  "Marrry Williams"}
        

            };

            var viewModel =  new RandomMovieViewModel
            {
  //              Movie =  movie,
                customers =Customer 
            };

            return View(viewModel);

        }
    }




} 