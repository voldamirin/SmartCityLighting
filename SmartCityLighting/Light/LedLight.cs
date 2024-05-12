using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCityLighting
{
    // LEDLight, Light sınıfından türetilmiş ve LED ışıklarını temsil eder.
    public class LEDLight : Light
    {
        public override void TurnOn()
        {
            base.TurnOn();
            // LED'e özgü açma işlevleri burada yer alabilir.
        }

        public override void TurnOff()
        {
            base.TurnOff();
            // LED'e özgü kapama işlevleri burada yer alabilir.
        }
    }
}
