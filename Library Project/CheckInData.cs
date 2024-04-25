using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroecklynneMeyer_CPT_206_Library
{
	class CheckInData
	{

		public string MemberID { get; set; }
		public string Isbn { get; set; }
		public string Date { get; set; }

		public List<CheckInData> checkins = new List<CheckInData>();

		public CheckInData()
		{ 
		
		}

		public CheckInData(string memberid, string isbn, string date)
		{
			MemberID = memberid;
			Isbn = isbn;
			Date = date;
		}

		public void AddCheckIn(CheckInData checkin)
		{
			checkins.Add(checkin);
		}
	}
}
