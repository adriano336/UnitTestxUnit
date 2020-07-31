using Calculation;
using System;
using Xunit;

namespace CalculationTests
{
    [Collection("Costumer")]
    public class CustomerTests : IClassFixture<CustomerFixture>
    {
        private readonly CustomerFixture _customerFixture;

        public CustomerTests(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }

        [Fact]
        public void CheckLegitForDiscount()
        {
            var customer = _customerFixture.Cust;
            Assert.InRange(customer.Age, 25, 40);
        }

        [Fact]
        public void GetOrdersByNameNotNull()
        {
            var cust = _customerFixture.Cust;
            var exceptionDetail = Assert.Throws<ArgumentException>(() => cust.GetOrdersByName(""));
            Assert.Equal("Hello", exceptionDetail.Message, ignoreCase: true);
        }

        [Fact]
        public void LoyalCustomerForOrdersG100()
        {
            var customer = CustomerFactory.CreateCustomerInstance(102);
            var loyalCust = Assert.IsType<LoyalCustomer>(customer);
            Assert.Equal(10, loyalCust.Discount);
        }
    }
}
