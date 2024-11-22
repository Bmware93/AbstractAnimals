using System;
namespace AbstractAnimals
{
	internal class Lion : Animal
	{
		public Lion()
		{
		}

        public override int CalculateFoodRequired()
        {
            return FoodConsumption * 2;
        }

        public override void Display()
        {
            Console.WriteLine($"This Lion's name is {Name}, he eats {CalculateFoodRequired()} foods");
        }
    }
}

