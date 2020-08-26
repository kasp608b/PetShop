
using PetShop.Core.HelperClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PetShop.Core.HelperClasses.Implementations
{
    public class Parser : IParser
    {
        public DateTime DateParser(string stringToParse)
        {
            DateTime searchDateParsed;

            if (!DateTime.TryParse(stringToParse, out searchDateParsed))
            {
                throw new InvalidDataException("Input must be an date");
            }
            else
            {
                return searchDateParsed;
            }
        }
        public bool IsDateParsable(string stringToParse, out DateTime parsedDate)
        {
            DateTime searchDateParsed;
            if (!DateTime.TryParse(stringToParse, out searchDateParsed))
            {
                parsedDate = searchDateParsed;
                return false;
            }
            else
            {
                parsedDate = searchDateParsed;
                return true;
            }
        }

        public int IntParser(string stringToParse)
        {
            int searchintParsed;

            if (!int.TryParse(stringToParse, out searchintParsed))
            {
                throw new InvalidDataException("Input must be an int");
            }
            else
            {
                return searchintParsed;
            }
        }

        public bool IsIntParsable(string stringToParse, out int parsedInt)
        {
            int searchintParsed;

            if (!int.TryParse(stringToParse, out searchintParsed))
            {

                parsedInt = searchintParsed;
                return false;
            }
            else
            {
                parsedInt = searchintParsed;
                return true;
            }
        }
    }
}
