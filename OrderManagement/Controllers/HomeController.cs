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
            var list = order.GetOrders().ToList();
            
            var ord = order.GetOrder(1).Map();


            // int i = 0;

            // i.GetDescription();

            // ord.OrderStatus.GetDescription();



            //SqlConnection sqlConnection = new SqlConnection(order.ConnectionString);


            //sqlConnection.Open();
            //SqlTransaction transaction = sqlConnection.BeginTransaction();


            //Order payment1 = new Order(transaction);

            //try
            //{
            //    //send invoice
            //    //create order
            //    //payment 
            //    order.GetOrders(transaction);




            //    transaction.Commit();
            //}
            //catch (Exception ex)
            //{
            //    transaction.Rollback();
            //}
            //finally
            //{
            //    sqlConnection.Close();
            //}





            return View(list);
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