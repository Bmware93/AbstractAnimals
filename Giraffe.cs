using System;
namespace AbstractAnimals
{
	internal class Giraffe : Animal
	{
		public Giraffe()
		{
		}

        public override int CalculateFoodRequired()
        {
            return FoodConsumption;
        }

        public override void Display()
        {
            Console.WriteLine($"{Name} doesn't eat as much, she eats {CalculateFoodRequired()} foods");
        }
    }
}

