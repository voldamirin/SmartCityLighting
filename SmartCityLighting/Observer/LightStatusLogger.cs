namespace SmartCityLighting
{
    public class LightStatusLogger : ILightObserver
    {
        public void Update(Light light)
        {
            Console.WriteLine($"Aydınlatma durumu değişti: Aydınlatma {(light.IsOn ? "Açık" : "Kapalı")}");
        }
    }
}
