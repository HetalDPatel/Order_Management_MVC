using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OrderManagement.Data.Entity;
using OrderManagement.Models;

namespace OrderManagement.Mapper
{
    public class AddressMapperExtension
    {
        public AddressModel Map(AddressEntity model)
        {
            return new AddressModel()
            {
                Street = model.Street,
                Country = model.Country
            };
        }
    }
}