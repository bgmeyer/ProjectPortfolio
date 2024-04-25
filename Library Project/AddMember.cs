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
	public partial class AddMember : Form
	{
		public AddMember()
		{
			InitializeComponent();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{

			//close this form
			this.Close();

		}

		private void btnSaveBook_Click(object sender, EventArgs e)
		{

			//call method to create new member entry
			NewMember();

			//call method to clear user input from form
			ClearForm();

			//add book complete message
			MessageBox.Show("New member process complete.");
		}


		private void NewMember()
		{
			//get user input for member id from text box
			string memberid = txtBoxMemberIdInput.Text;

			//get user input for first name from text box
			string first = txtboxFirstInput.Text;

			//get user input for last name from text box
			string last = txtboxLastInput.Text;

			//get user input for address from text box
			string address = txtboxAddressInput.Text;

			//get user input for city
			string city = txtboxCityInput.Text;

			//get user input for state
			string state = txtboxStateInput.Text;

			//get user input for zip
			string zip = txtboxZipcodeInput.Text;

			//get user input for phone
			string phone = txtboxPhoneInput.Text;

			//get user input for email
			string email = txtboxEmailInput.Text;

			//create memberdata object
			MemberData member = new MemberData(memberid, first, last, address, city, state, zip, phone, email);//create new bookdata object with information

			//store member object
			member.AddMember(member);
		}


		private void ClearForm()
		{

			//clear memberid text box of user input
			txtBoxMemberIdInput.Text = " ";

			//clear first name text box of user input
			txtboxFirstInput.Text = " ";

			//clear last name text box of user input
			txtboxLastInput.Text = " ";

			//clear address text box of user input
			txtboxAddressInput.Text = " ";

			//clear city text box of user input
			txtboxCityInput.Text = " ";

			//clear state text box of user input
			txtboxStateInput.Text = " ";

			//clear zip text box of user input
			txtboxZipcodeInput.Text = " ";

			//clear phone text box of user input
			txtboxPhoneInput.Text = " ";

			//clear email text box of user input
			txtboxEmailInput.Text = " ";


		}
	}
}
