using System.Collections.Generic;

namespace OrderManagement.Data.Entity
{
    public class AddressEntity
    {
        public int AddressId { get; set; }
        public string HouseNo { get; set; }
        public string Street { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }

        public virtual IEnumerable<OrderEntity> OrderList { get; set; }
    }
}