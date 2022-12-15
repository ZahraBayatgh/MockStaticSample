using MockStaticSample;
using Xunit;

namespace MockStaticSampleTests
{
    public class ServiceTests
    {
        [Fact]
        public void CheckTest()
        {
            //Arrange
            var service = new Service();
            
            var min = 10;
            var max = 100;

            Generator.GenerateCode = (x, y) => { return 60; };

            //Act
            var result = service.Check(min, max);
           
            //Assert
            Assert.True(result);
        }
    }
}