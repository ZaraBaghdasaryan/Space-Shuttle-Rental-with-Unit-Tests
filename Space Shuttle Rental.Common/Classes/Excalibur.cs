using Space_Shuttle.Common.Enums;
using System;

namespace Space_Shuttle.Common.Classes
{
    public class Excalibur : SpaceShuttle
    {
        public Excalibur(int Id, string make, string registrationNo, double distanceTraveled, double costPerLightYear, double costPerDay, SpaceShuttleStatus status, SpaceShuttles shuttles) : base(Id, make, registrationNo, distanceTraveled, costPerLightYear, costPerDay, status, shuttles)
        {
            Id = 46690;
            make = "LexCorp";
            registrationNo = "OV_106";

        }

        public new void Fly(double distance)
        {
            throw new NotImplementedException();

        }
    }
}
