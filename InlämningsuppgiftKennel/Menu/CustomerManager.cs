using InlämningsuppgiftKennel.Customers;
using InlämningsuppgiftKennel.Data;
using InlämningsuppgiftKennel.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace InlämningsuppgiftKennel.Menu
{
    public class CustomerManager : ICustomerManager
    {
        ICustomerFactory CustomerFactory;
        IDataRepository Db; 

        public CustomerManager(ICustomerFactory customerFactory, IDataRepository db)
        {
            Db = db;
            CustomerFactory = customerFactory;
        }

        public void RegisterCustomer()
        {
            ICustomer customer = CustomerFactory.Create();

            //TODO: Add Validation
            Console.WriteLine(value: "Please enter first name: ");
            customer.FirstName = Console.ReadLine();

            //TODO: Add Validation
            Console.WriteLine(value: "Please enter your last name: ");
            customer.LastName = Console.ReadLine();

            Db.AddCustomerToDb(customer);
        }

        public void ViewRegisteredCustomers()
        {
            var customers = Db.GetAllCustomers();
            foreach (var customer in customers)
            {
                Console.WriteLine("Customers Name is: ");
                Console.WriteLine(customer.FirstName);

            }
            Console.ReadLine();
        }
    }
}
