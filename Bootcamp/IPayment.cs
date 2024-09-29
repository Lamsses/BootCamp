using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp
{
    public interface IPayment
    {
        void ProcessPayment(decimal amount);
    }

    public class CreditCardPayment : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount}");
        }
    }

    public class PayPalPayment : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("5% has been added back to your account ");
            Console.WriteLine($"Processing PayPal payment of {amount}");
        }
    }

    public class PaymentProcessor
    {
        public void Process(IPayment payment, decimal amount)
        {
            payment.ProcessPayment(amount);
        }
    }

}
