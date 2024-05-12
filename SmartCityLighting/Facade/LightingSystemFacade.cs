namespace SmartCityLighting
{
    // Facade Deseni: Sistemle ilgili birçok işlemi basitleştirir.
    public class LightingSystemFacade
    {
        public void SetupLightScenario(ILightCommand onCommand, ILightCommand offCommand)
        {
            onCommand.Execute();
            // Belirli bir süre sonra ışığı otomatik olarak kapatır.
            offCommand.Execute();
        }

        public void ActivateScenario(Light light, ILightCommand onCommand, ILightCommand offCommand)
        {
            Console.WriteLine("Activating lighting scenario...");
            onCommand.Execute();
            // simulate delay
            System.Threading.Thread.Sleep(2000);
            offCommand.Execute();
        }
    }
}
