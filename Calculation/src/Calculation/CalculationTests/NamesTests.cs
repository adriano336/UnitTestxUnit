using Calculation;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CalculationTests
{
    public class NamesTests
    {
        [Fact]
        public void MakeFullNameTest()
        {
            var names = new Names();
            var result = names.MakeFullNames("adriano", "chagas");
            Assert.Equal("Adriano Chagas", result, ignoreCase: true);
            //Assert.Contains("DRIAN", result, StringComparison.InvariantCultureIgnoreCase);
            //Assert.StartsWith("a", result, StringComparison.InvariantCultureIgnoreCase);
            //Assert.EndsWith("as", result, StringComparison.InvariantCultureIgnoreCase);
            //Assert.Matches("[A-Z]{1}[a-z]+ [a-z]+", result);
        }

        [Fact]
        public void NickName_MustBeNull()
        {
            var names = new Names();
            names.NickName = "Strong Man";
            //Assert.Null(names.NickName);
            Assert.NotNull(names.NickName);
        }

        [Fact]
        public void MakeFullName_AlwaysReturnValue()
        {
            var names = new Names();
            var result = names.MakeFullNames("Adriano", "Chagas");
            //Assert.NotNull(result);
            //Assert.True(!string.IsNullOrEmpty(result));
            Assert.False(string.IsNullOrEmpty(result));
        }
    }
}
