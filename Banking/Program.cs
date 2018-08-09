using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking {
	class Program {
		static int Main(string[] args) {

			//Account acct1 = new Account();
			//acct1.Id = 1;
			//acct1.Description = "My first checking account";
			//acct1.Balance = 0.0;
			//acct1.Owner = new Customer(100, "Greg Doud");
			//Console.WriteLine(acct1.ToPrint());

			//acct1.Deposit(5.00);
			//Console.WriteLine(acct1.ToPrint());

			//acct1.Deposit(-5.00);
			//Console.WriteLine(acct1.ToPrint());

			//acct1.Withdraw(5000.00);
			//Console.WriteLine(acct1.ToPrint());

			//Savings sav2 = new Savings();
			//sav2.Id = 2;
			//sav2.Description = "My first savings account";
			//sav2.Balance = 0.0;
			//sav2.Owner = new Customer(101, "Lisa S.");
			//sav2.IntRate = 0.12;

			//sav2.Deposit(1000.00);
			//Console.WriteLine(sav2.ToPrint());

			//Checking chk3 = new Checking();
			//chk3.Id = 3;
			//chk3.Description = "My first checking account";
			//chk3.Balance = 0.0;
			//chk3.Owner = new Customer(102, "Denise B.");

			//chk3.Deposit(2000.00);
			//Console.WriteLine(chk3.ToPrint());

			//// print out monthly statement

			Checking chka = new Checking();
			chka.Id = 3;
			chka.Description = "My first checking account";
			chka.Balance = 0.0;
			chka.Owner = new Customer(103, "Kim P.");

			chka.Deposit(2000.00);

			Checking chkb = new Checking();
			chkb.Id = 3;
			chkb.Description = "My second checking account";
			chkb.Balance = 0.0;
			chkb.Owner = new Customer(103, "Kim P.");

			chkb.Deposit(2000.00);

			Savings sava = new Savings();
			sava.Id = 2;
			sava.Description = "My first savings account";
			sava.Balance = 0.0;
			sava.Owner = new Customer(103, "Kim P.");
			sava.IntRate = 0.12;

			sava.Deposit(1000.00);

			Investment inv1 = new Investment();
			inv1.Deposit(500.00);

			IAccountStatement[] accounts = { chka, chkb, sava, inv1 };

			double grandTotal = 0;
			foreach(IAccountStatement acct in accounts) {
				double acctBalance = acct.GetBalance();
				grandTotal = grandTotal + acctBalance;
				Console.WriteLine(acct.ToPrint());
			}
			Console.WriteLine("Grand total is " + grandTotal.ToString());


			Savings s = new Savings();

			Account s1 = new Savings();

			Account c = new Checking();




			Console.ReadKey();
			return 0;
		}
	}
}
