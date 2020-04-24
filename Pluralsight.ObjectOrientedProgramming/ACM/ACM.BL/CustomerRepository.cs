using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class CustomerRepository
    {
        /// <summary>
        /// Retrieve one customer.
        /// </summary>
        public Customer Retrieve(int customerId)
        {
            // Create the instance of the Customer class
            // Pass in the requested Id
            Customer customer = new Customer(customerId);

            // Code that retrieves the defined customer

            // Temporary hard-coded values to return
            // a populated customer
            if (customerId == 1)
            {
                customer.EmailAdress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }
            return customer;
        }

        public bool Save(Customer customer)
        {
            // Code that saves the passed in customer

            return true;
        }
    }
}
