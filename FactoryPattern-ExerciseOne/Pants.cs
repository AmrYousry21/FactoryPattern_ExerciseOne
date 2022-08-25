namespace FactoryPattern_ExerciseOne // Note: actual namespace depends on the project name.
{
    public class Pants : IClothes
    {
        public void CreateItem() 
        {
            Console.WriteLine("Created Pants");
        }
    }
}