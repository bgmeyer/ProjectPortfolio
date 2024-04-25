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
	public partial class CheckInForm : Form
	{

		public CheckInForm()
		{
			InitializeComponent();
		}


		private void btnCheckIn_Click(object sender, EventArgs e)
		{
			//call method to create new check in entry
			NewCheckIn();

			//call method to clear user input from form
			ClearForm();

			//check in complete message
			MessageBox.Show("Check In process complete.");
		}


		private void NewCheckIn()
		{
			//get user input for member id from text box
			string memberid = txtBoxMemberID.Text;

			//get user input for isbn from text box
			string isbn = txtBoxISBN.Text;

			//get user input for date from text box
			string date = txtBoxDate.Text;

			//create check in object
			CheckInData checkin = new CheckInData(memberid, isbn, date);//create new checkindata object with information

			//store check in object
			checkin.AddCheckIn(checkin);
		}


		private void ClearForm()
		{
			//clear date text box of user input
			txtBoxDate.Text = " ";

			//clear isbn text box of user input
			txtBoxISBN.Text = " ";

			//clear member id text box of user input
			txtBoxMemberID.Text = " ";

		
		}
	}
}
