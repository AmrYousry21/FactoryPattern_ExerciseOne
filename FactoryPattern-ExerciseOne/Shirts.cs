namespace FactoryPattern_ExerciseOne // Note: actual namespace depends on the project name.
{
    public class Shirts : IClothes
    {
        public void CreateItem()
        {
            Console.WriteLine("Created a Shirt");
        }
    }
}