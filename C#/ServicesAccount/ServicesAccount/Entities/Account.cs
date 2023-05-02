using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicesAccount.Entities.Exceptions;
using System.Globalization;

namespace ServicesAccount.Entities
{
    internal class Account
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; } 
        public double Balance { get; protected set; }
        public double WithDrawLimit { get; protected set; }


        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if ( amount > WithDrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit.");
            }
            if (amount > Balance)
            {
                throw new DomainException("Not enough balance.");
            }
            Balance -= amount;
        }

        public override string ToString()
        {
            return $"${Balance.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
