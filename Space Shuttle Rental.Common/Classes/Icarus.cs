using Space_Shuttle.Common.Enums;
using System;

namespace Space_Shuttle.Common.Classes
{
    public class Icarus : SpaceShuttle
    {
        public Icarus (int Id, string make, string registrationNo, double distanceTraveled, double costPerLightYear, double costPerDay, SpaceShuttleStatus status, SpaceShuttles shuttles) : base(Id, make, registrationNo, distanceTraveled, costPerLightYear, costPerDay, status, shuttles)
        {
            Id = 50103;
            make = "Project_Daedalus";
            registrationNo = "OV_107";

        }

        public new void Fly(double distance)
        {
            throw new NotImplementedException();

        }
    }
}
