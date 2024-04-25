using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroecklynneMeyer_CPT_206_Library
{
	class BookData
	{
        public string Title { get; set; }
		public string ISBN { get; set; }
		public string Author { get; set; }
		public string YearPublished { get; set; }
		public string Publisher { get; set; }

		public List<BookData> books = new List<BookData>();

		public BookData()
		{ 

		}

		public BookData(string title, string isbn, string author, string yearpublished, string publisher)
		{
			Title = title;
			ISBN = isbn;
			Author = author;
			YearPublished = yearpublished;
			Publisher = publisher;
		}

		public void AddBook(BookData book)
		{
			books.Add(book);
		}

		public IQueryable<Book> SearchBook(string criteria)//method to search books
		{
			LibraryDataContext db = new LibraryDataContext();
			var results = from book in db.Books
						  where book.Title.Contains(criteria)
						  select book;
			return results;
		}
	}
}
