using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public interface IMachine
    {
        void ViewMyInformation();
        void RenewPassport();
        void ChangeAddress();
    }
    internal class InteriorOffice : IMachine
    {
        public void ChangeAddress()
        {
            Console.WriteLine("Congratulations! Have fun in your new place!");
        }

        public void RenewPassport()
        {
            Console.WriteLine($"Your passport has been successfully renewed until {DateTime.Now.Month.ToString()}.{DateTime.Now.AddYears(5).Year.ToString()}");
        }


        public void ViewPersonInformation(Person p)
        {
            Console.WriteLine($"Your name is {p.Name}");
        }
        void MuchMoreClassifiedOptions()
        {
            Console.WriteLine("Would you like to change your id number? or your name? your bank account? You can do everything here!!!!!");
        }
        public void ViewMyInformation()
        {
            throw new NotImplementedException();
        }
    }
    internal class ServiceMachine : IMachine
    {
        private InteriorOffice interiorOffice;
        private Person user;

        public ServiceMachine(InteriorOffice interiorOffice, Person user)
        {
            this.interiorOffice = interiorOffice;
            this.user = user;
        }

        public void ChangeAddress()
        {
            interiorOffice.ChangeAddress();
        }

        public void RenewPassport()
        {
            interiorOffice.RenewPassport();
        }

        public void ViewMyInformation()
        {
            interiorOffice.ViewPersonInformation(user);
        }
    }
    public class Person
    {
        public string Name { get; set; }
    }
}
