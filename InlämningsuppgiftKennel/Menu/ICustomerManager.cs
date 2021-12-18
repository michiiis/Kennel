using System;
using System.Collections.Generic;
using System.Text;

namespace InlämningsuppgiftKennel.Menu
{
    public interface ICustomerManager
    {
        public void RegisterCustomer();
        void ViewRegisteredCustomers();
    }
}
