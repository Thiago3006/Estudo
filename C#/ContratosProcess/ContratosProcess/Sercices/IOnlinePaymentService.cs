using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratosProcess.Sercices
{
    interface IOnlinePaymentService
    {
        double paymentFee(double amount);
        double Interest(double amount, int months);
    }
}
