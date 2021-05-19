using Space_Shuttle.Common.Interfaces;
using System;

namespace Space_Shuttle.Common.Classes
{
   public class Booking : IBooking 
    {
        public int ID { get; }
        public int SpaceShuttleID { get; }
        public string RegistrationNo { get; }
        public IPerson Person { get; }
        public DateTime Rented { get; }
        public DateTime Returned { get; }
        public double Cost { get; }
        public double DistanceTraveledRented { get; }

        public double DistanceTraveledReturned { get; }

        public Booking(int id, ISpaceShuttle spaceShuttle, IPerson person)
        {
            if (id < 0 || spaceShuttle.ID < 0 || person == default)
                throw new AggregateException();

            ID = id;
            RegistrationNo = spaceShuttle.RegistrationNo;
            SpaceShuttleID = spaceShuttle.ID;
            Person = person;
            Rented = DateTime.Now;
            DistanceTraveledRented = spaceShuttle.DistanceTraveled;
               
        }

        public void ReturnVehicle(ISpaceShuttle spaceshuttle)
        {
            throw new NotImplementedException();
        }
       
    }
}
