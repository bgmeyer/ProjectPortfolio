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
	public partial class EquipmentForm : Form
	{
		public EquipmentForm()
		{
			InitializeComponent();
		}

		private void EquipmentForm_Load(object sender, EventArgs e)
		{
			LibraryDataContext db = new LibraryDataContext();//create data context object
			var results = from equip in db.Equipments//query to get equipment model to populate combo box
						  select equip.MODEL;
			foreach (var equip in results)
			{
				cboxEquipModel.Items.Add(equip);//populate combo box
			}

		}

		private void btnGo_Click(object sender, EventArgs e)
		{
			if (cboxEquipModel.SelectedIndex == -1)
			{
				MessageBox.Show("Error! Please select a model to view information about.");//error message for nothing selected
			}
			else
			{

				string equipModel = Convert.ToString(cboxEquipModel.SelectedItem);//get selected model to variable

				//get make to output label
				GetMake(equipModel);//call method to get make

				//get isbn to output label
				GetIsbn(equipModel);//call method to get isbn

				//get model to output label
				GetModel(equipModel);//call method to get model

				//get year to output label
				GetYear(equipModel);//call method to get year

				//get os to output label
				GetOs(equipModel);//call method to get os

				//get memory to output label
				GetMemory(equipModel);//call method to get memory

			}

		}


		public void GetMemory(string model)//method to query memory
		{
			LibraryDataContext db = new LibraryDataContext();

			var results = from equip in db.Equipments
						  where equip.MODEL.Contains(model)
						  select equip.MEMORY;

			//assign results of query to controls
			foreach (var result in results)
			{
				lblMemoryOutput.Text = result.ToString();
			}
		}

		public void GetOs(string model)//method to query os
		{
			LibraryDataContext db = new LibraryDataContext();

			var results = from equip in db.Equipments
						  where equip.MODEL.Contains(model)
						  select equip.OS;

			//assign results of query to controls
			foreach (var result in results)
			{
				lblOSOutput.Text = result.ToString();
			}
		}

		public void GetYear(string model)//method to query year
		{
			LibraryDataContext db = new LibraryDataContext();

			var results = from equip in db.Equipments
						  where equip.MODEL.Contains(model)
						  select equip.YEAR;

			//assign results of query to controls
			foreach (var result in results)
			{
				lblYearOutput.Text = result.ToString();
			}
		}

		public void GetModel(string model)//method to query model
		{
			LibraryDataContext db = new LibraryDataContext();

			var results = from equip in db.Equipments
						  where equip.MODEL.Contains(model)
						  select equip.MODEL;

			//assign results of query to controls
			foreach (var result in results)
			{
				lblModelOutput.Text = result.ToString();
			}
		}

		public void GetMake(string model)//method to query make
		{
			LibraryDataContext db = new LibraryDataContext();

			var results = from equip in db.Equipments
						  where equip.MODEL.Contains(model)
						  select equip.MAKE;

			//assign results of query to controls
			foreach (var result in results)
			{
				lblMakeOutput.Text = result.ToString();
			}
		}

		public void GetIsbn(string model)//method to query isbn
		{
			LibraryDataContext db = new LibraryDataContext();

			var results = from equip in db.Equipments
						  where equip.MODEL.Contains(model)
						  select equip.ISBN;

			//assign results of query to controls
			foreach (var result in results)
			{
				lblIsbnOutput.Text = result.ToString();
			}
		}

		private void btnNewEquipment_Click(object sender, EventArgs e)
		{
			//create new add equipment form object
			AddEquipment equipment = new AddEquipment();

			//show new equipment form object
			equipment.Show();

			//clear lbls
			Clear();
		}

		private void Clear()
		{
			//clear isbn lbl of input
			lblIsbnOutput.Text = " ";

			//clear make lbl of input
			lblMakeOutput.Text = " ";

			//clear model lbl of input
			lblModelOutput.Text = " ";

			//clear year lbl of input
			lblYearOutput.Text = " ";

			//clear os lbl of input
			lblOSOutput.Text = " ";

			//clear memory lbl of input
			lblMemoryOutput.Text = " ";
		}
	}
}
