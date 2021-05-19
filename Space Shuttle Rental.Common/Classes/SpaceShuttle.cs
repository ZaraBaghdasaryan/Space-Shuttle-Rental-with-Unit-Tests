using System;
using Space_Shuttle.Common.Enums;
using Space_Shuttle.Common.Interfaces;

	namespace Space_Shuttle.Common.Classes
{

	public abstract class SpaceShuttle : ISpaceShuttle
	{
		public int ID { get; }
		public string Make { get; }
		public string RegistrationNo { get; }
		public double DistanceTraveled { get; }
		public double CostPerLightYear { get; }
		public double CostPerDay
		{
			get
			{
				return Shuttles switch
				{
					SpaceShuttles.Odyssey => 100,
					SpaceShuttles.Atlantis => 200,
					SpaceShuttles.Endeavour => 300,
					SpaceShuttles.Excalibur => 400,
					SpaceShuttles.Icarus => 400,
					SpaceShuttles.Serenity => 400,
					_ => throw new ArgumentException("SpaceShuttle is not available."),
				};
			}
		}
			public SpaceShuttleStatus Status { get; set; }
			public SpaceShuttles Shuttles { get; }

        public SpaceShuttle( int Id, string make, string registrationNo, double distanceTraveled, double costPerLightYear, double costPerDay, SpaceShuttleStatus status, SpaceShuttles shuttles)
        {
			ID = Id;
			Make = make;
			RegistrationNo = registrationNo;
			DistanceTraveled = distanceTraveled;
			CostPerLightYear = costPerLightYear;
			Status = status;
			Shuttles = shuttles;
		}
			public void Fly(double distance)
			{
				throw new NotImplementedException();
			}
		}
	}
