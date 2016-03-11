using MvcFirst.Models;
using Registar.BusinessLayer;
using Registar.BusinessLayer.Contracts;
using Registar.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcFirst.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //creating new command and add some filters
            BikeSearchCommand command = new BikeSearchCommand();
            //command.Colour = "Red";

            //invoking the SearchCommand
            BikeSearchResult _result = CommandInvoker.InvokeCommand<BikeSearchCommand, BikeSearchResult>(command);

            return View(_result.Result);
        }


        /// <summary>
        /// method that returns json result to the ajax call
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult GetBikes()
        {
            BikeSearchCommand command = new BikeSearchCommand();
            //invoking the SearchCommand
            BikeSearchResult _result = CommandInvoker.InvokeCommand<BikeSearchCommand, BikeSearchResult>(command);


            return new JsonResult() { Data = _result.Result, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        /// <summary>
        /// method where we show the json result from the ajax call
        /// </summary>
        /// <returns></returns>
        public ActionResult GetBikesJSON()
        {

            return View();
        }

        public ActionResult AddBike()
        {

            AddBikeCommand command = new AddBikeCommand();
            AddBikeResult _result = CommandInvoker.InvokeCommand<AddBikeCommand, AddBikeResult>(command);
            return View(_result.Bike);
        }

        public ActionResult BikesFromCity(string cityName)
        {
            //creating new command and add some filters
            BikeSearchCommand command = new BikeSearchCommand();
            command.City = cityName;
            
            //invoking the SearchCommand
            BikeSearchResult _result = CommandInvoker.InvokeCommand<BikeSearchCommand, BikeSearchResult>(command);
            return View(_result.Result);
        }
    }
}