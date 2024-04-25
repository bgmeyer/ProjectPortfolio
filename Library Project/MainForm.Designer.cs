
namespace BroecklynneMeyer_CPT_206_Library
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pnlHeader = new System.Windows.Forms.Panel();
			this.lblFormTitle = new System.Windows.Forms.Label();
			this.picLogo = new System.Windows.Forms.PictureBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.pnlNavBar = new System.Windows.Forms.Panel();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnFormMembers = new System.Windows.Forms.Button();
			this.btnFormCheckIn = new System.Windows.Forms.Button();
			this.btnFormCheckOut = new System.Windows.Forms.Button();
			this.btnFormEquipment = new System.Windows.Forms.Button();
			this.btnFormDVDs = new System.Windows.Forms.Button();
			this.btnFormCDs = new System.Windows.Forms.Button();
			this.btnFormBooks = new System.Windows.Forms.Button();
			this.pnlDisplayForm = new System.Windows.Forms.Panel();
			this.pnlHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
			this.pnlNavBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlHeader
			// 
			this.pnlHeader.BackColor = System.Drawing.Color.Maroon;
			this.pnlHeader.Controls.Add(this.lblFormTitle);
			this.pnlHeader.Controls.Add(this.picLogo);
			this.pnlHeader.Controls.Add(this.btnClose);
			this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlHeader.Location = new System.Drawing.Point(0, 0);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new System.Drawing.Size(1251, 58);
			this.pnlHeader.TabIndex = 0;
			// 
			// lblFormTitle
			// 
			this.lblFormTitle.AutoSize = true;
			this.lblFormTitle.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFormTitle.ForeColor = System.Drawing.Color.Cornsilk;
			this.lblFormTitle.Location = new System.Drawing.Point(74, 16);
			this.lblFormTitle.Name = "lblFormTitle";
			this.lblFormTitle.Size = new System.Drawing.Size(209, 23);
			this.lblFormTitle.TabIndex = 2;
			this.lblFormTitle.Text = "Calhoun Library System";
			// 
			// picLogo
			// 
			this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
			this.picLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("picLogo.InitialImage")));
			this.picLogo.Location = new System.Drawing.Point(10, 3);
			this.picLogo.Name = "picLogo";
			this.picLogo.Size = new System.Drawing.Size(53, 50);
			this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picLogo.TabIndex = 1;
			this.picLogo.TabStop = false;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.Transparent;
			this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Location = new System.Drawing.Point(1212, 3);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(36, 34);
			this.btnClose.TabIndex = 0;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// pnlNavBar
			// 
			this.pnlNavBar.BackColor = System.Drawing.Color.Maroon;
			this.pnlNavBar.Controls.Add(this.btnExit);
			this.pnlNavBar.Controls.Add(this.btnFormMembers);
			this.pnlNavBar.Controls.Add(this.btnFormCheckIn);
			this.pnlNavBar.Controls.Add(this.btnFormCheckOut);
			this.pnlNavBar.Controls.Add(this.btnFormEquipment);
			this.pnlNavBar.Controls.Add(this.btnFormDVDs);
			this.pnlNavBar.Controls.Add(this.btnFormCDs);
			this.pnlNavBar.Controls.Add(this.btnFormBooks);
			this.pnlNavBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlNavBar.Location = new System.Drawing.Point(0, 58);
			this.pnlNavBar.Name = "pnlNavBar";
			this.pnlNavBar.Size = new System.Drawing.Size(216, 590);
			this.pnlNavBar.TabIndex = 1;
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.DarkOrange;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.ForeColor = System.Drawing.Color.Cornsilk;
			this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
			this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExit.Location = new System.Drawing.Point(1, 533);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(216, 57);
			this.btnExit.TabIndex = 7;
			this.btnExit.Text = "            Exit";
			this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnFormMembers
			// 
			this.btnFormMembers.BackColor = System.Drawing.Color.DarkOrange;
			this.btnFormMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFormMembers.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFormMembers.ForeColor = System.Drawing.Color.Cornsilk;
			this.btnFormMembers.Image = ((System.Drawing.Image)(resources.GetObject("btnFormMembers.Image")));
			this.btnFormMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnFormMembers.Location = new System.Drawing.Point(1, 458);
			this.btnFormMembers.Name = "btnFormMembers";
			this.btnFormMembers.Size = new System.Drawing.Size(216, 57);
			this.btnFormMembers.TabIndex = 6;
			this.btnFormMembers.Text = "            Members";
			this.btnFormMembers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFormMembers.UseVisualStyleBackColor = false;
			this.btnFormMembers.Click += new System.EventHandler(this.btnFormMembers_Click);
			// 
			// btnFormCheckIn
			// 
			this.btnFormCheckIn.BackColor = System.Drawing.Color.DarkOrange;
			this.btnFormCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFormCheckIn.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFormCheckIn.ForeColor = System.Drawing.Color.Cornsilk;
			this.btnFormCheckIn.Image = ((System.Drawing.Image)(resources.GetObject("btnFormCheckIn.Image")));
			this.btnFormCheckIn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnFormCheckIn.Location = new System.Drawing.Point(1, 384);
			this.btnFormCheckIn.Name = "btnFormCheckIn";
			this.btnFormCheckIn.Size = new System.Drawing.Size(216, 57);
			this.btnFormCheckIn.TabIndex = 5;
			this.btnFormCheckIn.Text = "            Check In";
			this.btnFormCheckIn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnFormCheckIn.UseVisualStyleBackColor = false;
			this.btnFormCheckIn.Click += new System.EventHandler(this.btnFormCheckIn_Click);
			// 
			// btnFormCheckOut
			// 
			this.btnFormCheckOut.BackColor = System.Drawing.Color.DarkOrange;
			this.btnFormCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFormCheckOut.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFormCheckOut.ForeColor = System.Drawing.Color.Cornsilk;
			this.btnFormCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("btnFormCheckOut.Image")));
			this.btnFormCheckOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnFormCheckOut.Location = new System.Drawing.Point(1, 310);
			this.btnFormCheckOut.Name = "btnFormCheckOut";
			this.btnFormCheckOut.Size = new System.Drawing.Size(216, 57);
			this.btnFormCheckOut.TabIndex = 4;
			this.btnFormCheckOut.Text = "            Check Out";
			this.btnFormCheckOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFormCheckOut.UseVisualStyleBackColor = false;
			this.btnFormCheckOut.Click += new System.EventHandler(this.btnFormCheckOut_Click);
			// 
			// btnFormEquipment
			// 
			this.btnFormEquipment.BackColor = System.Drawing.Color.DarkOrange;
			this.btnFormEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFormEquipment.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFormEquipment.ForeColor = System.Drawing.Color.Cornsilk;
			this.btnFormEquipment.Image = ((System.Drawing.Image)(resources.GetObject("btnFormEquipment.Image")));
			this.btnFormEquipment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnFormEquipment.Location = new System.Drawing.Point(1, 236);
			this.btnFormEquipment.Name = "btnFormEquipment";
			this.btnFormEquipment.Size = new System.Drawing.Size(216, 57);
			this.btnFormEquipment.TabIndex = 3;
			this.btnFormEquipment.Text = "           Equipment";
			this.btnFormEquipment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFormEquipment.UseVisualStyleBackColor = false;
			this.btnFormEquipment.Click += new System.EventHandler(this.btnFormEquipment_Click);
			// 
			// btnFormDVDs
			// 
			this.btnFormDVDs.BackColor = System.Drawing.Color.DarkOrange;
			this.btnFormDVDs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFormDVDs.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFormDVDs.ForeColor = System.Drawing.Color.Cornsilk;
			this.btnFormDVDs.Image = ((System.Drawing.Image)(resources.GetObject("btnFormDVDs.Image")));
			this.btnFormDVDs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnFormDVDs.Location = new System.Drawing.Point(1, 162);
			this.btnFormDVDs.Name = "btnFormDVDs";
			this.btnFormDVDs.Size = new System.Drawing.Size(216, 57);
			this.btnFormDVDs.TabIndex = 2;
			this.btnFormDVDs.Text = "            DVDs";
			this.btnFormDVDs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFormDVDs.UseVisualStyleBackColor = false;
			this.btnFormDVDs.Click += new System.EventHandler(this.btnFormDVDs_Click);
			// 
			// btnFormCDs
			// 
			this.btnFormCDs.BackColor = System.Drawing.Color.DarkOrange;
			this.btnFormCDs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFormCDs.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFormCDs.ForeColor = System.Drawing.Color.Cornsilk;
			this.btnFormCDs.Image = ((System.Drawing.Image)(resources.GetObject("btnFormCDs.Image")));
			this.btnFormCDs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnFormCDs.Location = new System.Drawing.Point(1, 86);
			this.btnFormCDs.Name = "btnFormCDs";
			this.btnFormCDs.Size = new System.Drawing.Size(216, 57);
			this.btnFormCDs.TabIndex = 1;
			this.btnFormCDs.Text = "            CDs";
			this.btnFormCDs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFormCDs.UseVisualStyleBackColor = false;
			this.btnFormCDs.Click += new System.EventHandler(this.btnFormCDs_Click);
			// 
			// btnFormBooks
			// 
			this.btnFormBooks.BackColor = System.Drawing.Color.DarkOrange;
			this.btnFormBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFormBooks.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFormBooks.ForeColor = System.Drawing.Color.Cornsilk;
			this.btnFormBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnFormBooks.Image")));
			this.btnFormBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnFormBooks.Location = new System.Drawing.Point(1, 9);
			this.btnFormBooks.Name = "btnFormBooks";
			this.btnFormBooks.Size = new System.Drawing.Size(216, 57);
			this.btnFormBooks.TabIndex = 0;
			this.btnFormBooks.Text = "            Books";
			this.btnFormBooks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnFormBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFormBooks.UseVisualStyleBackColor = false;
			this.btnFormBooks.Click += new System.EventHandler(this.btnFormBooks_Click);
			// 
			// pnlDisplayForm
			// 
			this.pnlDisplayForm.BackColor = System.Drawing.Color.White;
			this.pnlDisplayForm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlDisplayForm.Location = new System.Drawing.Point(216, 58);
			this.pnlDisplayForm.Name = "pnlDisplayForm";
			this.pnlDisplayForm.Size = new System.Drawing.Size(1035, 590);
			this.pnlDisplayForm.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1251, 648);
			this.Controls.Add(this.pnlDisplayForm);
			this.Controls.Add(this.pnlNavBar);
			this.Controls.Add(this.pnlHeader);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.pnlHeader.ResumeLayout(false);
			this.pnlHeader.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
			this.pnlNavBar.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlHeader;
		private System.Windows.Forms.Label lblFormTitle;
		private System.Windows.Forms.PictureBox picLogo;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Panel pnlNavBar;
		private System.Windows.Forms.Button btnFormCDs;
		private System.Windows.Forms.Button btnFormBooks;
		private System.Windows.Forms.Panel pnlDisplayForm;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnFormMembers;
		private System.Windows.Forms.Button btnFormCheckIn;
		private System.Windows.Forms.Button btnFormCheckOut;
		private System.Windows.Forms.Button btnFormEquipment;
		private System.Windows.Forms.Button btnFormDVDs;
	}
}

