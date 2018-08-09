using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking {

	public class Customer {

		public int Id { get; set; }
		public string Fullname { get; set; }

		public Customer(int id, string fullname) {
			Id = id;
			Fullname = fullname;
		}
	}
}
