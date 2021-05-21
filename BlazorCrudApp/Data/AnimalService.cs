using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrudApp.Data
{
    public class AnimalService : IAnimalService
    {
        private List<Animal> animals = new List<Animal>
        {
            new Animal
            {
                ID = Guid.NewGuid(),
                Name = "Animal1"
            },
            new Animal
            {
                ID = Guid.NewGuid(),
                Name = "Animal2"
            }
    };

        public void AddAnimal(Animal animal)
        {
            var id = Guid.NewGuid();
            animal.ID = id;
            animals.Add(animal);
        }

        public void DeleteAnimal(Guid id)
        {
            var animal = GetAnimal(id);
            animals.Remove(animal);
        }

        public Animal GetAnimal(Guid id)
        {
            return animals.SingleOrDefault(x => x.ID == id);
        }

        public List<Animal> GetAnimals()
        {
            return animals;
        }

        public void UpdateAnimal(Animal animal)
        {
            var getOldAnimal = GetAnimal(animal.ID);
            getOldAnimal.Name = animal.Name;
        }
    }
}
