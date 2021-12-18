using InlämningsuppgiftKennel.Customers;
using InlämningsuppgiftKennel.Dog;
using System.Collections.Generic;

namespace InlämningsuppgiftKennel.Data
{
    public interface IDataBaseUsingLists
    {
        List<IAnimal> Animals { get; set; }
        List<ICustomer> Customers { get; set; }
    }
}