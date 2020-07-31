using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xunit;

namespace CalculationTests
{
    public static class TestDataShare
    {        
        public static IEnumerable<object[]> IsOddOrEvent
        {
            get
            {
                yield return new object[] { 1, true };
                yield return new object[] { 200, false };
                     
            }
        }

        public static IEnumerable<object[]> IsOddOrEventExternalData
        {
            get
            {
                var allLines = File.ReadAllLines("IsOddEventTestData.txt");

                return allLines.Select(x =>
                {
                    var lineSplit = x.Split(",");
                    return new object[] { int.Parse(lineSplit[0]), Boolean.Parse(lineSplit[1]) };
                });
            }

        }
    }
}
