using System;
namespace AbstractAnimals
{
	internal class Zoo
	{
		List<Animal> Animals { get; set; }

		public Zoo()
		{
			Animals = new List<Animal>();
			Animals.Add(new Lion { Name = "Leo", FoodConsumption = 3 });
			Animals.Add(new Giraffe { Name = "Jeffery", FoodConsumption = 1 });
			Animals.Add(new Elephant { Name = "Dumbo", FoodConsumption = 2 });
		}

		public int CalculateTotalFoodRequired()
		{
			int totalFoodRequired = 0;
			foreach(Animal animal in Animals)
			{
				totalFoodRequired = totalFoodRequired + animal.CalculateFoodRequired();
			}
			return totalFoodRequired;
		}

		public void DisplayAnimals()
		{
			foreach(Animal animal in Animals)
			{
				animal.Display();
			}
		}
	}
}

