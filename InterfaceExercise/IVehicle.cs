using System;
namespace InterfaceExercise
{
	public interface IVehicle
	{
		public int WheelCount { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public string DriveType { get; set; }
		public bool HasChangedGears { get; set; }

		public void Drive();
		public void Reverse();
		public void Park();
		public void ChangeGears(bool isChanged);
        
    }
}

