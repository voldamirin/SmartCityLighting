namespace SmartCityLighting
{
    // Adapter Deseni: Farklı sistemleri uyumlu hale getirir.
    public class OldLightAdapter : Light
    {
        private OldLight oldLight;

        public OldLightAdapter(OldLight oldLight)
        {
            this.oldLight = oldLight;
        }

        public override void TurnOn()
        {
            oldLight.SwitchOn();
        }

        public override void TurnOff()
        {
            oldLight.SwitchOff();
        }
    }
}
