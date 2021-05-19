using System;

namespace Space_Shuttle.Common.Interfaces
{
    public interface IBooking
    {
        int ID { get; }
        int SpaceShuttleID { get; }
        string RegistrationNo { get; }
        IPerson Person { get; }
        DateTime Rented { get; }
        DateTime Returned { get; }
        double Cost { get; }
        double DistanceTraveledRented { get; }

        double DistanceTraveledReturned { get; }

        void ReturnVehicle(ISpaceShuttle spaceshuttle);


    }
}
