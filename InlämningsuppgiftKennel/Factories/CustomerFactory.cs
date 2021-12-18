using InlämningsuppgiftKennel.Customers;
using System;
using System.Collections.Generic;
using System.Text;

namespace InlämningsuppgiftKennel.Factories
{
    public class CustomerFactory : ICustomerFactory
    {
        public ICustomer Create()
        {
            return new Customer();
        }
    }
}
