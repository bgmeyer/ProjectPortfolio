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
	public partial class AddCD : Form
	{
		public AddCD()
		{
			InitializeComponent();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{

			//close add cd form
			this.Close();

		}

		private void btnSaveCD_Click(object sender, EventArgs e)
		{

			//call method to create new cd entry
			NewCD();

			//call method to clear user input from form
			ClearForm();

			//add book complete message
			MessageBox.Show("New CD process complete.");

		}


		private void NewCD()
		{
			//get user input for cd title from text box
			string album = txtboxAlbumInput.Text;

			//get user input for isbn from text box
			string isbn = txtboxIsbnInput.Text;

			//get user input for publisher from text box
			string artist = txtboxArtistInput.Text;

			//get user input for release date from text box
			string releasedate = txtboxReleasedInput.Text;

			//get user input for genre
			string genre = txtboxGenreInput.Text;

			//get user input for description
			string description = txtboxDescriptionInput.Text;

			//create check in object
			CdData cd = new CdData(album, isbn, artist, releasedate, genre, description);//create new bookdata object with information

			//store book object
			cd.AddCd(cd);
		}


		private void ClearForm()
		{

			//clear album text box of user input
			txtboxAlbumInput.Text = " ";

			//clear isbn text box of user input
			txtboxIsbnInput.Text = " ";

			//clear artist text box of user input
			txtboxArtistInput.Text = " ";

			//clear releasedate text box of user input
			txtboxReleasedInput.Text = " ";

			//clear genre text box of user input
			txtboxGenreInput.Text = " ";

			//clear description text box of user input
			txtboxDescriptionInput.Text = " ";


		}
	}
}
