using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Core.HelperClasses.Interfaces
{
    public interface IParser
    {
        public int IntParser(string stringToParse);

        public bool IsIntParsable(string stringToParse, out int parsedInt);

        public DateTime DateParser(string stringToParse);

        public bool IsDateParsable(string stringToParse, out DateTime parsedDate);
    }
}
