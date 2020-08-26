using System;
using Microsoft.Extensions.DependencyInjection;
using PetShop.Core.ApplicationService;
using PetShop.Core.ApplicationService.Implementations;
using PetShop.Core.DomainService;
using PetShop.Infrastructure.Data;

namespace PetShop.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            FakeDB.InitData();
            IPetRepository petRepository = new PetRepository();
            IPetService petService = new PetService(petRepository);
            Printer printer = new Printer(petService);
            printer.StartMenu();
        }
    }
}
