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
	public partial class AddDVD : Form
	{
		public AddDVD()
		{
			InitializeComponent();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			//close this form
			this.Close();

		}

		

		private void btnSaveDVD_Click(object sender, EventArgs e)
		{
			//call method to create new dvd entry
			NewDVD();

			//call method to clear user input from form
			ClearForm();

			//add book complete message
			MessageBox.Show("New DVD process complete.");
		}


		private void NewDVD()
		{
			//get user input for dvd title from text box
			string title = txtboxTitleInput.Text;

			//get user input for isbn from text box
			string isbn = txtboxIsbnInput.Text;

			//get user input for genre from text box
			string genre = txtboxGenreInput.Text;

			//get user input for language from text box
			string language = txtboxLanguageInput.Text;

			//get user input for releasedate
			string released = txtboxReleasedInput.Text;

			//get user input for runtime
			string runtime = txtboxRuntimeInput.Text;

			//create check in object
			DvdData dvd = new DvdData(title, isbn, genre, language, released, runtime);//create new dvddata object with information

			//store book object
			dvd.AddDvd(dvd);
		}


		private void ClearForm()
		{

			//clear title text box of user input
			txtboxTitleInput.Text = " ";

			//clear isbn text box of user input
			txtboxIsbnInput.Text = " ";

			//clear genre text box of user input
			txtboxGenreInput.Text = " ";

			//clear language text box of user input
			txtboxLanguageInput.Text = " ";

			//clear released text box of user input
			txtboxReleasedInput.Text = " ";

			//clear runtime input
			txtboxRuntimeInput.Text = " ";


		}
	}
}
