using System;
using System.Collections.Generic;
using System.Text;

namespace InlämningsuppgiftKennel.Menu
{
    public interface IAnimalManager
    {
        public void RegisterAnimal();
        public void CheckInAnimal();
        void CheckOutAnimal();
        void ViewRegisteredAnimals();
        void ListCheckedInAnimals();
        public void AddHaircut();
        public void AddClawcut();
    }
}
