using InlämningsuppgiftKennel.Dog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsuppgiftKennel.Factories
{
    public class AnimalFactory : IAnimalFactory
    {
        public IAnimal Create()
        {
            return new Animal();
        }
    }
}
