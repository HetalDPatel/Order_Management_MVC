using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using OrderManagement.Data.Entity;

namespace OrderManagement.Data
{
    public class Address : DataObject
    {

        public Address(): base(null)
        {
            var holder = ConnectionString;
        }

        public Address(SqlTransaction trans): base(trans)
        {
           
        }

        public List<AddressEntity> GetAddresses(SqlTransaction trans = null)
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);


            sqlConnection.Open();

            var transaction = trans == null ? sqlConnection.BeginTransaction() : Trans ?? trans;


            try
            {
                //send invoice
                //create order
                //payment 




                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
            }
            finally
            {
                sqlConnection.Close();
            }

            return new List<AddressEntity>();
        }

        public AddressEntity GetAddress(int id)
        {
            return new AddressEntity();
        }

        public AddressEntity CreateAddress(AddressEntity model)
        {
            return new AddressEntity();
        }

        public AddressEntity UpdateAddress(AddressEntity model)
        {
            return new AddressEntity();
        }

        public void DeleteAddress(int id)
        {

        }
    }

}