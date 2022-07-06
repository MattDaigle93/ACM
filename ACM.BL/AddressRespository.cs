using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRespository
    {
        ///<summary>
        /// Retrieve one address.
        /// </summary>
        public Address Retrieve(int addressId)
        {
            // Create the instance of the Address class
            // Pass in the requested Id
            Address address = new Address(addressId);

            // Code that retrieves the defined address

            // Temporary hard coded values to return
            // a populated address
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "1605 12th Ave";
                address.City = "Ardmore";
                address.State = "Oklahoma";
                address.Country = "United States";
                address.PostalCode = "73401";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            // Code that retrieves the defined addresses
            // for the customer.

            // Temporary hard-coded values to return
            // a set of addresses for a customer.
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "1605 12th Ave",
                City = "Ardmore",
                State = "Oklahoma",
                Country = "United States",
                PostalCode = "73401",
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "6632 Santa Crist",
                City = "The Colony",
                State = "Texas",
                Country = "United States",
                PostalCode = "75056",
            };
            addressList.Add(address);

            return addressList;
        }

        /// <summary>
        /// Saves the current address.
        /// </summary>
        /// <returns></returns>
        public bool Save(Address address)
        {
            // Code that saves the passed in address

            return true;
        }
    }
}
