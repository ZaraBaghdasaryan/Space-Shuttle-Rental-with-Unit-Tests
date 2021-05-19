using Space_Shuttle.Business.Classes;
using Xunit;
using System.Linq;


namespace Space_Shuttle.Tests
{
   public class BookingProcessorTests
    {
        [Fact]
        public void CanReadCustomers()
        {
            var bp = new BookingProcessor();
            Assert.True(bp.GetCustomers().Count() > 0);
        }

        [Fact]
        public void CanReadBookings()
        {
            var bp = new BookingProcessor();
            Assert.True(bp.GetBookings().Count() > 0);
        }

        [Fact]
        public void CanReadSpaceShuttles()
        {
            var bp = new BookingProcessor();
            Assert.True(bp.GetSpaceShuttles().Count() > 0);
        }

    }
}
 