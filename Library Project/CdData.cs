using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroecklynneMeyer_CPT_206_Library
{
	class CdData
	{

		public string Album { get; set; }
		public string ISBN { get; set; }
		public string Artist { get; set; }
		public string ReleaseDate { get; set; }
		public string Genre { get; set; }
		public string Description { get; set; }

		public List<CdData> cds = new List<CdData>();

		public CdData()
		{

		}

		public CdData(string album, string isbn, string artist, string releasedate, string genre, string description)
		{
			Album = album;
			ISBN = isbn;
			Artist = artist;
			ReleaseDate = releasedate;
			Genre = genre;
			Description = description;
		}

		public void AddCd(CdData cd)
		{
			cds.Add(cd);
		}

		public IQueryable<CD> SearchCd(string criteria)//method to search cds
		{
			LibraryDataContext db = new LibraryDataContext();
			var results = from cd in db.CDs
						  where cd.Album.Contains(criteria)
						  select cd;
			return results;
		}
	}
}
