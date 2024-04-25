using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroecklynneMeyer_CPT_206_Library
{
	class MemberData
	{

		public string MemberId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zipcode { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }

		public List<MemberData> members = new List<MemberData>();

		public MemberData()
		{

		}

		public MemberData(string memberid, string first, string last, string address, string city, string state,string zip, string phone, string email)
		{
			MemberId = memberid;
			FirstName = first;
			LastName = last;
			Address = address;
			City = city;
			State = state;
			Zipcode = zip;
			Phone = phone;
			Email = email;
		}

		public void AddMember(MemberData member)
		{
			members.Add(member);
		}

		public IQueryable<Member> SearchMember(string criteria)//method to search books
		{
			LibraryDataContext db = new LibraryDataContext();
			var results = from mem in db.Members
						  where mem.LastName.Contains(criteria)
						  select mem;
			return results;
		}
	}
}
