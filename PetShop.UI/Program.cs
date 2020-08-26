using System;
using Microsoft.Extensions.DependencyInjection;
using PetShop.Core.ApplicationService;
using PetShop.Core.ApplicationService.Implementations;
using PetShop.Core.DomainService;
using PetShop.Infrastructure.Data;
using PetShop.Core.HelperClasses.Implementations;
using PetShop.Core.HelperClasses.Interfaces;

namespace PetShop.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            FakeDB.InitData();
            IPetRepository petRepository = new PetRepository();
            IPetService petService = new PetService(petRepository);
            IParser parser = new Parser();
            Printer printer = new Printer(petService, parser);
            printer.StartMenu();
        }
    }
}
