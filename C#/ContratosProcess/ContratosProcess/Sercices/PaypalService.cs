using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratosProcess.Sercices
{
    internal class PaypalService : IOnlinePaymentService
    {
        private double FeePercentage = 0.02;
        private double monthltInterest = 0.01;
        public double Interest(double amount, int months)
        {
            return amount * monthltInterest * months;
        }

        public double paymentFee(double amount)
        {
            return amount * FeePercentage;
        }
    }
}
