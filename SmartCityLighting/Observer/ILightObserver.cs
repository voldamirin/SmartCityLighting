namespace SmartCityLighting
{
    // Observer Deseni: Nesneler arası durum güncellemelerini sağlar.
    public interface ILightObserver
    {
        void Update(Light light);
    }
}
