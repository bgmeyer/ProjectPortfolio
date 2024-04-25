using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroecklynneMeyer_CPT_206_Library
{
	class EquipmentData
	{

		public string Make { get; set; }
		public string ISBN { get; set; }
		public string Model { get; set; }
		public string Year { get; set; }
		public string Os { get; set; }
		public string Memory { get; set; }

		public List<EquipmentData> computers = new List<EquipmentData>();

		public EquipmentData()
		{

		}

		public EquipmentData(string make, string isbn, string model, string year, string os, string memory)
		{
			Make = make;
			ISBN = isbn;
			Model = model;
			Year = year;
			Os = os;
			Memory = memory;
		}

		public void AddEquipment(EquipmentData equip)
		{
			computers.Add(equip);
		}

		public IQueryable<Equipment> SearchEquipment(string criteria)//method to search equipment
		{
			LibraryDataContext db = new LibraryDataContext();
			var results = from equip in db.Equipments
						  where equip.MODEL.Contains(criteria)
						  select equip;
			return results;
		}
	}
}
