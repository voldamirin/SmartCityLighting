// See https://aka.ms/new-console-template for more information
using SmartCityLighting;

Console.WriteLine("Akıllı Aydınlatma Sistemi Simülatörüne Hoşgeldiniz!");
Console.WriteLine("Sistem başlatılıyor...");

LightingManager manager = LightingManager.Instance;
LightFactory factory = new LEDLightFactory();
Light light = new ColorChangingLight(new LightProxy(factory.CreateLight()));
light.Attach(new LightStatusLogger());

ILightCommand turnOn = new TurnOnLightCommand(light);
ILightCommand turnOff = new TurnOffLightCommand(light);
LightingSystemFacade facade = new LightingSystemFacade();

while (true)
{
    Console.WriteLine("\nKomutları girin ('aç', 'kapat', 'çıkış'):");
    string input = Console.ReadLine().ToLower();
    switch (input)
    {
        case "aç":
            Console.WriteLine("Işık açılıyor...");
            manager.ApplyCommand(turnOn);
            break;
        case "kapat":
            Console.WriteLine("Işık kapatılıyor...");
            manager.ApplyCommand(turnOff);
            break;
        case "çıkış":
            Console.WriteLine("Sistemden çıkılıyor...");
            return;
        default:
            Console.WriteLine("Geçersiz komut. Lütfen tekrar deneyin.");
            break;
    }
}



















