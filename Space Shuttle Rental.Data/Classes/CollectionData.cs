using System.Collections.Generic;
using Space_Shuttle.Common.Interfaces;
using System.Linq;
using Space_Shuttle.Data.Interfaces;
using Space_Shuttle.Common.Classes;
using Space_Shuttle.Common.Enums;


namespace Space_Shuttle.Data.Classes
{
   public class CollectionData : IData

    {
        readonly List<IPerson> _persons = new List<IPerson>();
        readonly List<IBooking> _bookings = new List<IBooking>();
        readonly List<ISpaceShuttle> _spaceshuttles = new List<ISpaceShuttle>();
        public int NextPersonID => _persons.Count.Equals(0) ? 1 : _persons.Max(p => p.CustomerID) + 1;  //Creating a fake database
        public int NextSpaceShuttleID => _spaceshuttles.Count.Equals(0) ? 1 : _spaceshuttles.Max(p => p.ID) + 1;  
        public int NextBookingID => _bookings.Count.Equals(0) ? 1 : _bookings.Max(p => p.ID) + 1;    
         
        public CollectionData()
        {
            SeedData();     //Creating persons for us
        }

        private void SeedData()
        {
            _persons.Add(new Customer(1, "Carl", "Sagan", "19341109-1980"));
            _persons.Add(new Customer(2, "Richard", "Feynman", "19180511-1980"));

            _spaceshuttles.AddRange(new List<ISpaceShuttle>
            {
                new Odyssey (1, "Odyssey_Junior", "2001_013A", 10000, 1000, 100, SpaceShuttleStatus.Available, SpaceShuttles.Odyssey),
                new Atlantis (2, "Atlantis_TheSorcerer", "OV_104", 10000, 1000, 100, SpaceShuttleStatus.Available, SpaceShuttles.Atlantis),
                new Endeavour (3, "Endeavour_Interstellar", "OV_105", 10000, 1000, 100, SpaceShuttleStatus.Available, SpaceShuttles.Endeavour),
                new Excalibur (4, "Excalibur_of_Tuscany", "OV_106", 10000, 1000, 100, SpaceShuttleStatus.Available, SpaceShuttles.Excalibur),
                new Icarus (5, "Icarus_Daedalus", "OV_107", 10000, 1000, 100, SpaceShuttleStatus.Available, SpaceShuttles.Icarus),
                new Serenity (6, "Odyssey_Junior", "404_E_132_4FE274A", 10000, 1000, 100, SpaceShuttleStatus.Available, SpaceShuttles.Serenity)

            });

            //Adding Bookings

            var spaceshuttle1 = _spaceshuttles.Single(v => v.ID.Equals(1));
            spaceshuttle1.Status = SpaceShuttleStatus.Booked;
            var person1 = _persons.Single(v => v.CustomerID.Equals(1));
            _bookings.Add(new Booking(1, spaceshuttle1, person1));

            var spaceshuttle2 = _spaceshuttles.Single(v => v.ID.Equals(2));
            spaceshuttle1.Status = SpaceShuttleStatus.Booked;
            var person2 = _persons.Single(v => v.CustomerID.Equals(2));
            var booking = new Booking(2, spaceshuttle2, person2);
            _bookings.Add(booking);
        }

        public IEnumerable<IPerson> GetPersons() => _persons;
        public IEnumerable<IBooking> GetBookings() => _bookings;
        public IEnumerable<ISpaceShuttle> GetSpaceShuttles(SpaceShuttleStatus status = default)
        {
            if (status == default) return _spaceshuttles;
            return _spaceshuttles.Where(v => v.Status.Equals(status));
        }
    }
}

