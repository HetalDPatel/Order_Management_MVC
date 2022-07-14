using OrderManagement.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace OrderManagement.Data
{
    public class Address : DataObject
    {

        public Address() : base(null)
        {
            var holder = ConnectionString;
        }

        public Address(SqlTransaction trans) : base(trans)
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

        public bool CreateAddress(AddressEntity objAddEntity)
        {
            int id = 0;
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand("SP_AddNewAddress", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@house_no", objAddEntity.HouseNo);
                cmd.Parameters.AddWithValue("@street", objAddEntity.Street);
                cmd.Parameters.AddWithValue("@city", objAddEntity.City);
                cmd.Parameters.AddWithValue("@cuntry", objAddEntity.Country);
                cmd.Parameters.AddWithValue("@postal_code", objAddEntity.PostalCode);

                sqlConnection.Open();
                id = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

            if (id > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
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