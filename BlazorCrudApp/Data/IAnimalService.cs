using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrudApp.Data
{
    interface IAnimalService
    {
        List<Animal> GetAnimals();

        Animal GetAnimal(Guid id);

        void UpdateAnimal(Animal animal);

        void AddAnimal(Animal animal);

        void DeleteAnimal(Guid id);
    }
}
