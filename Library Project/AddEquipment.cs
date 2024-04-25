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
	public partial class AddEquipment : Form
	{
		public AddEquipment()
		{
			InitializeComponent();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{

			//close this form
			this.Close();

		}

		private void btnSaveEquipment_Click(object sender, EventArgs e)
		{
			//call method to create new equipment entry
			NewEquipment();

			//call method to clear user input from form
			ClearForm();

			//add book complete message
			MessageBox.Show("New equipment process complete.");
		}

		private void NewEquipment()
		{
			//get user input for make from text box
			string make = txtboxMakeInput.Text;

			//get user input for isbn from text box
			string isbn = txtboxIsbnInput.Text;

			//get user input for model from text box
			string model = txtboxModelInput.Text;

			//get user input for year from text box
			string year = txtboxYearInput.Text;

			//get user input for os
			string os = txtboxOsInput.Text;

			//get user input for memory
			string memory = txtboxMemoryInput.Text;

			//create check in object
			EquipmentData equipment = new EquipmentData(make, isbn, model, year, os, memory);//create new equipmentdata object with information

			//store equipment object
			equipment.AddEquipment(equipment);
		}


		private void ClearForm()
		{

			//clear make text box of user input
			txtboxMakeInput.Text = " ";

			//clear isbn text box of user input
			txtboxIsbnInput.Text = " ";

			//clear model text box of user input
			txtboxModelInput.Text = " ";

			//clear year published text box of user input
			txtboxYearInput.Text = " ";

			//clear os text box of user input
			txtboxOsInput.Text = " ";

			//clear memory text box of user input
			txtboxMemoryInput.Text = " ";


		}
	}
}
