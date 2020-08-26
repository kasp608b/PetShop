using PetShop.Core.DomainService;
using PetShop.Core.Entities;
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
        public List<Pet> GetPets()
        {
            return _petRepository.ReadPets();
        }
    }
}
