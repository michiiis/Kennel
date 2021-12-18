using System.Collections.Generic;

namespace InlämningsuppgiftKennel.Customers
{
    public interface ICustomer
    {
        string FirstName { get; set; }
        int Id { get; set; }
        string LastName { get; set; }
        List<ICustomer> CurrentCustomers { get; set; }
    }
}