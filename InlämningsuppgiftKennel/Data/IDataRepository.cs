using InlämningsuppgiftKennel.Customers;
using InlämningsuppgiftKennel.Dog;
using System.Collections.Generic;

namespace InlämningsuppgiftKennel.Data
{
    public interface IDataRepository
    {
        IDataBaseUsingLists Db { get; set; }

        List<IAnimal> GetAllAnimals();
        List<ICustomer> GetAllCustomers();
        public void AddAnimalToDb(IAnimal animal);
        public void AddCustomerToDb(ICustomer customer);
    }
}