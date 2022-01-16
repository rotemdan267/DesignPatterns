using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class VacationFluentBuilder
    {
        private Vacation vacation = new Vacation();
        public VacationFluentBuilder()
        {
            LowCostVacation low = new LowCostVacation();
            low.ConstructVacation();
            vacation = low.GetVacation();
        }
        public Vacation Build() => vacation;
        public VacationFluentBuilder WithFlightUpgrade()
        {
            vacation.Flight = "Direct first class flight";
            return this;
        }

        public VacationFluentBuilder WithHotelUpgrade()
        {
            vacation.Hotel = "5 Stars Hotel";
            return this;
        }

        public VacationFluentBuilder WithTransportationUpgrade()
        {
            vacation.Transportation = "Special Taxi";
            return this;
        }

    }
}
