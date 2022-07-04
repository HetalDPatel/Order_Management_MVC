using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderManagement.Data.Entity
{
    public class OrderEntity
    {
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public string Customer_Name { get; set; }

        public string Order_Date { get; set; }
        public string Item { get; set; }
        public Decimal Price { get; set; }
        public int Qty { get; set; }

        public string Status { get; set; }
        public int AddressId { get; set; }
        public virtual AddressEntity AddressItem { get; set; }

        public OrderEntity(int id,string orderNumber, string name,string date,string item, decimal price, int qty,string status, AddressEntity adressItem) {
            OrderId = id;
            OrderNumber = orderNumber;
            Customer_Name = name;
            Order_Date = date;
            Item = item;
            Price = price;
            Qty = qty;
            Status = status;
            AddressItem = adressItem;
        }

        public OrderEntity()
        {

        }
    }
}