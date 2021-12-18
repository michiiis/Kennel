using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InlämningsuppgiftKennel.Dog
{
    public class Animal : IAnimal
    {
        public int Id { get; set; }
        public string DogName { get; set; }
        public string OwnerName { get; set; }
        public List<IAnimal> CurrentAnimals { get; set; }
        public decimal Price { get; set; } = 700;
        public bool IsCheckedIn { get; set; }
        public bool GotHaircut { get; set; }
        public bool GotClawcut { get; set; }
        public Animal()
        {
            CurrentAnimals = new List<IAnimal>();
            IsCheckedIn = false;
            GotHaircut = false;
            GotClawcut = false;
        }

        //public decimal GetPrice()
        //{
        //    return CurrentAnimals.Count() * Price;
        //}
    }
}
