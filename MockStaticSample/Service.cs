namespace MockStaticSample
{
    public class Service
    {
        public bool Check(int min, int max)
        {
           var result= Generator.GenerateCode(min,max);
           
            if (result>max/2)
                return true;
            
            return false;
        }
    }
}
