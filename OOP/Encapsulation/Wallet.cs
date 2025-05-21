using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETA25_Intermediate_C_.OOP.Encapsulation
{
    public class Wallet
    {
        private decimal balance;
      
        public Wallet(decimal initialAmonunt)
        {
            this.balance = initialAmonunt;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount");
            }
        }

  /*      public decimal GetBalance() 
        { 
            return balance; 
        }*/

        public decimal Balance
        {
            get
            {
                return balance;
            }

        }


    }
}
