namespace SmartCityLighting
{
    // Decorator Deseni: Işık nesnelerine dinamik olarak işlevsellik ekler.
    public class ColorChangingLight : Light
    {
        private Light decoratedLight;

        public ColorChangingLight(Light light) => this.decoratedLight = light;
        public override void TurnOn()
        {
            decoratedLight.TurnOn();
            Console.WriteLine("Color changing mode activated.");
        }
        public override void TurnOff() => decoratedLight.TurnOff();
    }
}
