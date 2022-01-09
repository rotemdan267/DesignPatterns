using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal abstract class Garage
    {
        protected Garage next;

        public void SetNext(Garage next)
        {
            this.next = next;
        }

        public abstract void FixCar(Car car);
    }

    class FirstCheck : Garage
    {
        public override void FixCar(Car car)
        {
            if (!car.IsInOrder)
            {
                Random rand = new Random();
                if (rand.Next(1, 11) > 5)
                {
                    Console.WriteLine("The car was fixed by the first technicain");
                    car.IsInOrder = true;
                }
                else next.FixCar(car);
            }
            else Console.WriteLine("Your car is O.K.");
        }
    }

    class SecondCheck : Garage
    {
        public override void FixCar(Car car)
        {
            if (!car.IsInOrder)
            {
                Random rand = new Random();
                if (rand.Next(1, 11) > 5)
                {
                    Console.WriteLine("The car was fixed by the second technicain");
                    car.IsInOrder = true;
                }
                else next.FixCar(car);
            }
        }
    }

    class ElectricalCheck : Garage
    {
        public override void FixCar(Car car)
        {
            if (!car.IsInOrder)
            {
                Random rand = new Random();
                if (rand.Next(1, 11) > 5)
                {
                    Console.WriteLine("The car was fixed by the electrician");
                    car.IsInOrder = true;
                }
                else next.FixCar(car);
            }
        }
    }

    class OverallExpertCheck : Garage
    {
        public override void FixCar(Car car)
        {
            if (!car.IsInOrder)
            {
                Random rand = new Random();
                if (rand.Next(1, 11) > 5)
                {
                    Console.WriteLine("The car was fixed by the expert-technician");
                    car.IsInOrder = true;
                }
                else
                {
                    Console.WriteLine("We couldn't fix yor car. Sorry.");
                }
            }
        }
    }
}
