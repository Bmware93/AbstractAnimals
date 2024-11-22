// See https://aka.ms/new-console-template for more information
using AbstractAnimals;

Zoo zoo = new Zoo();
int startingFood = 4;

int foodRequired = zoo.CalculateTotalFoodRequired();

if(foodRequired > startingFood)
{
    Console.WriteLine("At least one of our animals is going to strave");
    Console.WriteLine($"We are short {foodRequired - startingFood}");
    Console.WriteLine("Who are we getting rid of?");
}
else
{
    Console.WriteLine($"Everyone make sit through the winter. Even the animals");
}

zoo.DisplayAnimals();


