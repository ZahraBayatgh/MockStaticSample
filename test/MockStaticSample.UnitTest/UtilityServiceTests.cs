using MockStaticSample.API;
using MockStaticSample.API.Utilities;
using Moq;

namespace MockStaticSampleTests
{
    public class UtilityServiceTests
    {
        private UtilityService _utilityService;

        Mock<IDateTimeService> _dateTimeService = new();
        public UtilityServiceTests()
        {
            _utilityService = new UtilityService(_dateTimeService.Object);
        }

        #region CheckRandomNumber

        [Fact]
        public void CheckRandomNumber_When_Number_Greater_Than_Return_True()
        {
            //Arrange
            var min = 10;
            var max = 100;

            Generator.GenerateCode = (x, y) => { return 60; };

            //Act
            var result = _utilityService.CheckRandomNumber(min, max);

            //Assert
            Assert.True(result);
        }
        [Fact]
        public void CheckRandomNumber_When_Number_Leaser_Than_Return_False()
        {
            //Arrange
            var min = 10;
            var max = 100;

            Generator.GenerateCode = (x, y) => { return 4; };

            //Act
            var result = _utilityService.CheckRandomNumber(min, max);

            //Assert
            Assert.False(result);
        }

        #endregion

        #region CheckRandomNumber

        [Fact]
        public void CheckDateTime_When_Day_Greater_Than_15_Return_True()
        {
            //Arrange
            _dateTimeService.Setup(r => r.GetDay())
                            .Returns(16);

            //Act
            var result = _utilityService.CheckDateTime();

            //Assert
            Assert.True(result);
        }
        [Fact]
        public void CheckDateTime_When_Day_Leaser_Than_15_Return_True()
        {
            //Arrange
            _dateTimeService.Setup(r => r.GetDay())
                            .Returns(14);

            //Act
            var result = _utilityService.CheckDateTime();

            //Assert
            Assert.False(result);
        }
        #endregion
    }
}