using System;
using System.Collections.Generic;
using System.Text;

namespace InlämningsuppgiftKennel.Customers
{
    public class Customer : ICustomer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<ICustomer> CurrentCustomers { get; set; }

        public Customer()
        {
            CurrentCustomers = new List<ICustomer>();
        }
    }
}
