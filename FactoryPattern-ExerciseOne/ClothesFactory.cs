namespace FactoryPattern_ExerciseOne // Note: actual namespace depends on the project name.
{
    public static class ClothesFactory 
    {
        public static IClothes GetIem(string input) 
        {
            switch (input.ToLower())
            {
                case "shirt":
                    return new Shirts();
                    break;
                case "pants":
                    return new Pants();
                    break;
                default:
                    return new Shirts();

            }
        }
    }
}