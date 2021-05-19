
using Space_Shuttle.Common.Enums;
using System;

namespace Space_Shuttle.Common.Classes
{
    public class Atlantis : SpaceShuttle
    {
        public Atlantis (int Id, string make, string registrationNo, double distanceTraveled, double costPerLightYear, double costPerDay, SpaceShuttleStatus status, SpaceShuttles shuttles) : base(Id, make, registrationNo, distanceTraveled, costPerLightYear, costPerDay, status, shuttles)
        {
                Id = 51135;
                make = "Rockwell_International";
                registrationNo = "OV_104";

        }

        public new void Fly(double distance)
        {
            throw new NotImplementedException();
        }
    }
}

