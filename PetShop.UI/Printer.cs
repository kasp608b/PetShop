using PetShop.Core.ApplicationService;
using PetShop.Core.ApplicationService.Implementations;
using PetShop.Core.DomainService;
using PetShop.Core.Entities;
using PetShop.Core.Entities.Enums;
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

        internal void StartMenu()
        {


            string[] menuItems =
            {
                "List All Videos",
                "Exit",
            };

            var selection = ShowMenu(menuItems, MenuTypes.Main);
            bool exit = false;

            while (exit == false)
            {
                switch (selection)
                {
                    case 1:

                        Console.Clear();
                        Console.WriteLine("List of pets\n");
                        PrintAllPets();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Bye bye!");
                        exit = true;
                        break;
                }

                if (exit == false)
                {
                    Console.WriteLine("Press any key to go back to menu");
                    Console.ReadLine();
                    selection = ShowMenu(menuItems, MenuTypes.Main);
                }

            }
        }

        internal void PrintAllPets()
        {
            foreach (Pet pet in _petService.GetPets())
            {
                Console.WriteLine(pet.ToString());
            }
        }

        internal int ShowMenu(string[] menuItems, MenuTypes type)
        {
            Console.Clear();

            switch (type)
            {
                case MenuTypes.Main:
                    Console.WriteLine("Select what you want to do:\n");
                    break;
                case MenuTypes.Properties:
                    Console.WriteLine("Choose which property to perform action on:\n");
                    break;
                default:
                    throw new Exception("Wrong enum given");
            }


            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine($"{(i + 1)} : { menuItems[i]}");
            }
            int selection;
            while (!int.TryParse(Console.ReadLine(), out selection)
               //OR
               || selection < 1
               || selection > menuItems.Length)
            {
                Console.WriteLine("You need to select a number between 1-" + menuItems.Length);
            }

            Console.WriteLine("Selection: " + selection);
            return selection;
        }
    }
}
