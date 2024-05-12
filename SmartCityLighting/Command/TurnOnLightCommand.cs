namespace SmartCityLighting
{
    public class TurnOnLightCommand : ILightCommand
    {
        private Light light;

        public TurnOnLightCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.TurnOn();
        }
    }
}
