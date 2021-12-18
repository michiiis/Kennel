using InlämningsuppgiftKennel.Customers;
using InlämningsuppgiftKennel.Dog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsuppgiftKennel.Data
{
    public class DataRepository : IDataRepository
    {
        public IDataBaseUsingLists Db { get; set; }
        public DataRepository(IDataBaseUsingLists db)
        {
            Db = db; 
        }

        public List<ICustomer> GetAllCustomers()
        {
            return Db.Customers.ToList();
        }

        public List<IAnimal> GetAllAnimals()
        {
            return Db.Animals.ToList();
        }

        public void AddAnimalToDb(IAnimal animal)
        {
            Db.Animals.Add(animal);
        }
        public void AddCustomerToDb(ICustomer customer)
        {
            Db.Customers.Add(customer);
        }
    }
}
