using Xunit;
using Space_Shuttle.Common.Interfaces;
using Space_Shuttle.Common.Classes;
using Space_Shuttle.Common.Enums;
using Space_Shuttle.Data.Interfaces;
using Space_Shuttle.Data.Classes;
using System.Linq;

namespace Space_Shuttle.Tests
{
    public class CommonTests
    {
        [Fact]
        public void CanCreateOdyssey()
        {
            ISpaceShuttle odyssey = new Odyssey(12345, "Lockheed_Martin", "OZ145", 100, 1000, 1000, SpaceShuttleStatus.Available, SpaceShuttles.Odyssey);
            Assert.Equal("OZ145", odyssey.RegistrationNo);
        }

        [Fact]
        public void CanCreateEndeavour()
        {
            ISpaceShuttle endeavour = new Endeavour(12346, "Rockwell_International", "OZ146", 100, 1000, 1000, SpaceShuttleStatus.Available, SpaceShuttles.Endeavour);
            Assert.Equal("OZ146", endeavour.RegistrationNo);


        }

        [Fact]
        public void CanCreateBooking()
        {
            ISpaceShuttle endeavour = new Endeavour(12346, "Rockwell_International", "OZ146", 100, 1000, 1000, SpaceShuttleStatus.Available, SpaceShuttles.Endeavour);
            IPerson customer = new Customer (1, "Carl", "Sagan", "19341109-1980"); 
            IBooking booking = new Booking(2, endeavour, customer);

            Assert.Equal(2, booking.ID);
        }

        [Fact]
        public void CanGetBookings()
        {
            IData data = new CollectionData();
            Assert.True(data.GetBookings().Count() > 0);
        }

        [Fact]
        public void CanGetAllSpaceShuttlesStatus()
        {
            IData data = new CollectionData();
            Assert.True(data.GetSpaceShuttles().Count() > 0);
        }

        [Fact]
        public void CanGetSpaceShuttlesByStatus()
        {
            IData data = new CollectionData();
            Assert.True(data.GetSpaceShuttles(SpaceShuttleStatus.Booked).Count() > 0);
        }
    }
} 
 