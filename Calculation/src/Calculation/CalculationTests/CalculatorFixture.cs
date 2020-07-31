using Calculation;
using System;

namespace CalculationTests
{
    public class CalculatorFixture : IDisposable
    {
        public Calculator Calc => new Calculator();

        public void Dispose()
        {
            //Clean;
        }
    }
}
