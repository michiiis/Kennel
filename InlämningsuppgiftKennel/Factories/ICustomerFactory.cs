using InlämningsuppgiftKennel.Customers;

namespace InlämningsuppgiftKennel.Factories
{
    public interface ICustomerFactory
    {
        ICustomer Create();
    }
}