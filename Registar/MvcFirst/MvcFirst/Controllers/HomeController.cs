using MvcFirst.Models;
using Registar.BusinessLayer;
using Registar.BusinessLayer.Contracts;
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
            command.Colour = "Red";
            
            //invoking the SearchCommand
            BikeSearchResult _result = CommandInvoker.InvokeCommand<BikeSearchCommand,BikeSearchResult>(command);
            
            return View(_result.Result);
        }

        public ActionResult AddBike() {

            AddBikeCommand command = new AddBikeCommand();
            AddBikeResult _result = CommandInvoker.InvokeCommand<AddBikeCommand, AddBikeResult>(command);
            return View(_result.Bike);
        }
    }
}