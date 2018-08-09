using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking {

	public class Investment : IAccountStatement {

		public Account account { get; set; }

		public void Deposit(double amount) {
			account.Deposit(amount);
		}
		public void Sell(double amount) {
			account.Withdraw(amount);
		}
		public double GetBalance() {
			return (double) account.GetBalance();
		}

		public string ToPrint() {
			string message = account.ToPrint();
			return message + ", Investment account";
		}

		public Investment() {
			account = new Account();
			account.Id = 1000;
			account.Description = "My first investment account";
			account.Balance = 0;
			account.Owner = new Customer(111, "Dave D.");
		}

	}
}
