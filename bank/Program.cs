using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class bank
    {
        int accno;
        string accname;
        double balance;
        static string bankname;
        static string bankloc;
        static bank()
        {
            bankname = "ICICI";
            bankloc = "madhapur";
        }
        internal bank(int accno, string accname)
        {
            this.accno = accno;
            this.accname = accname;
        }
        internal static void bankdisplay()
        {
            Console.WriteLine("bank name : " + bankname);
            Console.WriteLine("bank location : " + bankloc);
        }
        internal void createaccount(double amount)
        {
           balance = balance + amount;
            Console.WriteLine("Account created succesfully");
            Console.WriteLine("your account details are:");
            Console.WriteLine("Account number : " + accno);
            Console.WriteLine("Acccount name : " + accname);
            Console.WriteLine("your account balance is " +  balance);   
        }
        internal void deposit(double amount)
        {
            balance = balance + amount;
            Console.WriteLine("you have deposited the amount of " + amount);
            Console.WriteLine("your current balance is " + balance);
        }
        internal void withdraw(double amount)
        {
            balance = balance - amount;
            Console.WriteLine("you have withdrwan the amount of " + amount);
            Console.WriteLine("your current balance is " + balance);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bank b = new bank(12121, "xyz");
            b.createaccount(10000);
            bank.bankdisplay();
            b.deposit(30000);
            b.withdraw(12000);
        }
    }
}
