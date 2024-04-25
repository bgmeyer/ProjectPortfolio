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
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		//creating the form objects
		public BooksForm frmBooks = new BooksForm();
		public CDsForm frmCDs = new CDsForm();
		public DVDsForm frmDVDs = new DVDsForm();
		public EquipmentForm frmEquipment = new EquipmentForm();
		public CheckOutForm frmCheckOut = new CheckOutForm();
		public CheckInForm frmCheckIn = new CheckInForm();
		public MembersForm frmMembers = new MembersForm();

		public void Load_Form(object form)
		{
			//Allows all the forms to be loaded into the main panel. Call the method and pass the form.
			if (this.pnlDisplayForm.Controls.Count > 0)
			{
				this.pnlDisplayForm.Controls.RemoveAt(0);
			}
			Form f = form as Form;
			f.TopLevel = false;
			f.Dock = DockStyle.Fill;
			this.pnlDisplayForm.Controls.Add(f);
			this.pnlDisplayForm.Tag = f;
			f.Show();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			Load_Form(frmBooks);//load books form on initial load
		}

		private void btnFormBooks_Click(object sender, EventArgs e)
		{
			Load_Form(frmBooks);//load books form when pressed
		}

		private void btnFormCDs_Click(object sender, EventArgs e)
		{
			Load_Form(frmCDs);//load cd form when pressed
		}

		private void btnFormDVDs_Click(object sender, EventArgs e)
		{
			Load_Form(frmDVDs);//load dvd form when pressed
		}

		private void btnFormEquipment_Click(object sender, EventArgs e)
		{
			Load_Form(frmEquipment);//load equipment form when pressed
		}

		private void btnFormCheckOut_Click(object sender, EventArgs e)
		{
			Load_Form(frmCheckOut);//load check out form when pressed
		}

		private void btnFormCheckIn_Click(object sender, EventArgs e)
		{
			Load_Form(frmCheckIn);//load check in form when pressed
		}

		private void btnFormMembers_Click(object sender, EventArgs e)
		{
			Load_Form(frmMembers);//load members form when pressed
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();//close application
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();//close application
		}
	}
}
