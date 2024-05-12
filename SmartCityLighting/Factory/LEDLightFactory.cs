namespace SmartCityLighting
{
    public class LEDLightFactory : LightFactory
    {
        public override Light CreateLight()
        {
            return new LEDLight();
        }
    }
}
