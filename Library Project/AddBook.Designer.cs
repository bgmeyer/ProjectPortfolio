
namespace BroecklynneMeyer_CPT_206_Library
{
	partial class AddBook
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
			this.pnlHeader = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.lblFormTitle = new System.Windows.Forms.Label();
			this.picFormIcon = new System.Windows.Forms.PictureBox();
			this.grpboxBook = new System.Windows.Forms.GroupBox();
			this.txtboxYearPublished = new System.Windows.Forms.TextBox();
			this.txtboxAuthorInput = new System.Windows.Forms.TextBox();
			this.txtboxPublisherInput = new System.Windows.Forms.TextBox();
			this.txtboxIsbnInput = new System.Windows.Forms.TextBox();
			this.txtboxTitleInput = new System.Windows.Forms.TextBox();
			this.lblYear = new System.Windows.Forms.Label();
			this.lblAuthor = new System.Windows.Forms.Label();
			this.lblPublisher = new System.Windows.Forms.Label();
			this.lblISBN = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.btnSaveBook = new System.Windows.Forms.Button();
			this.pnlHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picFormIcon)).BeginInit();
			this.grpboxBook.SuspendLayout();
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
			this.pnlHeader.TabIndex = 3;
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
			this.lblFormTitle.Size = new System.Drawing.Size(117, 41);
			this.lblFormTitle.TabIndex = 1;
			this.lblFormTitle.Text = "Add Book";
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
			// grpboxBook
			// 
			this.grpboxBook.Controls.Add(this.txtboxYearPublished);
			this.grpboxBook.Controls.Add(this.txtboxAuthorInput);
			this.grpboxBook.Controls.Add(this.txtboxPublisherInput);
			this.grpboxBook.Controls.Add(this.txtboxIsbnInput);
			this.grpboxBook.Controls.Add(this.txtboxTitleInput);
			this.grpboxBook.Controls.Add(this.lblYear);
			this.grpboxBook.Controls.Add(this.lblAuthor);
			this.grpboxBook.Controls.Add(this.lblPublisher);
			this.grpboxBook.Controls.Add(this.lblISBN);
			this.grpboxBook.Controls.Add(this.lblTitle);
			this.grpboxBook.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpboxBook.Location = new System.Drawing.Point(84, 102);
			this.grpboxBook.Name = "grpboxBook";
			this.grpboxBook.Size = new System.Drawing.Size(831, 345);
			this.grpboxBook.TabIndex = 7;
			this.grpboxBook.TabStop = false;
			this.grpboxBook.Text = "Book Info";
			// 
			// txtboxYearPublished
			// 
			this.txtboxYearPublished.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtboxYearPublished.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxYearPublished.Location = new System.Drawing.Point(517, 252);
			this.txtboxYearPublished.Name = "txtboxYearPublished";
			this.txtboxYearPublished.Size = new System.Drawing.Size(281, 29);
			this.txtboxYearPublished.TabIndex = 14;
			// 
			// txtboxAuthorInput
			// 
			this.txtboxAuthorInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtboxAuthorInput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxAuthorInput.Location = new System.Drawing.Point(84, 252);
			this.txtboxAuthorInput.Name = "txtboxAuthorInput";
			this.txtboxAuthorInput.Size = new System.Drawing.Size(281, 29);
			this.txtboxAuthorInput.TabIndex = 13;
			// 
			// txtboxPublisherInput
			// 
			this.txtboxPublisherInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtboxPublisherInput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxPublisherInput.Location = new System.Drawing.Point(517, 152);
			this.txtboxPublisherInput.Name = "txtboxPublisherInput";
			this.txtboxPublisherInput.Size = new System.Drawing.Size(281, 29);
			this.txtboxPublisherInput.TabIndex = 12;
			// 
			// txtboxIsbnInput
			// 
			this.txtboxIsbnInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtboxIsbnInput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxIsbnInput.Location = new System.Drawing.Point(84, 152);
			this.txtboxIsbnInput.Name = "txtboxIsbnInput";
			this.txtboxIsbnInput.Size = new System.Drawing.Size(281, 29);
			this.txtboxIsbnInput.TabIndex = 11;
			// 
			// txtboxTitleInput
			// 
			this.txtboxTitleInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtboxTitleInput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxTitleInput.Location = new System.Drawing.Point(84, 55);
			this.txtboxTitleInput.Name = "txtboxTitleInput";
			this.txtboxTitleInput.Size = new System.Drawing.Size(714, 29);
			this.txtboxTitleInput.TabIndex = 10;
			// 
			// lblYear
			// 
			this.lblYear.AutoSize = true;
			this.lblYear.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblYear.Location = new System.Drawing.Point(378, 259);
			this.lblYear.Name = "lblYear";
			this.lblYear.Size = new System.Drawing.Size(144, 23);
			this.lblYear.TabIndex = 8;
			this.lblYear.Text = "Year Published: ";
			// 
			// lblAuthor
			// 
			this.lblAuthor.AutoSize = true;
			this.lblAuthor.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAuthor.Location = new System.Drawing.Point(14, 259);
			this.lblAuthor.Name = "lblAuthor";
			this.lblAuthor.Size = new System.Drawing.Size(78, 23);
			this.lblAuthor.TabIndex = 6;
			this.lblAuthor.Text = "Author: ";
			// 
			// lblPublisher
			// 
			this.lblPublisher.AutoSize = true;
			this.lblPublisher.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPublisher.Location = new System.Drawing.Point(423, 159);
			this.lblPublisher.Name = "lblPublisher";
			this.lblPublisher.Size = new System.Drawing.Size(98, 23);
			this.lblPublisher.TabIndex = 4;
			this.lblPublisher.Text = "Publisher: ";
			// 
			// lblISBN
			// 
			this.lblISBN.AutoSize = true;
			this.lblISBN.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblISBN.Location = new System.Drawing.Point(30, 159);
			this.lblISBN.Name = "lblISBN";
			this.lblISBN.Size = new System.Drawing.Size(62, 23);
			this.lblISBN.TabIndex = 2;
			this.lblISBN.Text = "ISBN: ";
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(34, 61);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(58, 23);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Title: ";
			// 
			// btnSaveBook
			// 
			this.btnSaveBook.BackColor = System.Drawing.Color.Maroon;
			this.btnSaveBook.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveBook.ForeColor = System.Drawing.Color.Cornsilk;
			this.btnSaveBook.Location = new System.Drawing.Point(727, 453);
			this.btnSaveBook.Name = "btnSaveBook";
			this.btnSaveBook.Size = new System.Drawing.Size(188, 43);
			this.btnSaveBook.TabIndex = 8;
			this.btnSaveBook.Text = "Save Book";
			this.btnSaveBook.UseVisualStyleBackColor = false;
			this.btnSaveBook.Click += new System.EventHandler(this.btnNewBook_Click);
			// 
			// AddBook
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1003, 528);
			this.Controls.Add(this.btnSaveBook);
			this.Controls.Add(this.grpboxBook);
			this.Controls.Add(this.pnlHeader);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AddBook";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddBook";
			this.pnlHeader.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picFormIcon)).EndInit();
			this.grpboxBook.ResumeLayout(false);
			this.grpboxBook.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlHeader;
		private System.Windows.Forms.Label lblFormTitle;
		private System.Windows.Forms.PictureBox picFormIcon;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.GroupBox grpboxBook;
		private System.Windows.Forms.Label lblYear;
		private System.Windows.Forms.Label lblAuthor;
		private System.Windows.Forms.Label lblPublisher;
		private System.Windows.Forms.Label lblISBN;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.TextBox txtboxPublisherInput;
		private System.Windows.Forms.TextBox txtboxIsbnInput;
		private System.Windows.Forms.TextBox txtboxTitleInput;
		private System.Windows.Forms.Button btnSaveBook;
		private System.Windows.Forms.TextBox txtboxYearPublished;
		private System.Windows.Forms.TextBox txtboxAuthorInput;
	}
}