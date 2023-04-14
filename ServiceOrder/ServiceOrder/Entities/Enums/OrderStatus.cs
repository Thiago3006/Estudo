using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ServiceOrder.Entities.Enums
{
    public enum OrderStatus
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3

    }
}