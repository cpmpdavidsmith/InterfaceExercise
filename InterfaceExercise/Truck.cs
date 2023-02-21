using System;
namespace InterfaceExercise
{
	public class Truck : IVehicle , ICompany
	{
		public Truck()
		{
		}

        public int WheelCount { get; set; } = 4;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "F-150";
        public string DriveType { get; set; } = "4 Wheel Drive";
        public string Name { get; set; } = "Ford Motor Commany";
        public string Logo { get; set; } = "ford";
        public bool HasChangedGears { get; set; }

        public bool HasTruckBed { get; set; } = true;

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward. . .");
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

