using Xunit;
using Space_Shuttle.Common.Interfaces;
using Space_Shuttle.Common.Classes;
using Space_Shuttle.Data.Interfaces;
using Space_Shuttle.Data.Classes;
using System.Linq;

namespace Space_Shuttle.Tests
{
    public class CustomerTests
    {
        [Fact]
        public void CanCreateCustomer()
        {
            IPerson customer = new Customer(1, "John", "Doe", "1234");
            Assert.Equal("John Doe(1234)", customer.ToString());
        }

        [Fact]
        public void CanReadCustomers()
        {
            IData data = new CollectionData(); 
            Assert.True(data.GetPersons().Count() > 0); 
        }
    }
}
