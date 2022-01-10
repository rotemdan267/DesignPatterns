using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class TrafficLightManager
    {
        private ITrafficLight trafficLight = null;

        public TrafficLightManager()
        {
            DetermineOperationMethod(DateTime.Now);
        }

        internal void DetermineOperationMethod(DateTime dateTime)
        {
            if (dateTime.Hour < 6 || dateTime.Hour == 23)
            {
                TurnNight();
            }
            else if (dateTime.Hour > 14 && dateTime.Hour < 17)
            {
                StartRushHour();
            }
            else TurnDay();
        }
        internal void TurnDay()
        {
            trafficLight = new DayTrafficLight();
        }
        internal void TurnNight()
        {
            trafficLight = new NightTrafficLight();
        }
        internal void StartRushHour()
        {
            trafficLight = new RushHourTrafficLight();
        }
        internal void Operate(DateTime dateTime)
        {
            trafficLight.Operate(dateTime);
        }
    }
}
