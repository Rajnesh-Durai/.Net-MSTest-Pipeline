using Microsoft.Extensions.Logging;
using Moq;
using MS_Testing_Pipeline;
using MS_Testing_Pipeline.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestProject
{
    [TestClass]
    public class WeatherForecastControllerTest
    {
        [TestMethod]
        public void Get_ReturnsWeatherForecastData()
        {
            // Arrange
            var logger = Mock.Of<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(logger);

            // Act
            var result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(IEnumerable<WeatherForecast>));
            Assert.AreEqual(5, result.Count()); // We expect 5 items as defined in the controller
        }
    }
}
