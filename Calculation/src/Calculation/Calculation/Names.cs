using System;
using System.Collections.Generic;
using System.Text;

namespace Calculation
{
    public class Names
    {
        public string NickName { get; set; }
        public string MakeFullNames(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }
    }
}
