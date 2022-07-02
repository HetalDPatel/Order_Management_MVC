using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.EnterpriseServices;
using System.Linq;
using System.Web;

namespace OrderManagement.Data
{
    public class DataObject
    {
        private string _ConnectionString;
        private SqlTransaction _trans;

        public DataObject(SqlTransaction trans)
        {
            _ConnectionString = ConfigurationManager.ConnectionStrings["MVC"].ConnectionString;            
            _trans = trans;
        }

        public string ConnectionString => _ConnectionString;

        public SqlTransaction Trans => _trans;
    }
}