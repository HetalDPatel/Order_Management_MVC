using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderManagement.Data.Entity
{
    public class AddressEntity
    {
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string Country { get; set; }

        public virtual IEnumerable<OrderEntity> OrderList { get; set; }
    }
}