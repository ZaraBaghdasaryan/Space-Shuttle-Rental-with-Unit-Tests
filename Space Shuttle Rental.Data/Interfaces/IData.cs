using System.Collections.Generic;
using Space_Shuttle.Common.Interfaces;
using Space_Shuttle.Common.Enums;
using System;

namespace Space_Shuttle.Data.Interfaces
{
    public interface IData
    {
        IEnumerable<IPerson> GetPersons(); //returning a list of persons (with GetPersons inbuilt method)
        IEnumerable<IBooking> GetBookings();
        IEnumerable<ISpaceShuttle> GetSpaceShuttles(SpaceShuttleStatus status = default);
        public string [] SpaceShuttleShuttlesNames => Enum.GetNames(typeof(SpaceShuttles));

    }
}
