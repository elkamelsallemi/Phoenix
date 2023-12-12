using PhoenixAPI.Controllers;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using Moq;
using Microsoft.AspNetCore.Mvc;
using Phoenix.Models.Models;

namespace PhoenixAPITest
{
    public class Tests
    {
        [TestFixture]
        public class WeatherForecastControllerTests
        {
            [Test]
            public void Get_ReturnsOkObjectResult_WhenIdIsZero()
            {
                // Arrange
                var controller = new WeatherForecastController();

                // Act
                var result = controller.Get(0);

                // Assert
                Assert.IsInstanceOf<OkObjectResult>(result);
                var okResult = (OkObjectResult)result;
                var model = (Temperature)okResult.Value;

                Assert.AreEqual("0", model.CountryId);
                Assert.AreEqual(25, model.Temp);
            }

            [Test]
            public void Get_ReturnsNotFoundResult_WhenIdIsNotZero()
            {
                // Arrange
                var controller = new WeatherForecastController();

                // Act
                var result = controller.Get(1);

                // Assert
                Assert.IsInstanceOf<NotFoundObjectResult>(result);
            }
        }
    }
}