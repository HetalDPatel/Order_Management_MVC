using OrderManagement.Data;
using OrderManagement.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderManagement.Controllers
{
    public class OrdersController : Controller
    {
        Order order = new Order();
        Address address = new Address();

        public bool IsInserted { get; private set; }
        public OrderEntity orderEntity { get; private set; }


        // GET: Orders
        public ActionResult Index()
        {
           

            //Fetching data from database
            var orderList = order.GetOrders().ToList();

            // var ord = order.GetOrder(1).Map();

            return View(orderList);
        }

        // GET: Orders/Details/5
        public ActionResult Details(int id)
        {
            var ord = order.GetOrder(id);
            return View(ord);
        }

        // GET: Orders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Orders/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {


                if (ModelState.IsValid)
                {
                    IsInserted = order.CreateOrder(orderEntity);

                    if (IsInserted)
                    {
                        TempData["SuccessMsg"] = "Order Created Successfully...!";
                    }
                    else
                    {
                        TempData["ErrorMsg"] = "Unable To Create Order...!";
                    }
                }
                //return View();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }



        // GET: Orders/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Orders/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Orders/Delete/5
        public ActionResult Delete(int id)
        {
            var ord = order.GetOrder(id);
            return View(ord);
        }

        // POST: Orders/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                order.DeleteOrder(id);
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        // Address
        // GET: Address/Create
        [HttpGet]
        public ActionResult CreateAddress()
        {
            return View();
        }

        // POST: Address/Create

        [HttpPost]
        public ActionResult CreateAddress(AddressEntity addressEntity)
        {
            bool IsInserted = false;
            try
            {
                if (ModelState.IsValid)
                {
                    //IsInserted = address.CreateAddress(addressEntity);

                    if (IsInserted)
                    {
                        TempData["SuccessMsg"] = "Address Created Successfully...!";
                    }
                    else
                    {
                        TempData["ErrorMsg"] = "Unable To Create Address...!";
                    }
                }

                //return View();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                TempData["ErrorMsg"] = ex.Message;
                return View();
            }

        }

        
        // GET: Order/Create
        [HttpGet]
        public ActionResult CreateOrder()
        {
            return View();
        }

        // POST: Address/Create

        [HttpPost]
        public ActionResult CreateOrder(OrderEntity orderEntity)
        {
            bool IsInserted = false;
            try
            {
                if (ModelState.IsValid)
                {
                    IsInserted = order.CreateOrder(orderEntity);

                    if (IsInserted)
                    {
                        TempData["SuccessMsg"] = "Address Created Successfully...!";
                    }
                    else
                    {
                        TempData["ErrorMsg"] = "Unable To Create Address...!";
                    }
                }

                //return View();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                TempData["ErrorMsg"] = ex.Message;
                return View();
            }

        }

    }
}
