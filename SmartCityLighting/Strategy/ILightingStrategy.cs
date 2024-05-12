using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCityLighting
{
    // Strategy Deseni: Farklı stratejileri destekleyen bir yapı sunar.
    public interface ILightingStrategy
    {
        void Operate(Light light);
    }
}
