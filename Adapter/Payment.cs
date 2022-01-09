using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public interface IPayment
    {
        void Pay(double amount);
    }

    class PaymentInDollars : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine("Thank you for choosing us!\n" +
                $"A bill for {amount.ToString("N2")}$ was sent to your Email");
        }
    }

    class PaymentInEuro
    {
        public void Pay(double amount)
        {
            Console.WriteLine("Thank you for choosing us!\n" +
                $"A bill for {amount.ToString("N2")} Euro was sent to your Email");
        }
    }

    class AdapterToEuro : IPayment
    {
        private PaymentInEuro payment = new PaymentInEuro();
        public void Pay(double amount)
        {
            amount *= 0.88;
            payment.Pay(amount);
        }
    }
}
