using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OrderManagement.Data.Entity;
using OrderManagement.Models;

namespace OrderManagement.Mapper
{
    public static class OrderMapperExtension
    {
        public static OrderModel Map(this OrderEntity model)
        {
            return new OrderModel()
            {
                OrderNumber = model.OrderNumber,
                Customer_Name = model.Customer_Name,   
                Order_Date=model.Order_Date,
                Item=model.Item,
                Price=model.Price,
                Qty = model.Qty,
                OrderStatus = model.Status,
                Address=new AddressModel { Street=model.AddressItem.Street,
                                           Country=model.AddressItem.Country }
            };
        }
    }
}