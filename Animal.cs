using System;
namespace AbstractAnimals
{
	internal abstract class Animal
	{
		public string Name { get; set; }

		public int FoodConsumption { get; set; } = 1;

		public abstract void Display();

		public abstract int CalculateFoodRequired();
	}
}

