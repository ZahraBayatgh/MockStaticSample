using MockStaticSample.API.Utilities;

namespace MockStaticSample.API
{
    public class UtilityService
    {
        private readonly IDateTimeService _dateTimeService;

        public UtilityService(IDateTimeService dateTimeService)
        {
            _dateTimeService = dateTimeService;
        }
        public bool CheckRandomNumber(int min, int max)
        {
            var result = Generator.GenerateCode(min, max);

            if (result > min / 2)
                return true;

            return false;
        }
        public bool CheckDateTime()
        {
            int? day = _dateTimeService.GetDay();

            if (day > 15)
                return true;

            return false;
        }

    }
}
