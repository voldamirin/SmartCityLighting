namespace SmartCityLighting
{
    // Singleton Deseni: Uygulama boyunca tek bir örnek sağlamak için kullanılır.
    public class LightingManager
    {
        private static LightingManager instance = null;
        private static readonly object padlock = new object();

        // Singleton örneği döndürür.
        public static LightingManager Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new LightingManager();
                    }
                    return instance;
                }
            }
        }

        private LightingManager() { }

        // Komutları uygulamak için kullanılır.
        public void ApplyCommand(ILightCommand command)
        {
            command.Execute();
        }
    }
}
