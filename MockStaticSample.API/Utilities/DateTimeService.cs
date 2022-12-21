namespace MockStaticSample.API.Utilities
{
    public  class DateTimeService: IDateTimeService
    {
        public  int GetDay()
        {
            return DateTime.Now.Day;
        }
    }
}
