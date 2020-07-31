using Calculation;
using Xunit;

namespace CalculationTests
{
    [Collection("Customer")]
    public class CustomerDetailsTests : IClassFixture<CustomerFixture>
    {
        private readonly CustomerFixture _customerFixture;
        public CustomerDetailsTests(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }

        [Fact]
        public void GetFullName_GivenFirstAndLastName_ReturnsFullName()
        {
            Customer customer = _customerFixture.Cust;
            Assert.Equal("Adriano Chagas", customer.GetFullName("Adriano", "Chagas"));

        }
    }
}
