using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal interface ITrafficLight
    {
        void Operate(DateTime dateTime);
    }

    class DayTrafficLight : ITrafficLight
    {
        public void Operate(DateTime dateTime)
        {
            Console.WriteLine($"Current time: {dateTime.ToString("HH:mm:ss")}");
            Console.WriteLine("Traffic lights are on and exchange every minute");
        }
    }
    class RushHourTrafficLight : ITrafficLight
    {
        public void Operate(DateTime dateTime)
        {
            Console.WriteLine($"Current time: {dateTime.ToString("HH:mm:ss")}");
            Console.WriteLine("Traffic lights are on and exchange every 30 seconds");
        }
    }
    class NightTrafficLight : ITrafficLight
    {
        public void Operate(DateTime dateTime)
        {
            Console.WriteLine($"Current time: {dateTime.ToString("HH:mm:ss")}");
            Console.WriteLine("Traffic lights are off");

        }
    }
}
