namespace SmartCityLighting
{
    // OldLight, eski tip ışıkları temsil eden bir sınıftır ve Adapter deseni için kullanılabilir.
    public class OldLight
    {
        public bool IsOn { get; private set; }

        public void SwitchOn()
        {
            IsOn = true;
        }

        public void SwitchOff()
        {
            IsOn = false;
        }
    }
}
