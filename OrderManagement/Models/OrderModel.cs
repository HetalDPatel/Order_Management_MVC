using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderManagement.Models
{
    public class OrderModel
    {
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public string Customer_Name { get; set; }
        public string Order_Date { get; set; }
        public string Item { get; set; }
        public Decimal Price { get; set; }
        public int Qty { get; set; }
        public string OrderStatus { get; set; }
        public int AddressId { get; set; }
        public AddressModel Address { get; set; }
        public OrderModel(string orderNumber, string name, string date, string item, decimal price, int qty, string status, AddressModel address)
        {
            OrderNumber = orderNumber;
            Customer_Name = name;
            Order_Date = date;
            Item = item;
            Price = price;
            Qty = qty;
            OrderStatus = status;
            Address = address;
        }

     
        public OrderModel()
        {
        }
    }
}