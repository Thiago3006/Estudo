﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent.Services
{
    internal interface ITaxService
    {
        double Tax(double amount);
    }
}
