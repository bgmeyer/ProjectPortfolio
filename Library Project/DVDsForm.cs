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
	public partial class DVDsForm : Form
	{
		public DVDsForm()
		{
			InitializeComponent();
		}

		private void DVDsForm_Load(object sender, EventArgs e)
		{
			LibraryDataContext db = new LibraryDataContext();//create data context object

			var results = from dvd in db.DVDs//query to get dvd titles to populate combo box
						  select dvd.title;

			foreach (var dvd in results)
			{
				cboxDVDTitle.Items.Add(dvd);//populate combo box
			}
		}

		private void btnGo_Click(object sender, EventArgs e)
		{
			if (cboxDVDTitle.SelectedIndex == -1)
			{
				MessageBox.Show("Error! Please select a DVD title to view information about.");//error message for nothing selected
			}
			else
			{

				string dvdTitle = Convert.ToString(cboxDVDTitle.SelectedItem);//get selected dvd title to variable

				//get title to output label
				GetTitle(dvdTitle);//call method to get title

				//get isbn to output label
				GetIsbn(dvdTitle);//call method to get isbn

				//get language to output label
				GetLanguage(dvdTitle);//call method to get language

				//get genre to output label
				GetGenre(dvdTitle);//call method to get genre

				//get release date to output label
				GetReleaseDate(dvdTitle);//call method to get release date

				//get runtime to output label
				GetRuntime(dvdTitle);//call method to get runtime

			}
		}


		public void GetRuntime(string title)//method to query runtime
		{
			LibraryDataContext db = new LibraryDataContext();

			var results = from dvd in db.DVDs
						  where dvd.title.Contains(title)
						  select dvd.runtime;

			//assign results of query to controls
			foreach (var result in results)
			{
				lblRuntimeOutput.Text = result.ToString();
			}
		}


		public void GetReleaseDate(string title)//method to query release date
		{
			LibraryDataContext db = new LibraryDataContext();

			var results = from dvd in db.DVDs
						  where dvd.title.Contains(title)
						  select dvd.release_date;

			//assign results of query to controls
			foreach (var result in results)
			{
				lblReleasedOutput.Text = result.ToString();
			}
		}


		public void GetGenre(string title)//method to query genre
		{
			LibraryDataContext db = new LibraryDataContext();

			var results = from dvd in db.DVDs
						  where dvd.title.Contains(title)
						  select dvd.genres;

			//assign results of query to controls
			foreach (var result in results)
			{
				lblGenreOutput.Text = result.ToString();
			}
		}


		public void GetLanguage(string title)//method to query language
		{
			LibraryDataContext db = new LibraryDataContext();

			var results = from dvd in db.DVDs
						  where dvd.title.Contains(title)
						  select dvd.language;

			//assign results of query to controls
			foreach (var result in results)
			{
				lblLanguageOutput.Text = result.ToString();
			}
		}


		public void GetIsbn(string title)//method to query isbn
		{
			LibraryDataContext db = new LibraryDataContext();

			var results = from dvd in db.DVDs
						  where dvd.title.Contains(title)
						  select dvd.ISBN;

			//assign results of query to controls
			foreach (var result in results)
			{
				lblIsbnOutput.Text = result.ToString();
			}
		}


		public void GetTitle(string title)//method to query title
		{
			LibraryDataContext db = new LibraryDataContext();

			var results = from dvd in db.DVDs
						  where dvd.title.Contains(title)
						  select dvd.title;

			//assign results of query to controls
			foreach (var result in results)
			{
				lblTitleOutput.Text = result.ToString();
			}
		}

		private void btnNewDVD_Click(object sender, EventArgs e)
		{

			//create new add dvd form
			AddDVD frmAddDVD = new AddDVD();

			//show new add dvd form
			frmAddDVD.Show();

			//call clear form method
			Clear();
		}

		private void Clear()
		{
			//clear isbn lbl of input
			lblIsbnOutput.Text = " ";

			//clear title lbl of input
			lblTitleOutput.Text = " ";

			//clear genre lbl of input
			lblGenreOutput.Text = " ";

			//clear language lbl of input
			lblLanguageOutput.Text = " ";

			//clear release date lbl of input
			lblReleasedOutput.Text = " ";

			//clear runtime lbl of input
			lblRuntimeOutput.Text = " ";
		}
	}
}
