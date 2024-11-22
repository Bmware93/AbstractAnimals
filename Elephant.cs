using System;
namespace AbstractAnimals
{
	internal class Elephant : Animal
	{
		public Elephant()
		{
		}

        public override int CalculateFoodRequired()
        {
            return FoodConsumption * 3;
        }

        public override void Display()
        {
            Console.WriteLine($"{Name} eats more. He eats {CalculateFoodRequired()} foods");
        }
    }
}

