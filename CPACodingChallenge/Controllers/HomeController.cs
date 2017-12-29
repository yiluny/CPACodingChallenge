using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CPACodingChallenge.Factories;
using CPACodingChallenge.ViewModels;

namespace CPACodingChallenge.Controllers
{
    public class HomeController : Controller
    {
        private readonly IResultFactory _resultFactory;
        private string reqUrl = "http://cpacodingchallenge.azurewebsites.net/api/results";

        public HomeController(IResultFactory resultFactory)
        {
            this._resultFactory = resultFactory;
        }

        // GET: Home
        public ActionResult Index()
        {

            var output = this._resultFactory.GetPassedResultsByUrl(reqUrl);

            return View(output);
        }
    }
}