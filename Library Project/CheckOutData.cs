using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroecklynneMeyer_CPT_206_Library
{
	class CheckOutData
	{

		public string MemberID { get; set; }
		public string Isbn { get; set; }
		public string Date { get; set; }
		public string DueDate { get; set; }

		public List<CheckOutData> checkouts = new List<CheckOutData>();

		public CheckOutData()
		{

		}

		public CheckOutData(string memberid, string isbn, string date, string due)
		{
			MemberID = memberid;
			Isbn = isbn;
			Date = date;
			DueDate = due;
		}

		public void AddCheckOut(CheckOutData checkout)
		{
			checkouts.Add(checkout);
		}
	}
}
