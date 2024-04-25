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
	public partial class MembersForm : Form
	{

		public MembersForm()
		{
			InitializeComponent();
		}


		private void MembersForm_Load(object sender, EventArgs e)
		{
			LibraryDataContext db = new LibraryDataContext();//create data context object

			var results = from mem in db.Members//query to get book titles to populate combo box
						  select mem.MemberID;

			foreach (var mem in results)
			{
				cboxMemberID.Items.Add(mem);//populate combo box
			}

		}


		private void btnGo_Click(object sender, EventArgs e)
		{
			if (cboxMemberID.SelectedIndex == -1)
			{
				MessageBox.Show("Error! Please select a member ID to view information about.");//error message for nothing selected
			}
			else
			{

				string member = Convert.ToString(cboxMemberID.SelectedItem);//get selected member id to variable

				//get id to output label
				GetId(member);//call method to get id

				//get first name to output label
				GetFirstName(member);//call method to get first name

				//get last name to output label
				GetLastName(member);//call method to get last name

				//get address to output label
				GetAddress(member);//call method to get address

				//get city to output label
				GetCity(member);//call method to get city

				//get state to output label
				GetState(member);//call method to get state

				//get zipcode to output label
				GetZip(member);//call method to get zipcode

				//get phone number to output label
				GetPhone(member);//call method to get phone number

				//get email to output label
				GetEmail(member);//call method to get email address

			}
		}


		public void GetId(string member)//method to query member id
		{
			LibraryDataContext db = new LibraryDataContext();

			var results = from mem in db.Members
						  where mem.MemberID.Contains(member)
						  select mem.MemberID;

			//assign results of query to controls
			foreach (var result in results)
			{
				lblMemberIdOutput.Text = result.ToString();

				lblMemberIdOutput.Visible = true;
			}

		}


		public void GetFirstName(string member)//method to query first name
		{
			LibraryDataContext db = new LibraryDataContext();

			var results = from mem in db.Members
						  where mem.MemberID.Contains(member)
						  select mem.FirstName;

			//assign results of query to controls
			foreach (var result in results)
			{
				lblFirstOutput.Text = result.ToString();
			}
		}


		public void GetLastName(string member)//method to query last name
		{
			LibraryDataContext db = new LibraryDataContext();

			var results = from mem in db.Members
						  where mem.MemberID.Contains(member)
						  select mem.LastName;

			//assign results of query to controls
			foreach (var result in results)
			{
				lblLastOutput.Text = result.ToString();
			}
		}


		public void GetAddress(string member)//method to query address
		{
			LibraryDataContext db = new LibraryDataContext();

			var results = from mem in db.Members
						  where mem.MemberID.Contains(member)
						  select mem.Address;

			//assign results of query to controls
			foreach (var result in results)
			{
				lblAddressOutput.Text = result.ToString();
			}
		}


		public void GetCity(string member)//method to query member
		{
			LibraryDataContext db = new LibraryDataContext();

			var results = from mem in db.Members
						  where mem.MemberID.Contains(member)
						  select mem.City;

			//assign results of query to controls
			foreach (var result in results)
			{

				lblCityOutput.Text = result.ToString();

			}
		}


		public void GetState(string member)//method to query state
		{
			LibraryDataContext db = new LibraryDataContext();

			var results = from mem in db.Members
						  where mem.MemberID.Contains(member)
						  select mem.State;

			//assign results of query to controls
			foreach (var result in results)
			{
				lblStateOutput.Text = result.ToString();
			}
		}


		public void GetZip(string member)//method to query zipcode
		{
			LibraryDataContext db = new LibraryDataContext();

			var results = from mem in db.Members
						  where mem.MemberID.Contains(member)
						  select mem.ZipCode;

			//assign results of query to controls
			foreach (var result in results)
			{
				lblZipcodeOutput.Text = result.ToString();
			}
		}


		public void GetPhone(string member)//method to query phone number
		{
			LibraryDataContext db = new LibraryDataContext();

			var results = from mem in db.Members
						  where mem.MemberID.Contains(member)
						  select mem.Phone;

			//assign results of query to controls
			foreach (var result in results)
			{
				lblPhoneOutput.Text = result.ToString();
			}
		}


		public void GetEmail(string member)//method to query email
		{
			LibraryDataContext db = new LibraryDataContext();

			var results = from mem in db.Members
						  where mem.MemberID.Contains(member)
						  select mem.Email;

			//assign results of query to controls
			foreach (var result in results)
			{
				lblEmailOutput.Text = result.ToString();
			}
		}

		private void btnNewMember_Click(object sender, EventArgs e)
		{

			//create new add member form object
			AddMember frmAddMember = new AddMember();

			//show new form
			frmAddMember.Show();

			//clear lbls
			Clear();
		}

		private void Clear()
		{
			//clear memberid lbl of input
			lblMemberIdOutput.Text = " ";

			//clear first lbl of input
			lblFirstOutput.Text = " ";

			//clear Last lbl of input
			lblLastOutput.Text = " ";

			//clear Address lbl of input
			lblAddressOutput.Text = " ";

			//clear City lbl of input
			lblCityOutput.Text = " ";

			//clear State lbl of input
			lblStateOutput.Text = " ";

			//clear zip lbl of input
			lblZipcodeOutput.Text = " ";

			//clear phone lbl of input
			lblPhoneOutput.Text = " ";

			//clear email lbl of input
			lblEmailOutput.Text = " ";
		}
	}
}
