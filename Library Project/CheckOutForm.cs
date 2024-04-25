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
	public partial class CheckOutForm : Form
	{
		public CheckOutForm()
		{
			InitializeComponent();
		}

		private void btnCheckOut_Click(object sender, EventArgs e)
		{
			//call method to create new check out entry
			NewCheckOut();

			//call method to clear user input from form
			ClearForm();

			//check out complete message
			MessageBox.Show("Check Out process complete.");
		}

		private void NewCheckOut()
		{
			//get user input for member id from text box
			string memberid = txtBoxMemberID.Text;

			//get user input for isbn from text box
			string isbn = txtBoxISBN.Text;

			//get user input for date from text box
			string date = txtBoxDate.Text;

			//get user input for due date from text box
			string due = txtBoxDueDate.Text;

			//create check out object
			CheckOutData checkout = new CheckOutData(memberid, isbn, date, due);//create new checkoutdata object with information

			//store check out object
			checkout.AddCheckOut(checkout);
		}


		private void ClearForm()
		{
			//clear date text box of user input
			txtBoxDate.Text = " ";

			//clear isbn text box of user input
			txtBoxISBN.Text = " ";

			//clear member id text box of user input
			txtBoxMemberID.Text = " ";

			//clear due date text box of user input
			txtBoxDueDate.Text = " ";
		}
	}
}
