using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCityLighting
{
    // Proxy Deseni: Gerçek nesneye erişimi kontrol eder.
    public class LightProxy : Light
    {
        private Light realLight;

        public LightProxy(Light realLight)
        {
            this.realLight = realLight;
        }

        public override void TurnOn()
        {
            realLight.TurnOn();
            NotifyObservers();
        }

        public override void TurnOff()
        {
            realLight.TurnOff();
            NotifyObservers();
        }
    }
}
