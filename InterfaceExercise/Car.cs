using System;
namespace InterfaceExercise
{
	public class Car : IVehicle , ICompany
	{
		public Car()
		{
		}

        public int WheelCount { get; set; } = 4;
        public string Make { get; set; } = "Dodge";
        public string Model { get; set; } = "Challenger";
        public string DriveType { get; set; } = "Rear WheeDrive";
        public string Name { get; set; } = "Fiat Chrysler Automobiles";
        public string Logo { get; set; } = "//";
        public bool HasChangedGears { get; set; }

        public bool ManualTransmission { get; set; } = true;

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
                Console.WriteLine($"Cant park until gear is placed in park");
            }
        }

        public void Reverse()
        {
            if(HasChangedGears == true)
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

