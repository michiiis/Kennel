using InlämningsuppgiftKennel.Customers;
using InlämningsuppgiftKennel.Dog;
using System;
using System.Collections.Generic;
using System.Text;

namespace InlämningsuppgiftKennel.Data
{
    public class DataBaseUsingLists : IDataBaseUsingLists
    {
        public List<IAnimal> Animals { get; set; }
        public List<ICustomer> Customers { get; set; }

        public DataBaseUsingLists()
        {
            Customers = new();
            Animals = new();
        }
    }
}
