
using Space_Shuttle.Common.Enums;
namespace Space_Shuttle.Common.Interfaces
{
    public interface ISpaceShuttle
    {
        int ID { get; }
        string Make { get; }
        string RegistrationNo { get; }
        double DistanceTraveled { get; }
        double CostPerLightYear { get;}
        double CostPerDay { get; }
        SpaceShuttleStatus Status { get; set; }
        SpaceShuttles Shuttles { get; }

        void Fly(double distance);
    }
}
