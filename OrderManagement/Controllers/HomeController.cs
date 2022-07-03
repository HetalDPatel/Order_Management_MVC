using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderManagement.Common;
using OrderManagement.Data;
using OrderManagement.Data.Entity;
using OrderManagement.Mapper;
using OrderManagement.Models;

namespace OrderManagement.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            Order order = new Order();

            //Fetching data from database
            var orderList = order.GetOrders().ToList();
            
           // var ord = order.GetOrder(1).Map();

            return View(orderList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}