namespace TheInterfaceSegregationPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartLight smartLight = new SmartLight();
            SmartThermoStat smartThermostat = new SmartThermoStat();
            SmartCamera smartCamera = new SmartCamera();
            SmartHomeAssistant smartHomeAssistant = new SmartHomeAssistant();

            string? input;
            input = Console.ReadLine();
            if(input == "smartlight")
            {
                string? input1;
                Console.WriteLine("1 to turn on ------ 0 to turnoff the smart light");
                input1 = Console.ReadLine();
                if (input1 == "1")
                {
                    smartLight.TurnOn();
                }
                else
                {
                    smartLight.TurnOff();
                }
            }
            else if(input == "smartThermostat")
            {
                string? input1;
                Console.WriteLine("1 to set the temperature----2 to schedule----0 to both");
                input1 = Console.ReadLine();
                if(input1 == "1")
                {
                    smartThermostat.SetTemperature();
                }
                else if (input1 == "2")
                {
                    smartThermostat.SetSchedule();
                }
                else
                {
                    smartThermostat.SetTemperature();
                    smartThermostat.SetSchedule();
                }
            }
            smartCamera.DetectMotion();
            smartCamera.RecordVideo();
        }
    }
}
