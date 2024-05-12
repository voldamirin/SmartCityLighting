using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCityLighting
{
    // Memento Deseni: Bir nesnenin önceki durumunu saklar ve gerektiğinde bu durumu geri yükler.
    public class LightMemento
    {
        public bool State { get; private set; }

        public LightMemento(bool state)
        {
            State = state;
        }

        public void Restore(Light light)
        {
            if (State)
                light.TurnOn();
            else
                light.TurnOff();
        }
    }
}
