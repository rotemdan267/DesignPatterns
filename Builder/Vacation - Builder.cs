using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Vacation
    {
        public string Flight { get; set; }
        public string Hotel { get; set; }
        public string Transportation { get; set; }
        public override string ToString()
        {
            return $"Flight: {Flight}\nHotel: {Hotel}\nTransportation: {Transportation}";
        }
    }
    public abstract class VacationBuilder
    {
        protected Vacation vacation;

        public VacationBuilder()
        {
            vacation = new Vacation();
        }

        public abstract void SetFlight();
        public abstract void SetHotel();
        public abstract void SetTransportation();

        public void ConstructVacation()
        {
            SetFlight();
            SetHotel();
            SetTransportation();
        }
        public Vacation GetVacation()
        {
            return vacation;
        }
    }
    public class DreamyVaction : VacationBuilder
    {
        public override void SetFlight()
        {
            vacation.Flight = "Direct first class flight";
        }

        public override void SetHotel()
        {
            vacation.Hotel = "5 Stars Hotel";
        }

        public override void SetTransportation()
        {
            vacation.Transportation = "Special Taxi";
        }
    }
    public class LowCostVacation : VacationBuilder
    {
        public override void SetFlight()
        {
            vacation.Flight = "connection flight on travel class";
        }

        public override void SetHotel()
        {
            vacation.Hotel = "3 Stars Hotel";
        }

        public override void SetTransportation()
        {
            vacation.Transportation = "Buss";
        }
    }
}
