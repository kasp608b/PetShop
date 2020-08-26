using PetShop.Core.DomainService;
using PetShop.Core.Entities;
using PetShop.Core.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShop.Core.ApplicationService.Implementations
{
    public class PetService : IPetService
    {
        private IPetRepository _petRepository;
        
        public PetService(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        public Pet AddPet(string name, PetType type, DateTime birthdate, DateTime soldDate, string color, string previousOwner, double price)
        {
            Pet pet = new Pet
            {
                Name = name,
                Type = type,
                BirthDate = birthdate,
                SoldDate = soldDate,
                Color = color,
                PreviousOwner = previousOwner,
                Price = price
            };

            return _petRepository.AddPet(pet);
        }

        public List<Pet> GetPets()
        {
            return _petRepository.ReadPets();
        }
    }
}
