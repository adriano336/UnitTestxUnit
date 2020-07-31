using System;
using System.Collections.Generic;
using System.Text;

namespace Calculation
{
    public class Customer
    {
        public virtual int GetOrdersByName(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentException("Hello");

            return 100;

        }
        public int Age => 32;

        public string GetFullName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }
    }
}
