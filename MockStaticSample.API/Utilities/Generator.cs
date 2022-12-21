namespace MockStaticSample.API.Utilities
{
    public static class Generator
    {
        public static int SimpleGenerateCode (int a,int b) 
        {
            return new Random().Next(a, b);
        }
        public static Func<int, int, int> GenerateCode = (a, b) =>
        {
            return new Random().Next(a, b);
        };
    }
}
