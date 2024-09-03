using TheInterfaceSegregationPrinciple;
namespace UnitTests
{
    [TestClass]
    public class SmartCameraTests
    {
        [TestMethod]
        public void SmartCamera_ShouldDetectMotion()
        {
            var camera = new SmartCamera();  // Arrange
            camera.DetectMotion();           // Act and Assert
        }

        [TestMethod]
        public void SmartCamera_ShouldRecordVideo()
        {
            var camera = new SmartCamera();   // Arrange
            camera.RecordVideo();             // Act and Assert
        }
    }

    [TestClass]
    public class SmartHomeAssistantTests
    {
        [TestMethod]
        public void SmartHomeAssistant_ShouldTurnOn()
        {
            var assistant = new SmartHomeAssistant();   // Arrange
            assistant.TurnOn();                         // Act and Assert
        }

        [TestMethod]
        public void SmartHomeAssistant_ShouldTurnOff()
        {
            var assistant = new SmartHomeAssistant();    // Arrange
            assistant.TurnOff();                         // Act and Assert
        }

        [TestMethod]
        public void SmartHomeAssistant_ShouldAdjustBrightness()
        {
            var assistant = new SmartHomeAssistant();   // Arrange
            assistant.AdjustBrightness();               // Act and Assert
        }

        [TestMethod]
        public void SmartHomeAssistant_ShouldSetTemperature()
        {
            var assistant = new SmartHomeAssistant();   // Arrange
            assistant.SetTemperature();                 // Act and Assert
        }

        [TestMethod]
        public void SmartHomeAssistant_ShouldSetSchedule()
        {
            var assistant = new SmartHomeAssistant();  // Arrange
            assistant.SetSchedule();                   // Act and Assert
        }

        [TestMethod]
        public void SmartHomeAssistant_ShouldDetectMotion()
        {
            var assistant = new SmartHomeAssistant();  // Arrange
            assistant.DetectMotion();                  // Act and Assert
        }

        [TestMethod]
        public void SmartHomeAssistant_ShouldRecordVideo()
        {
            var assistant = new SmartHomeAssistant();  // Arrange
            assistant.RecordVideo();                    // Act and Assert
        }
    }

    [TestClass]
    public class SmartLightTests
    {
        [TestMethod]
        public void SmartLight_ShouldTurnOn()
        {
            var light = new SmartLight();  // Arrange
            light.TurnOn();               // Act and Assert
        }

        [TestMethod]
        public void SmartLight_ShouldTurnOff()
        {
            var light = new SmartLight();     // Arrange
            light.TurnOff();                  // Act and Assert
        }

        [TestMethod]
        public void SmartLight_ShouldAdjustBrightness()
        {
            var light = new SmartLight();  // Arrange
            light.AdjustBrightness();      // Act and Assert
        }
    }

    [TestClass]
    public class SmartThermostatTests
    {
        [TestMethod]
        public void SmartThermoStat_ShouldSetTemperature()
        {
            var thermostat = new SmartThermoStat();  // Arrange
            thermostat.SetTemperature();            // Act and Assert
        }

        [TestMethod]
        public void SmartThermoStat_ShouldSetSchedule()
        {
            var thermostat = new SmartThermoStat();  // Arrange
            thermostat.SetSchedule();                // Act and Assert
        }
    }
}
