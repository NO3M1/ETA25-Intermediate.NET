using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ETA25_Intermediate_C_.OOP.Encapsulation
{
    public class BankTest
    {

        private Wallet wallet;


        [SetUp]
        public void Setup()
        {
          wallet = new Wallet(1000);  
        }

        [Test]
        public void TestDeposit()
        {
            wallet.Deposit(500);
            //Console.WriteLine(wallet.GetBalance());
            Console.WriteLine(wallet.Balance);
      
        }

        [Test]
        public void TestWithdraw()
        {
            wallet.Withdraw(200);
            //Console.WriteLine(wallet.GetBalance());
        }




    }
}
