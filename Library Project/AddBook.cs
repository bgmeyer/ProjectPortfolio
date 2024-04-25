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
	public partial class AddBook : Form
	{

		public AddBook()
		{
			InitializeComponent();
		}


		private void btnClose_Click(object sender, EventArgs e)
		{
			//close this form
			this.Close();

		}


		private void btnNewBook_Click(object sender, EventArgs e)
		{

			//call method to create new book entry
			NewBook();

			//call method to clear user input from form
			ClearForm();

			//add book complete message
			MessageBox.Show("New book process complete.");

		}


		private void NewBook()
		{
			//get user input for book title from text box
			string title = txtboxTitleInput.Text;

			//get user input for isbn from text box
			string isbn = txtboxIsbnInput.Text;

			//get user input for publisher from text box
			string publisher = txtboxPublisherInput.Text;

			//get user input for publishing date from text box
			string year = txtboxYearPublished.Text;

			//get user input for author
			string author = txtboxAuthorInput.Text;

			//create bookdata object
			BookData book = new BookData(title, isbn, publisher, year, author);//create new bookdata object with information

			//store book object
			book.AddBook(book);
		}


		private void ClearForm()
		{

			//clear title text box of user input
			txtboxTitleInput.Text = " ";

			//clear isbn text box of user input
			txtboxIsbnInput.Text = " ";

			//clear publisher text box of user input
			txtboxPublisherInput.Text = " ";

			//clear year published text box of user input
			txtboxYearPublished.Text = " ";

			//clear author text box of user input
			txtboxAuthorInput.Text = " ";


		}
	}
}
