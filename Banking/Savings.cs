using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking {

	public class Savings : Account {

		public double IntRate { get; set; }

		public void CalcAndDepositInterest(int months) {
			// calculate interest
			double interest = Balance * (IntRate / 12) * months;
			// deposit the interest
			Deposit(interest);
		}

		public override string ToPrint() {
			string message = base.ToPrint();
			return message + ", IntRate=" + IntRate.ToString();
		}
	}
}
