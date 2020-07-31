using Xunit;

namespace CalculationTests
{
    [CollectionDefinition("Customer")]
    //Mesmo atributo usando em Collection nas classes de teste
    //Para diferentes classes compartilharem o mesmo fixture
    public class CustomerFixtureCollection : ICollectionFixture<CustomerFixture>
    {

    }
}
