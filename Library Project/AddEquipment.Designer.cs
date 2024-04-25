
namespace BroecklynneMeyer_CPT_206_Library
{
	partial class AddEquipment
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEquipment));
			this.pnlHeader = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.lblFormTitle = new System.Windows.Forms.Label();
			this.picFormIcon = new System.Windows.Forms.PictureBox();
			this.grpboxDVD = new System.Windows.Forms.GroupBox();
			this.lblModel = new System.Windows.Forms.Label();
			this.lblOS = new System.Windows.Forms.Label();
			this.lblMemory = new System.Windows.Forms.Label();
			this.lblYear = new System.Windows.Forms.Label();
			this.lblISBN = new System.Windows.Forms.Label();
			this.lblMake = new System.Windows.Forms.Label();
			this.btnSaveEquipment = new System.Windows.Forms.Button();
			this.txtboxIsbnInput = new System.Windows.Forms.TextBox();
			this.txtboxMakeInput = new System.Windows.Forms.TextBox();
			this.txtboxModelInput = new System.Windows.Forms.TextBox();
			this.txtboxYearInput = new System.Windows.Forms.TextBox();
			this.txtboxOsInput = new System.Windows.Forms.TextBox();
			this.txtboxMemoryInput = new System.Windows.Forms.TextBox();
			this.pnlHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picFormIcon)).BeginInit();
			this.grpboxDVD.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlHeader
			// 
			this.pnlHeader.BackColor = System.Drawing.Color.Maroon;
			this.pnlHeader.Controls.Add(this.btnClose);
			this.pnlHeader.Controls.Add(this.lblFormTitle);
			this.pnlHeader.Controls.Add(this.picFormIcon);
			this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlHeader.Location = new System.Drawing.Point(0, 0);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new System.Drawing.Size(1003, 52);
			this.pnlHeader.TabIndex = 4;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.Transparent;
			this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Location = new System.Drawing.Point(955, 8);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(36, 34);
			this.btnClose.TabIndex = 4;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// lblFormTitle
			// 
			this.lblFormTitle.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFormTitle.ForeColor = System.Drawing.Color.Cornsilk;
			this.lblFormTitle.Location = new System.Drawing.Point(67, 8);
			this.lblFormTitle.Name = "lblFormTitle";
			this.lblFormTitle.Size = new System.Drawing.Size(148, 41);
			this.lblFormTitle.TabIndex = 1;
			this.lblFormTitle.Text = "Add Equipment";
			this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picFormIcon
			// 
			this.picFormIcon.Image = ((System.Drawing.Image)(resources.GetObject("picFormIcon.Image")));
			this.picFormIcon.Location = new System.Drawing.Point(3, 4);
			this.picFormIcon.Name = "picFormIcon";
			this.picFormIcon.Size = new System.Drawing.Size(58, 44);
			this.picFormIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picFormIcon.TabIndex = 0;
			this.picFormIcon.TabStop = false;
			// 
			// grpboxDVD
			// 
			this.grpboxDVD.Controls.Add(this.txtboxMemoryInput);
			this.grpboxDVD.Controls.Add(this.txtboxOsInput);
			this.grpboxDVD.Controls.Add(this.txtboxYearInput);
			this.grpboxDVD.Controls.Add(this.txtboxModelInput);
			this.grpboxDVD.Controls.Add(this.txtboxMakeInput);
			this.grpboxDVD.Controls.Add(this.txtboxIsbnInput);
			this.grpboxDVD.Controls.Add(this.lblModel);
			this.grpboxDVD.Controls.Add(this.lblOS);
			this.grpboxDVD.Controls.Add(this.lblMemory);
			this.grpboxDVD.Controls.Add(this.lblYear);
			this.grpboxDVD.Controls.Add(this.lblISBN);
			this.grpboxDVD.Controls.Add(this.lblMake);
			this.grpboxDVD.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpboxDVD.Location = new System.Drawing.Point(112, 82);
			this.grpboxDVD.Name = "grpboxDVD";
			this.grpboxDVD.Size = new System.Drawing.Size(778, 364);
			this.grpboxDVD.TabIndex = 9;
			this.grpboxDVD.TabStop = false;
			this.grpboxDVD.Text = "Equipment Info";
			// 
			// lblModel
			// 
			this.lblModel.AutoSize = true;
			this.lblModel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblModel.Location = new System.Drawing.Point(159, 161);
			this.lblModel.Name = "lblModel";
			this.lblModel.Size = new System.Drawing.Size(73, 23);
			this.lblModel.TabIndex = 10;
			this.lblModel.Text = "Model: ";
			// 
			// lblOS
			// 
			this.lblOS.AutoSize = true;
			this.lblOS.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOS.Location = new System.Drawing.Point(183, 267);
			this.lblOS.Name = "lblOS";
			this.lblOS.Size = new System.Drawing.Size(41, 23);
			this.lblOS.TabIndex = 8;
			this.lblOS.Text = "OS:";
			// 
			// lblMemory
			// 
			this.lblMemory.AutoSize = true;
			this.lblMemory.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMemory.Location = new System.Drawing.Point(138, 315);
			this.lblMemory.Name = "lblMemory";
			this.lblMemory.Size = new System.Drawing.Size(86, 23);
			this.lblMemory.TabIndex = 6;
			this.lblMemory.Text = "Memory:";
			// 
			// lblYear
			// 
			this.lblYear.AutoSize = true;
			this.lblYear.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblYear.Location = new System.Drawing.Point(170, 216);
			this.lblYear.Name = "lblYear";
			this.lblYear.Size = new System.Drawing.Size(58, 23);
			this.lblYear.TabIndex = 4;
			this.lblYear.Text = "Year: ";
			// 
			// lblISBN
			// 
			this.lblISBN.AutoSize = true;
			this.lblISBN.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblISBN.Location = new System.Drawing.Point(170, 56);
			this.lblISBN.Name = "lblISBN";
			this.lblISBN.Size = new System.Drawing.Size(58, 23);
			this.lblISBN.TabIndex = 2;
			this.lblISBN.Text = "ISBN:";
			// 
			// lblMake
			// 
			this.lblMake.AutoSize = true;
			this.lblMake.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMake.Location = new System.Drawing.Point(166, 109);
			this.lblMake.Name = "lblMake";
			this.lblMake.Size = new System.Drawing.Size(66, 23);
			this.lblMake.TabIndex = 0;
			this.lblMake.Text = "Make: ";
			// 
			// btnSaveEquipment
			// 
			this.btnSaveEquipment.BackColor = System.Drawing.Color.Maroon;
			this.btnSaveEquipment.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveEquipment.ForeColor = System.Drawing.Color.Cornsilk;
			this.btnSaveEquipment.Location = new System.Drawing.Point(702, 452);
			this.btnSaveEquipment.Name = "btnSaveEquipment";
			this.btnSaveEquipment.Size = new System.Drawing.Size(188, 43);
			this.btnSaveEquipment.TabIndex = 10;
			this.btnSaveEquipment.Text = "Save Equipment";
			this.btnSaveEquipment.UseVisualStyleBackColor = false;
			this.btnSaveEquipment.Click += new System.EventHandler(this.btnSaveEquipment_Click);
			// 
			// txtboxIsbnInput
			// 
			this.txtboxIsbnInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtboxIsbnInput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxIsbnInput.Location = new System.Drawing.Point(282, 50);
			this.txtboxIsbnInput.Name = "txtboxIsbnInput";
			this.txtboxIsbnInput.Size = new System.Drawing.Size(309, 29);
			this.txtboxIsbnInput.TabIndex = 12;
			// 
			// txtboxMakeInput
			// 
			this.txtboxMakeInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtboxMakeInput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxMakeInput.Location = new System.Drawing.Point(282, 103);
			this.txtboxMakeInput.Name = "txtboxMakeInput";
			this.txtboxMakeInput.Size = new System.Drawing.Size(309, 29);
			this.txtboxMakeInput.TabIndex = 13;
			// 
			// txtboxModelInput
			// 
			this.txtboxModelInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtboxModelInput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxModelInput.Location = new System.Drawing.Point(282, 155);
			this.txtboxModelInput.Name = "txtboxModelInput";
			this.txtboxModelInput.Size = new System.Drawing.Size(309, 29);
			this.txtboxModelInput.TabIndex = 14;
			// 
			// txtboxYearInput
			// 
			this.txtboxYearInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtboxYearInput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxYearInput.Location = new System.Drawing.Point(282, 210);
			this.txtboxYearInput.Name = "txtboxYearInput";
			this.txtboxYearInput.Size = new System.Drawing.Size(309, 29);
			this.txtboxYearInput.TabIndex = 15;
			// 
			// txtboxOsInput
			// 
			this.txtboxOsInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtboxOsInput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxOsInput.Location = new System.Drawing.Point(282, 261);
			this.txtboxOsInput.Name = "txtboxOsInput";
			this.txtboxOsInput.Size = new System.Drawing.Size(309, 29);
			this.txtboxOsInput.TabIndex = 16;
			// 
			// txtboxMemoryInput
			// 
			this.txtboxMemoryInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtboxMemoryInput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxMemoryInput.Location = new System.Drawing.Point(282, 309);
			this.txtboxMemoryInput.Name = "txtboxMemoryInput";
			this.txtboxMemoryInput.Size = new System.Drawing.Size(309, 29);
			this.txtboxMemoryInput.TabIndex = 17;
			// 
			// AddEquipment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1003, 528);
			this.Controls.Add(this.btnSaveEquipment);
			this.Controls.Add(this.grpboxDVD);
			this.Controls.Add(this.pnlHeader);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AddEquipment";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddEquipment";
			this.pnlHeader.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picFormIcon)).EndInit();
			this.grpboxDVD.ResumeLayout(false);
			this.grpboxDVD.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlHeader;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label lblFormTitle;
		private System.Windows.Forms.PictureBox picFormIcon;
		private System.Windows.Forms.GroupBox grpboxDVD;
		private System.Windows.Forms.Label lblModel;
		private System.Windows.Forms.Label lblOS;
		private System.Windows.Forms.Label lblMemory;
		private System.Windows.Forms.Label lblYear;
		private System.Windows.Forms.Label lblISBN;
		private System.Windows.Forms.Label lblMake;
		private System.Windows.Forms.Button btnSaveEquipment;
		private System.Windows.Forms.TextBox txtboxMemoryInput;
		private System.Windows.Forms.TextBox txtboxOsInput;
		private System.Windows.Forms.TextBox txtboxYearInput;
		private System.Windows.Forms.TextBox txtboxModelInput;
		private System.Windows.Forms.TextBox txtboxMakeInput;
		private System.Windows.Forms.TextBox txtboxIsbnInput;
	}
}