using PhoenixAPI.Controllers;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using Moq;

namespace PhoenixAPITest
{
    public class Tests
    {
        [Test]
        public void Get_ReturnsTemperatureForValidId()
        {
            // Arrange
            var loggerMock = new Mock<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(loggerMock.Object);
            const int validId = 1;

            // Act
            var result = controller.Get(validId);

            // Assert
            const int expectedTemperature = 25;
            Assert.AreEqual(expectedTemperature, result);
        }

        [Test]
        public void Get_ReturnsZeroForInvalidId()
        {
            // Arrange
            var loggerMock = new Mock<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(loggerMock.Object);
            const int invalidId = 2;

            // Act
            var result = controller.Get(invalidId);

            // Assert
            const int expectedTemperature = 0;
            Assert.AreEqual(expectedTemperature, result);
        }
    }
}