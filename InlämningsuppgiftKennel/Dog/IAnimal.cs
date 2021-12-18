using System.Collections.Generic;


namespace InlämningsuppgiftKennel.Dog
{
    public interface IAnimal
    {
        List<IAnimal> CurrentAnimals { get; set; }
        string DogName { get; set; }
        int Id { get; set; }
        string OwnerName { get; set; }
        decimal Price { get; set; }
        public bool IsCheckedIn { get; set; }
        public bool GotHaircut { get; set; }
        public bool GotClawcut { get; set; }

    }
}