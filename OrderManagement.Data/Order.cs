using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using OrderManagement.Data.Entity;

namespace OrderManagement.Data
{
    public class Order : DataObject
    {
        public List<OrderEntity> orderList = new List<OrderEntity>();
        
        AddressEntity addEntity = new AddressEntity();

        public Order() : base(null)
        {
            var holder = ConnectionString;

        }

        public Order(SqlTransaction trans) : base(trans)
        {

        }

        public List<OrderEntity> GetOrders()
        {

            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            string query = $"select o.order_id,o.order_no as 'Order No',o.order_date as 'Order Date',o.item as 'Item Description',o.qty as Quantity ," +
                $"o.price_per_item as Cost ,o.customer_name as 'Customer Name'," +
                $"CONCAT('#', a.house_no, ', ', a.street, ', ', a.city, '-', a.postal_code) as Address,a.country as Country from orders o " +
                $"join address a on o.address_id = a.address_id; ";
            
            // var orderList;
            //var transaction = trans == null ? sqlConnection.BeginTransaction() : Trans ?? trans;        
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                SqlDataReader reader = cmd.ExecuteReader();

                // Data is accessible through the DataReader object here.
                while (reader.Read())
                {
                    OrderEntity ordEntity = new OrderEntity();
                    ordEntity.OrderId = (int)reader[0];
                    ordEntity.OrderNumber = reader[1].ToString();
                    ordEntity.Order_Date = reader[2].ToString();
                    ordEntity.Item = reader[3].ToString();
                    ordEntity.Qty = (int)reader[4];
                    ordEntity.Price = (decimal)reader[5];
                    ordEntity.Customer_Name = reader[6].ToString();
                    addEntity.Street = reader[7].ToString();
                    addEntity.Country = reader[8].ToString();
                    //addList.Add(addEntity);
                    ordEntity.AddressItem = addEntity;
                    //Adding data into list
                    orderList.Add(ordEntity);
                }
                reader.Close();
                // transaction.Commit();
            }
            catch (Exception ex)
            {
                //transaction.Rollback();
            }
            finally
            {
                sqlConnection.Close();
            }

            return orderList;
        }
        public OrderEntity GetOrder(int id)
        {
            //OrderEntity order = new OrderEntity(ordEntity.OrderNumber, ordEntity.Customer_Name, ordEntity.Order_Date, ordEntity.Item, ordEntity.Price, ordEntity.Qty, ordEntity.Status, ordEntity.AddressItem);

            //order.AddressItem = new Address().GetAddress(order.AddressId);
            GetOrders();
            var order = orderList.Find(o => o.OrderId == id);
            return order; 
        }

        public OrderEntity CreateOrder(OrderEntity model)
        {
            return new OrderEntity();
        }

        public OrderEntity UpdateOrder(OrderEntity model)
        {
            return new OrderEntity();
        }

        public void DeleteOrder(int id)
        {

        }
    }




}