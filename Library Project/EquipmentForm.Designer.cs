
namespace BroecklynneMeyer_CPT_206_Library
{
	partial class EquipmentForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipmentForm));
			this.pnlHeader = new System.Windows.Forms.Panel();
			this.lblFormTitle = new System.Windows.Forms.Label();
			this.picFormIcon = new System.Windows.Forms.PictureBox();
			this.lblSelectModel = new System.Windows.Forms.Label();
			this.cboxEquipModel = new System.Windows.Forms.ComboBox();
			this.picboxUsingLaptop = new System.Windows.Forms.PictureBox();
			this.picboxChoosing = new System.Windows.Forms.PictureBox();
			this.picboxLaptop = new System.Windows.Forms.PictureBox();
			this.grpboxDVD = new System.Windows.Forms.GroupBox();
			this.lblModelOutput = new System.Windows.Forms.Label();
			this.lblModel = new System.Windows.Forms.Label();
			this.lblOSOutput = new System.Windows.Forms.Label();
			this.lblOS = new System.Windows.Forms.Label();
			this.lblMemoryOutput = new System.Windows.Forms.Label();
			this.lblMemory = new System.Windows.Forms.Label();
			this.lblYearOutput = new System.Windows.Forms.Label();
			this.lblYear = new System.Windows.Forms.Label();
			this.lblIsbnOutput = new System.Windows.Forms.Label();
			this.lblISBN = new System.Windows.Forms.Label();
			this.lblMakeOutput = new System.Windows.Forms.Label();
			this.lblMake = new System.Windows.Forms.Label();
			this.btnNewEquipment = new System.Windows.Forms.Button();
			this.btnGo = new System.Windows.Forms.Button();
			this.pnlHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picFormIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picboxUsingLaptop)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picboxChoosing)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picboxLaptop)).BeginInit();
			this.grpboxDVD.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlHeader
			// 
			this.pnlHeader.BackColor = System.Drawing.Color.Maroon;
			this.pnlHeader.Controls.Add(this.lblFormTitle);
			this.pnlHeader.Controls.Add(this.picFormIcon);
			this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlHeader.Location = new System.Drawing.Point(0, 0);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new System.Drawing.Size(1035, 52);
			this.pnlHeader.TabIndex = 1;
			// 
			// lblFormTitle
			// 
			this.lblFormTitle.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFormTitle.ForeColor = System.Drawing.Color.Cornsilk;
			this.lblFormTitle.Location = new System.Drawing.Point(67, 8);
			this.lblFormTitle.Name = "lblFormTitle";
			this.lblFormTitle.Size = new System.Drawing.Size(117, 41);
			this.lblFormTitle.TabIndex = 1;
			this.lblFormTitle.Text = "Equipment";
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
			// lblSelectModel
			// 
			this.lblSelectModel.AutoSize = true;
			this.lblSelectModel.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSelectModel.Location = new System.Drawing.Point(554, 76);
			this.lblSelectModel.Name = "lblSelectModel";
			this.lblSelectModel.Size = new System.Drawing.Size(306, 19);
			this.lblSelectModel.TabIndex = 2;
			this.lblSelectModel.Text = "Select a model for Equipment information: ";
			// 
			// cboxEquipModel
			// 
			this.cboxEquipModel.DropDownWidth = 385;
			this.cboxEquipModel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboxEquipModel.FormattingEnabled = true;
			this.cboxEquipModel.Location = new System.Drawing.Point(558, 98);
			this.cboxEquipModel.Name = "cboxEquipModel";
			this.cboxEquipModel.Size = new System.Drawing.Size(385, 22);
			this.cboxEquipModel.TabIndex = 3;
			// 
			// picboxUsingLaptop
			// 
			this.picboxUsingLaptop.Image = ((System.Drawing.Image)(resources.GetObject("picboxUsingLaptop.Image")));
			this.picboxUsingLaptop.Location = new System.Drawing.Point(834, 140);
			this.picboxUsingLaptop.Name = "picboxUsingLaptop";
			this.picboxUsingLaptop.Size = new System.Drawing.Size(161, 134);
			this.picboxUsingLaptop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picboxUsingLaptop.TabIndex = 4;
			this.picboxUsingLaptop.TabStop = false;
			// 
			// picboxChoosing
			// 
			this.picboxChoosing.Image = ((System.Drawing.Image)(resources.GetObject("picboxChoosing.Image")));
			this.picboxChoosing.Location = new System.Drawing.Point(834, 290);
			this.picboxChoosing.Name = "picboxChoosing";
			this.picboxChoosing.Size = new System.Drawing.Size(161, 134);
			this.picboxChoosing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picboxChoosing.TabIndex = 5;
			this.picboxChoosing.TabStop = false;
			// 
			// picboxLaptop
			// 
			this.picboxLaptop.Image = ((System.Drawing.Image)(resources.GetObject("picboxLaptop.Image")));
			this.picboxLaptop.Location = new System.Drawing.Point(834, 442);
			this.picboxLaptop.Name = "picboxLaptop";
			this.picboxLaptop.Size = new System.Drawing.Size(161, 134);
			this.picboxLaptop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picboxLaptop.TabIndex = 6;
			this.picboxLaptop.TabStop = false;
			// 
			// grpboxDVD
			// 
			this.grpboxDVD.Controls.Add(this.lblModelOutput);
			this.grpboxDVD.Controls.Add(this.lblModel);
			this.grpboxDVD.Controls.Add(this.lblOSOutput);
			this.grpboxDVD.Controls.Add(this.lblOS);
			this.grpboxDVD.Controls.Add(this.lblMemoryOutput);
			this.grpboxDVD.Controls.Add(this.lblMemory);
			this.grpboxDVD.Controls.Add(this.lblYearOutput);
			this.grpboxDVD.Controls.Add(this.lblYear);
			this.grpboxDVD.Controls.Add(this.lblIsbnOutput);
			this.grpboxDVD.Controls.Add(this.lblISBN);
			this.grpboxDVD.Controls.Add(this.lblMakeOutput);
			this.grpboxDVD.Controls.Add(this.lblMake);
			this.grpboxDVD.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpboxDVD.Location = new System.Drawing.Point(30, 140);
			this.grpboxDVD.Name = "grpboxDVD";
			this.grpboxDVD.Size = new System.Drawing.Size(778, 364);
			this.grpboxDVD.TabIndex = 8;
			this.grpboxDVD.TabStop = false;
			this.grpboxDVD.Text = "Equipment Info";
			// 
			// lblModelOutput
			// 
			this.lblModelOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblModelOutput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblModelOutput.Location = new System.Drawing.Point(282, 154);
			this.lblModelOutput.Name = "lblModelOutput";
			this.lblModelOutput.Size = new System.Drawing.Size(309, 30);
			this.lblModelOutput.TabIndex = 11;
			this.lblModelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			// lblOSOutput
			// 
			this.lblOSOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblOSOutput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOSOutput.Location = new System.Drawing.Point(282, 260);
			this.lblOSOutput.Name = "lblOSOutput";
			this.lblOSOutput.Size = new System.Drawing.Size(309, 30);
			this.lblOSOutput.TabIndex = 9;
			this.lblOSOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			// lblMemoryOutput
			// 
			this.lblMemoryOutput.AutoEllipsis = true;
			this.lblMemoryOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblMemoryOutput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMemoryOutput.Location = new System.Drawing.Point(282, 308);
			this.lblMemoryOutput.Name = "lblMemoryOutput";
			this.lblMemoryOutput.Size = new System.Drawing.Size(309, 30);
			this.lblMemoryOutput.TabIndex = 7;
			this.lblMemoryOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			// lblYearOutput
			// 
			this.lblYearOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblYearOutput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblYearOutput.Location = new System.Drawing.Point(282, 209);
			this.lblYearOutput.Name = "lblYearOutput";
			this.lblYearOutput.Size = new System.Drawing.Size(309, 30);
			this.lblYearOutput.TabIndex = 5;
			this.lblYearOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			// lblIsbnOutput
			// 
			this.lblIsbnOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblIsbnOutput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIsbnOutput.Location = new System.Drawing.Point(282, 49);
			this.lblIsbnOutput.Name = "lblIsbnOutput";
			this.lblIsbnOutput.Size = new System.Drawing.Size(309, 30);
			this.lblIsbnOutput.TabIndex = 3;
			this.lblIsbnOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			// lblMakeOutput
			// 
			this.lblMakeOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblMakeOutput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMakeOutput.Location = new System.Drawing.Point(282, 102);
			this.lblMakeOutput.Name = "lblMakeOutput";
			this.lblMakeOutput.Size = new System.Drawing.Size(309, 30);
			this.lblMakeOutput.TabIndex = 1;
			this.lblMakeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			// btnNewEquipment
			// 
			this.btnNewEquipment.BackColor = System.Drawing.Color.Maroon;
			this.btnNewEquipment.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNewEquipment.ForeColor = System.Drawing.Color.Cornsilk;
			this.btnNewEquipment.Location = new System.Drawing.Point(30, 533);
			this.btnNewEquipment.Name = "btnNewEquipment";
			this.btnNewEquipment.Size = new System.Drawing.Size(188, 43);
			this.btnNewEquipment.TabIndex = 9;
			this.btnNewEquipment.Text = "Add New Equipment";
			this.btnNewEquipment.UseVisualStyleBackColor = false;
			this.btnNewEquipment.Click += new System.EventHandler(this.btnNewEquipment_Click);
			// 
			// btnGo
			// 
			this.btnGo.BackColor = System.Drawing.Color.Maroon;
			this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGo.ForeColor = System.Drawing.Color.Cornsilk;
			this.btnGo.Location = new System.Drawing.Point(955, 98);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(56, 23);
			this.btnGo.TabIndex = 10;
			this.btnGo.Text = "Go";
			this.btnGo.UseVisualStyleBackColor = false;
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// EquipmentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1035, 606);
			this.Controls.Add(this.btnGo);
			this.Controls.Add(this.btnNewEquipment);
			this.Controls.Add(this.grpboxDVD);
			this.Controls.Add(this.picboxLaptop);
			this.Controls.Add(this.picboxChoosing);
			this.Controls.Add(this.picboxUsingLaptop);
			this.Controls.Add(this.cboxEquipModel);
			this.Controls.Add(this.lblSelectModel);
			this.Controls.Add(this.pnlHeader);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "EquipmentForm";
			this.Text = "EquipmentForm";
			this.Load += new System.EventHandler(this.EquipmentForm_Load);
			this.pnlHeader.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picFormIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picboxUsingLaptop)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picboxChoosing)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picboxLaptop)).EndInit();
			this.grpboxDVD.ResumeLayout(false);
			this.grpboxDVD.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlHeader;
		private System.Windows.Forms.Label lblFormTitle;
		private System.Windows.Forms.PictureBox picFormIcon;
		private System.Windows.Forms.Label lblSelectModel;
		private System.Windows.Forms.ComboBox cboxEquipModel;
		private System.Windows.Forms.PictureBox picboxUsingLaptop;
		private System.Windows.Forms.PictureBox picboxChoosing;
		private System.Windows.Forms.PictureBox picboxLaptop;
		private System.Windows.Forms.GroupBox grpboxDVD;
		private System.Windows.Forms.Label lblModelOutput;
		private System.Windows.Forms.Label lblModel;
		private System.Windows.Forms.Label lblOSOutput;
		private System.Windows.Forms.Label lblOS;
		private System.Windows.Forms.Label lblMemoryOutput;
		private System.Windows.Forms.Label lblMemory;
		private System.Windows.Forms.Label lblYearOutput;
		private System.Windows.Forms.Label lblYear;
		private System.Windows.Forms.Label lblIsbnOutput;
		private System.Windows.Forms.Label lblISBN;
		private System.Windows.Forms.Label lblMakeOutput;
		private System.Windows.Forms.Label lblMake;
		private System.Windows.Forms.Button btnNewEquipment;
		private System.Windows.Forms.Button btnGo;
	}
}