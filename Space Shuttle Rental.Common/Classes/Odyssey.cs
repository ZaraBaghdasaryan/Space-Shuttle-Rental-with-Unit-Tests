
using Space_Shuttle.Common.Enums;
using System;

namespace Space_Shuttle.Common.Classes
{
   public class Odyssey : SpaceShuttle
    {
        public Odyssey(int Id, string make, string registrationNo, double distanceTraveled, double costPerLightYear, double costPerDay, SpaceShuttleStatus status, SpaceShuttles shuttles) : base (Id, make, registrationNo, distanceTraveled, costPerLightYear, costPerDay, status, shuttles)
        {
            Id = 26734;
            make = "Lockheed_Martin";
            registrationNo = "2001_013A";

        }
        public new void Fly (double distance)
			{
				throw new NotImplementedException();
			}
    }
}
