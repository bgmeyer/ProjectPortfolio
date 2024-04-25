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
	public partial class CDsForm : Form
	{
		public CDsForm()
		{
			InitializeComponent();
		}

		private void CDsForm_Load(object sender, EventArgs e)
		{
			LibraryDataContext db = new LibraryDataContext();//create data context object
			var results = from cd in db.CDs//query to get cd titles to populate combo box
						  select cd.Album;
			foreach (var cd in results)
			{
				cboxCdTitle.Items.Add(cd);//populate combo box
			}
		}

		private void btnGo_Click(object sender, EventArgs e)
		{
			if (cboxCdTitle.SelectedIndex == -1)
			{
				MessageBox.Show("Error! Please select a CD title to view information about.");//error message for nothing selected
			}
			else
			{

				string cdTitle = Convert.ToString(cboxCdTitle.SelectedItem);//get selected cd title to variable

				//get title to output label
				GetAlbum(cdTitle);//call method to get title

				//get isbn to output label
				GetIsbn(cdTitle);//call method to get isbn

				//get artist to output label
				GetArtist(cdTitle);//call method to get artist

				//get release date to output label
				GetReleaseDate(cdTitle);//call method to get release date

				//get genre to output label
				GetGenre(cdTitle);//call method to get genre

				//get description to output label
				GetDescription(cdTitle);//call method to get description

			}
		}

		public void GetAlbum(string cdTitle)//method to query album
		{
			LibraryDataContext db = new LibraryDataContext();

			var results = from cd in db.CDs
						  where cd.Album.Contains(cdTitle)
						  select cd.Album;

			//assign results of query to controls
			foreach (var result in results)
			{
				lblAlbumOutput.Text = result.ToString();
			}
		}

		public void GetIsbn(string cdTitle)//method to query isbn
		{
			LibraryDataContext db = new LibraryDataContext();

			var results = from cd in db.CDs
						  where cd.Album.Contains(cdTitle)
						  select cd.ISBN;

			//assign results of query to controls
			foreach (var result in results)
			{
				lblIsbnOutput.Text = result.ToString();
			}
		}

		public void GetArtist(string cdTitle)//method to query artist
		{
			LibraryDataContext db = new LibraryDataContext();

			var results = from cd in db.CDs
						  where cd.Album.Contains(cdTitle)
						  select cd.Artist;

			//assign results of query to controls
			foreach (var result in results)
			{
				lblArtistOutput.Text = result.ToString();
			}
		}

		public void GetReleaseDate(string cdTitle)//method to query release date
		{
			LibraryDataContext db = new LibraryDataContext();

			var results = from cd in db.CDs
						  where cd.Album.Contains(cdTitle)
						  select cd.Release_Date;

			//assign results of query to controls
			foreach (var result in results)
			{
				lblReleasedOutput.Text = result.ToString();
			}
		}

		public void GetGenre(string cdTitle)//method to query genre
		{
			LibraryDataContext db = new LibraryDataContext();

			var results = from cd in db.CDs
						  where cd.Album.Contains(cdTitle)
						  select cd.Genres;

			//assign results of query to controls
			foreach (var result in results)
			{
				lblGenreOutput.Text = result.ToString();
			}
		}

		public void GetDescription(string cdTitle)//method to query description
		{
			LibraryDataContext db = new LibraryDataContext();

			var results = from cd in db.CDs
						  where cd.Album.Contains(cdTitle)
						  select cd.Descriptors;

			//assign results of query to controls
			foreach (var result in results)
			{
				lblDescriptionOutput.Text = result.ToString();
			}
		}

		private void btnNewCD_Click(object sender, EventArgs e)
		{

			//create new add cd form
			AddCD frmAddCD = new AddCD();

			//show new form
			frmAddCD.Show();

			//clear lbls
			Clear();
		}

		private void Clear()
		{
			//clear isbn lbl of input
			lblIsbnOutput.Text = " ";

			//clear album lbl of input
			lblAlbumOutput.Text = " ";

			//clear genre lbl of input
			lblGenreOutput.Text = " ";

			//clear artist lbl of input
			lblArtistOutput.Text = " ";

			//clear released lbl of input
			lblReleasedOutput.Text = " ";

			//clear description lbl of input
			lblDescriptionOutput.Text = " ";
		}
	}
}
