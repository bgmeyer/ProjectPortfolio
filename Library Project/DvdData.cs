using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroecklynneMeyer_CPT_206_Library
{
	class DvdData
	{

		public string Title { get; set; }
		public string ISBN { get; set; }
		public string Language { get; set; }
		public string Genre { get; set; }
		public string ReleaseDate { get; set; }
		public string Runtime { get; set; }

		public List<DvdData> dvds = new List<DvdData>();


		public DvdData()
		{

		}

		public DvdData(string title, string isbn, string language, string genre, string releasedate, string runtime)
		{
			Title = title;
			ISBN = isbn;
			Language = language;
			ReleaseDate = releasedate;
			Genre = genre;
			Runtime = runtime;
		}

		public void AddDvd(DvdData dvd)
		{
			dvds.Add(dvd);
		}

		public IQueryable<DVD> SearchDvd(string criteria)//method to search dvds
		{
			LibraryDataContext db = new LibraryDataContext();
			var results = from dvd in db.DVDs
						  where dvd.title.Contains(criteria)
						  select dvd;
			return results;
		}
	}
}
