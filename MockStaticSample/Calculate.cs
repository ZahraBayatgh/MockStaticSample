namespace MockStaticSample
{
    public static class Generator
    {
        public static Func<int, int, int> GenerateCode = (a,b) =>
        {
            return new Random().Next(a, b);
        };
    }
}
