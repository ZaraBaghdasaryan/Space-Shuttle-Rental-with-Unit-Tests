using Space_Shuttle.Data.Interfaces;
using Space_Shuttle.Data.Classes;
using Space_Shuttle.Common.Classes;
using System.Collections.Generic;
using System.Linq;
using Space_Shuttle.Common.Interfaces;
using Space_Shuttle.Common.Enums;

namespace Space_Shuttle.Business.Classes
{ 
    public class BookingProcessor
    
    {
        private readonly IData _db = new CollectionData();

        public IEnumerable<Customer> GetCustomers() => _db.GetPersons().Cast<Customer>();
        public IEnumerable<IBooking> GetBookings()
        {
            try
            {
                return _db.GetBookings();

            }
            catch
            {
                throw;
            }
        }
        public IEnumerable<ISpaceShuttle> GetSpaceShuttles(SpaceShuttleStatus status = default)
        {
            try
            {
                return _db.GetSpaceShuttles(status);

            }
            catch
            {
                throw;
            }
        }
        public string[] SpaceShuttleShuttlesNames => _db.SpaceShuttleShuttlesNames;

    }

}
 
