using System;
using System.Collections.Generic;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace CalculationTests
{
    public class CalculatorTest : IClassFixture<CalculatorFixture>, IDisposable
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly CalculatorFixture _calculatorFixture;
        private readonly MemoryStream _memoryStream;

        public CalculatorTest(ITestOutputHelper testOutputHelper,
            CalculatorFixture calculatorFixture)
        {
            _testOutputHelper = testOutputHelper;
            _calculatorFixture = calculatorFixture;
            _testOutputHelper.WriteLine("Constructor");

            _memoryStream = new MemoryStream();
        }

        [Fact]
        public void Add_GivenTwoIntValues_ReturnsInt()
        {
            var calc = _calculatorFixture.Calc;
            var result = calc.Add(1, 2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void AddDouble_GivenTwoIntValues_ReturnsDouble()
        {
            var calc = _calculatorFixture.Calc;
            var result = calc.AddDouble(1.23, 3.55);
            Assert.Equal(4.799999, result, 1);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotIncludeZero()
        {
            _testOutputHelper.WriteLine("FiboDoesNotIncludeZero");
            var calc = _calculatorFixture.Calc;
            //Assert.All(calc.FiboNumbers, n => Assert.NotEqual(0, n));
            Assert.DoesNotContain(0, calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboIncludes13()
        {
            _testOutputHelper.WriteLine("FiboIncludes13");
            var calc = _calculatorFixture.Calc;
            Assert.Contains(13, calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboNotInclue4()
        {
            _testOutputHelper.WriteLine("FiboNotInclue4");
            var calc = _calculatorFixture.Calc;
            Assert.DoesNotContain(4, calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void CheckFiboNumbers()
        {
            _testOutputHelper.WriteLine($"CheckFiboNumbers. Test starting at {DateTime.Now}");
            var expectedCollection = new List<int>() { 1, 1, 2, 3, 5, 8, 13 };

            _testOutputHelper.WriteLine("Create instance of calculator");
            var calc = _calculatorFixture.Calc;

            _testOutputHelper.WriteLine("Assert");
            Assert.Equal(expectedCollection, calc.FiboNumbers);

            _testOutputHelper.WriteLine("End");
        }

        [Fact]
        public void IsOdd_GivenOddValue_ReturnsTrue()
        {
            var calc = _calculatorFixture.Calc;
            var result = calc.IsOdd(1);
            Assert.True(result);
        }

        [Fact]
        public void IsOdd_GivenOddValue_ReturnsFalse()
        {
            var calc = _calculatorFixture.Calc;
            var result = calc.IsOdd(2);
            Assert.False(result);
        }

        [Trait("Parameter", "Inline")]
        [Theory]
        [InlineData(1, true)]
        [InlineData(200, false)]
        public void IsOdd_TestOddAndEven(int value, bool expected)
        {
            var calc = _calculatorFixture.Calc;
            var result = calc.IsOdd(value);
            Assert.Equal(expected, result);
        }
                
        [Trait("Parameter", "MemberData")]
        [Theory]
        //[MemberData(nameof(TestDataShare.IsOddOrEvent), MemberType = typeof(TestDataShare))]
        [MemberData(nameof(TestDataShare.IsOddOrEventExternalData), MemberType = typeof(TestDataShare))] 
        public void IsOdd_TestOddAndEven2(int value, bool expected)
        {
            var calc = _calculatorFixture.Calc;
            var result = calc.IsOdd(value);
            Assert.True(expected);
        }

        [Trait("Parameter", "CustomAttribute")]
        [Theory]        
        [IsOddOrEvenData]
        public void IsOdd_TestOddAndEven3(int value, bool expected)
        {
            var calc = _calculatorFixture.Calc;
            var result = calc.IsOdd(value);
            Assert.True(expected);
        }


        public void Dispose()
        {
            _memoryStream.Close();
        }
    }
}
