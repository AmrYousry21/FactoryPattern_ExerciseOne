using System;

namespace FactoryPattern_ExerciseOne // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to buy Pants or a Shirt?");
            string input = Console.ReadLine();

            var item = ClothesFactory.GetIem(input);

            item.CreateItem();

        }
    }
}