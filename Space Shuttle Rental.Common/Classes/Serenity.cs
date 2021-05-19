using Space_Shuttle.Common.Enums;
using System;

namespace Space_Shuttle.Common.Classes
{
    public class Serenity : SpaceShuttle
    {
        public Serenity (int Id, string make, string registrationNo, double distanceTraveled, double costPerLightYear, double costPerDay, SpaceShuttleStatus status, SpaceShuttles shuttles) : base(Id, make, registrationNo, distanceTraveled, costPerLightYear, costPerDay, status, shuttles)
        {
            Id = 82659;
            make = "Allied_Spacecraft_Corp";
            registrationNo = "404_E_132_4FE274A";

        }
        public new void Fly(double distance)
        {
            throw new NotImplementedException();
        }
    }
}
