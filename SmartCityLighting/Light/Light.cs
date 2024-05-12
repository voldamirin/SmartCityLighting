using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCityLighting
{
    // Light sınıfı temel sınıftır ve diğer ışık türleri için bir temel sağlar.
    public abstract class Light
    {
        public bool IsOn { get; protected set; }

        public virtual void TurnOn()
        {
            IsOn = true;
        }

        public virtual void TurnOff()
        {
            IsOn = false;
        }

        // Gözlemcileri bilgilendirme metodu
        protected void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(this);
            }
        }

        private List<ILightObserver> observers = new List<ILightObserver>();

        public void Attach(ILightObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(ILightObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
