using System;
namespace InterfaceExercise
{
	public class SUV : IVehicle , ICompany
	{
		public SUV()
		{
		}

        public int WheelCount { get; set; } = 4;
        public string Make { get; set; } = "RangeRover";
        public string Model { get; set; } = "Velar";
        public string DriveType { get; set; } = "4 Wheel Drive and 2 Wheel Drive";
        public string Name { get; set; } = "Jaguar Land Rover";
        public string Logo { get; set; } = "LandRover";
        public bool HasChangedGears { get; set; }

        public bool MultiDriveTypeCapabilities { get; set; } = true;

        public void Drive()
        {
            Console.WriteLine($"Two wheel drive {GetType().Name} now driving forward. . .");
        }

        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now in park . . .");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine($"Can't park until gear is placed in park");
            }
        }

        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing . . .");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine($"Can't reverse until gears are changed");
            }
        }
        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
    }
}

