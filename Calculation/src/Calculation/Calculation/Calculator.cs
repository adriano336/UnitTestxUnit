using System;
using System.Collections.Generic;
using System.Text;

namespace Calculation
{
    public class Calculator
    {
        public List<int> FiboNumbers => new List<int> { 1, 1, 2, 3, 5, 8, 13 };

        public int Add(int a, int b) => a + b;

        public double AddDouble(double a, double b) => a + b;

        public bool IsOdd(int value) => value % 2 == 1;
    }
}
