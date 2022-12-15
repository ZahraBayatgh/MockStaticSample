namespace MockStaticSample
{
    public static class Generator
    {
        //public static Func<int, int, int> Add = (a, b) =>
        //{
        //    return a + b;
        //};
        //public static int GenerateCode()
        //{
        //    return new Random().Next(20, 100);

        //}
        public static Func<int, int, int> GenerateCode = (a,b) =>
        {
            return new Random().Next(a, b);
        };
    }
}
