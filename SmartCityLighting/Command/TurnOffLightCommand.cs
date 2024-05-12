namespace SmartCityLighting
{

    public class TurnOffLightCommand : ILightCommand
    {
        private Light light;

        public TurnOffLightCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.TurnOff();
        }
    }
}
