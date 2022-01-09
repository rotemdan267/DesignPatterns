using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class Clock
    {
        TimeOnly timeOnly;
        
        DateTime dateTime;
        private static Clock clock;
        private Clock()
        {

        }

        public static Clock GetInstance()
        {
            if (clock == null)
            {
                clock = new Clock();
            }
            return clock;
        }

        public string GetTime()
        {
            this.dateTime = DateTime.Now;
            string str = dateTime.ToString("HH:mm:ss");
            return str;
        }


    }
}
