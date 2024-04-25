
namespace BroecklynneMeyer_CPT_206_Library
{
	partial class CheckInForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckInForm));
			this.pnlHeader = new System.Windows.Forms.Panel();
			this.lblFormTitle = new System.Windows.Forms.Label();
			this.picFormIcon = new System.Windows.Forms.PictureBox();
			this.grpboxCheckIn = new System.Windows.Forms.GroupBox();
			this.picBoxLibrarian = new System.Windows.Forms.PictureBox();
			this.btnCheckIn = new System.Windows.Forms.Button();
			this.txtBoxDate = new System.Windows.Forms.TextBox();
			this.lblDate = new System.Windows.Forms.Label();
			this.txtBoxISBN = new System.Windows.Forms.TextBox();
			this.lblISBN = new System.Windows.Forms.Label();
			this.txtBoxMemberID = new System.Windows.Forms.TextBox();
			this.lblMemberID = new System.Windows.Forms.Label();
			this.pnlHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picFormIcon)).BeginInit();
			this.grpboxCheckIn.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picBoxLibrarian)).BeginInit();
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
			this.pnlHeader.Size = new System.Drawing.Size(1019, 52);
			this.pnlHeader.TabIndex = 2;
			// 
			// lblFormTitle
			// 
			this.lblFormTitle.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFormTitle.ForeColor = System.Drawing.Color.Cornsilk;
			this.lblFormTitle.Location = new System.Drawing.Point(67, 8);
			this.lblFormTitle.Name = "lblFormTitle";
			this.lblFormTitle.Size = new System.Drawing.Size(117, 41);
			this.lblFormTitle.TabIndex = 1;
			this.lblFormTitle.Text = "Check In";
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
			// grpboxCheckIn
			// 
			this.grpboxCheckIn.Controls.Add(this.picBoxLibrarian);
			this.grpboxCheckIn.Controls.Add(this.btnCheckIn);
			this.grpboxCheckIn.Controls.Add(this.txtBoxDate);
			this.grpboxCheckIn.Controls.Add(this.lblDate);
			this.grpboxCheckIn.Controls.Add(this.txtBoxISBN);
			this.grpboxCheckIn.Controls.Add(this.lblISBN);
			this.grpboxCheckIn.Controls.Add(this.txtBoxMemberID);
			this.grpboxCheckIn.Controls.Add(this.lblMemberID);
			this.grpboxCheckIn.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpboxCheckIn.Location = new System.Drawing.Point(88, 105);
			this.grpboxCheckIn.Name = "grpboxCheckIn";
			this.grpboxCheckIn.Size = new System.Drawing.Size(844, 400);
			this.grpboxCheckIn.TabIndex = 3;
			this.grpboxCheckIn.TabStop = false;
			this.grpboxCheckIn.Text = "Enter Check In Information";
			// 
			// picBoxLibrarian
			// 
			this.picBoxLibrarian.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLibrarian.Image")));
			this.picBoxLibrarian.Location = new System.Drawing.Point(21, 169);
			this.picBoxLibrarian.Name = "picBoxLibrarian";
			this.picBoxLibrarian.Size = new System.Drawing.Size(273, 206);
			this.picBoxLibrarian.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picBoxLibrarian.TabIndex = 10;
			this.picBoxLibrarian.TabStop = false;
			// 
			// btnCheckIn
			// 
			this.btnCheckIn.BackColor = System.Drawing.Color.Maroon;
			this.btnCheckIn.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCheckIn.ForeColor = System.Drawing.Color.Cornsilk;
			this.btnCheckIn.Location = new System.Drawing.Point(554, 332);
			this.btnCheckIn.Name = "btnCheckIn";
			this.btnCheckIn.Size = new System.Drawing.Size(188, 43);
			this.btnCheckIn.TabIndex = 9;
			this.btnCheckIn.Text = "Check In";
			this.btnCheckIn.UseVisualStyleBackColor = false;
			this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
			// 
			// txtBoxDate
			// 
			this.txtBoxDate.Location = new System.Drawing.Point(445, 263);
			this.txtBoxDate.Name = "txtBoxDate";
			this.txtBoxDate.Size = new System.Drawing.Size(297, 27);
			this.txtBoxDate.TabIndex = 5;
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDate.Location = new System.Drawing.Point(334, 267);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(56, 23);
			this.lblDate.TabIndex = 4;
			this.lblDate.Text = "Date:";
			// 
			// txtBoxISBN
			// 
			this.txtBoxISBN.Location = new System.Drawing.Point(445, 159);
			this.txtBoxISBN.Name = "txtBoxISBN";
			this.txtBoxISBN.Size = new System.Drawing.Size(297, 27);
			this.txtBoxISBN.TabIndex = 3;
			// 
			// lblISBN
			// 
			this.lblISBN.AutoSize = true;
			this.lblISBN.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblISBN.Location = new System.Drawing.Point(332, 163);
			this.lblISBN.Name = "lblISBN";
			this.lblISBN.Size = new System.Drawing.Size(58, 23);
			this.lblISBN.TabIndex = 2;
			this.lblISBN.Text = "ISBN:";
			// 
			// txtBoxMemberID
			// 
			this.txtBoxMemberID.Location = new System.Drawing.Point(445, 49);
			this.txtBoxMemberID.Name = "txtBoxMemberID";
			this.txtBoxMemberID.Size = new System.Drawing.Size(297, 27);
			this.txtBoxMemberID.TabIndex = 1;
			// 
			// lblMemberID
			// 
			this.lblMemberID.AutoSize = true;
			this.lblMemberID.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMemberID.Location = new System.Drawing.Point(282, 53);
			this.lblMemberID.Name = "lblMemberID";
			this.lblMemberID.Size = new System.Drawing.Size(108, 23);
			this.lblMemberID.TabIndex = 0;
			this.lblMemberID.Text = "Member ID:";
			// 
			// CheckInForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1019, 567);
			this.Controls.Add(this.grpboxCheckIn);
			this.Controls.Add(this.pnlHeader);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CheckInForm";
			this.Text = "CheckInForm";
			this.pnlHeader.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picFormIcon)).EndInit();
			this.grpboxCheckIn.ResumeLayout(false);
			this.grpboxCheckIn.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picBoxLibrarian)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlHeader;
		private System.Windows.Forms.Label lblFormTitle;
		private System.Windows.Forms.PictureBox picFormIcon;
		private System.Windows.Forms.GroupBox grpboxCheckIn;
		private System.Windows.Forms.TextBox txtBoxDate;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.TextBox txtBoxISBN;
		private System.Windows.Forms.Label lblISBN;
		private System.Windows.Forms.TextBox txtBoxMemberID;
		private System.Windows.Forms.Label lblMemberID;
		private System.Windows.Forms.PictureBox picBoxLibrarian;
		private System.Windows.Forms.Button btnCheckIn;
	}
}