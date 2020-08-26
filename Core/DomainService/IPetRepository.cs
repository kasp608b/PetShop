﻿using PetShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Core.DomainService
{
    public interface IPetRepository
    {
        public List<Pet> ReadPets();

        public Pet AddPet(Pet petToAdd);
    }

}
