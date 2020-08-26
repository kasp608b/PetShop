using PetShop.Core.ApplicationService;
using PetShop.Core.ApplicationService.Implementations;
using PetShop.Core.DomainService;
using PetShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.UI
{
    public class Printer
    {
        private IPetService _petService;
        public Printer(IPetService petService)
        {
            _petService = petService;
        }

        internal void PrintAllPets()
        {
            foreach (Pet pet in _petService.GetPets())
            {
                Console.WriteLine(pet.ToString());
            }
        }
    }
}
