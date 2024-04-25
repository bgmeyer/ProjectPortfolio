using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BroecklynneMeyer_CPT_206_Library
{
	public partial class BooksForm : Form
	{
		public BooksForm()
		{
			InitializeComponent();
		}

		private void BooksForm_Load(object sender, EventArgs e)
		{
			LibraryDataContext db = new LibraryDataContext();//create data context object

			var results = from book in db.Books//query to get book titles to populate combo box
						  select book.Title;

			foreach (var book in results)
			{
				cboxBookTitle.Items.Add(book);//populate combo box
			}
		}

		private void btnGo_Click(object sender, EventArgs e)
		{

			if (cboxBookTitle.SelectedIndex == -1)
			{
				MessageBox.Show("Error! Please select a book title to view information about.");//error message for nothing selected
			}
			else
			{
				
				string bookTitle = Convert.ToString(cboxBookTitle.SelectedItem);//get selected book title to variable

				//get title to output label
				GetTitle(bookTitle);//call method to get title

				//get isbn to output label
				GetIsbn(bookTitle);//call method to get isbn

				//get author to output label
				GetAuthor(bookTitle);//call method to get author

				//get year published to output label
				GetYearPublished(bookTitle);//call method to get year published

				//get publisher to output label
				GetPublisher(bookTitle);//call method to get publisher

			}
		}

		public void GetPublisher(string title)//method to query publisher
		{
			LibraryDataContext db = new LibraryDataContext();

			var results = from book in db.Books
						  where book.Title.Contains(title)
						  select book.Publisher;

			//assign results of query to controls
			foreach (var result in results)
			{
				lblPublisherOutput.Text = result.ToString();
			}
		}

		public void GetYearPublished(string title)//method to query year published
		{
			LibraryDataContext db = new LibraryDataContext();

			var results = from book in db.Books
						  where book.Title.Contains(title)
						  select book.Year;

			//assign results of query to controls
			foreach (var result in results)
			{
				lblYearOutput.Text = result.ToString();
			}
		}
		public void GetAuthor(string title)//method to query author
		{
			LibraryDataContext db = new LibraryDataContext();

			var results = from book in db.Books
						  where book.Title.Contains(title)
						  select book.Author;

			//assign results of query to controls
			foreach (var result in results)
			{
				lblAuthorOutput.Text = result.ToString();
			}
		}

		public void GetTitle(string title)//method to query title
		{
			LibraryDataContext db = new LibraryDataContext();

			var results = from book in db.Books
						  where book.Title.Contains(title)
						  select book.Title;

			//assign results of query to controls
			foreach (var result in results)
			{
				lblTitleOutput.Text = result.ToString();
			}
		}

		public void GetIsbn(string title)//method to query isbn
		{
			LibraryDataContext db = new LibraryDataContext();

			var results = from book in db.Books
						  where book.Title.Contains(title)
						  select book.ISBN;

			//assign results of query to controls
			foreach (var result in results)
			{
				lblIsbnOutput.Text = result.ToString();
			}
		}

		private void btnNewBook_Click(object sender, EventArgs e)
		{
			//create new add book form
			AddBook frmBooks = new AddBook();

			//show new add book form
			frmBooks.Show();

			//clear lbls
			Clear();
		}

		private void Clear()
		{
			//clear isbn lbl of input
			lblIsbnOutput.Text = " ";

			//clear title lbl of input
			lblTitleOutput.Text = " ";

			//clear author lbl of input
			lblAuthorOutput.Text = " ";

			//clear year lbl of input
			lblYearOutput.Text = " ";

			//clear publisher lbl of input
			lblPublisherOutput.Text = " ";

			
		}
	}
}
