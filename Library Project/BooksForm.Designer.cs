
namespace BroecklynneMeyer_CPT_206_Library
{
	partial class BooksForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksForm));
			this.pnlHeader = new System.Windows.Forms.Panel();
			this.lblFormTitle = new System.Windows.Forms.Label();
			this.picFormIcon = new System.Windows.Forms.PictureBox();
			this.lblSelectTitle = new System.Windows.Forms.Label();
			this.cboxBookTitle = new System.Windows.Forms.ComboBox();
			this.picboxGirlReading = new System.Windows.Forms.PictureBox();
			this.picboxSearchBook = new System.Windows.Forms.PictureBox();
			this.picboxBoyReading = new System.Windows.Forms.PictureBox();
			this.grpboxBook = new System.Windows.Forms.GroupBox();
			this.lblYearOutput = new System.Windows.Forms.Label();
			this.lblYear = new System.Windows.Forms.Label();
			this.lblAuthorOutput = new System.Windows.Forms.Label();
			this.lblAuthor = new System.Windows.Forms.Label();
			this.lblPublisherOutput = new System.Windows.Forms.Label();
			this.lblPublisher = new System.Windows.Forms.Label();
			this.lblIsbnOutput = new System.Windows.Forms.Label();
			this.lblISBN = new System.Windows.Forms.Label();
			this.lblTitleOutput = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.btnNewBook = new System.Windows.Forms.Button();
			this.btnGo = new System.Windows.Forms.Button();
			this.pnlHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picFormIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picboxGirlReading)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picboxSearchBook)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picboxBoyReading)).BeginInit();
			this.grpboxBook.SuspendLayout();
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
			this.pnlHeader.Size = new System.Drawing.Size(1035, 60);
			this.pnlHeader.TabIndex = 0;
			// 
			// lblFormTitle
			// 
			this.lblFormTitle.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFormTitle.ForeColor = System.Drawing.Color.Cornsilk;
			this.lblFormTitle.Location = new System.Drawing.Point(78, 9);
			this.lblFormTitle.Name = "lblFormTitle";
			this.lblFormTitle.Size = new System.Drawing.Size(136, 47);
			this.lblFormTitle.TabIndex = 1;
			this.lblFormTitle.Text = "Books";
			this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picFormIcon
			// 
			this.picFormIcon.Image = ((System.Drawing.Image)(resources.GetObject("picFormIcon.Image")));
			this.picFormIcon.Location = new System.Drawing.Point(3, 5);
			this.picFormIcon.Name = "picFormIcon";
			this.picFormIcon.Size = new System.Drawing.Size(68, 51);
			this.picFormIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picFormIcon.TabIndex = 0;
			this.picFormIcon.TabStop = false;
			// 
			// lblSelectTitle
			// 
			this.lblSelectTitle.AutoSize = true;
			this.lblSelectTitle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSelectTitle.Location = new System.Drawing.Point(443, 81);
			this.lblSelectTitle.Name = "lblSelectTitle";
			this.lblSelectTitle.Size = new System.Drawing.Size(248, 19);
			this.lblSelectTitle.TabIndex = 1;
			this.lblSelectTitle.Text = "Select a title for book information: ";
			// 
			// cboxBookTitle
			// 
			this.cboxBookTitle.DropDownWidth = 494;
			this.cboxBookTitle.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboxBookTitle.FormattingEnabled = true;
			this.cboxBookTitle.Location = new System.Drawing.Point(447, 103);
			this.cboxBookTitle.Name = "cboxBookTitle";
			this.cboxBookTitle.Size = new System.Drawing.Size(464, 22);
			this.cboxBookTitle.TabIndex = 2;
			// 
			// picboxGirlReading
			// 
			this.picboxGirlReading.Image = ((System.Drawing.Image)(resources.GetObject("picboxGirlReading.Image")));
			this.picboxGirlReading.Location = new System.Drawing.Point(860, 151);
			this.picboxGirlReading.Name = "picboxGirlReading";
			this.picboxGirlReading.Size = new System.Drawing.Size(163, 138);
			this.picboxGirlReading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picboxGirlReading.TabIndex = 3;
			this.picboxGirlReading.TabStop = false;
			// 
			// picboxSearchBook
			// 
			this.picboxSearchBook.Image = ((System.Drawing.Image)(resources.GetObject("picboxSearchBook.Image")));
			this.picboxSearchBook.Location = new System.Drawing.Point(860, 300);
			this.picboxSearchBook.Name = "picboxSearchBook";
			this.picboxSearchBook.Size = new System.Drawing.Size(163, 145);
			this.picboxSearchBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picboxSearchBook.TabIndex = 4;
			this.picboxSearchBook.TabStop = false;
			// 
			// picboxBoyReading
			// 
			this.picboxBoyReading.Image = ((System.Drawing.Image)(resources.GetObject("picboxBoyReading.Image")));
			this.picboxBoyReading.Location = new System.Drawing.Point(862, 451);
			this.picboxBoyReading.Name = "picboxBoyReading";
			this.picboxBoyReading.Size = new System.Drawing.Size(161, 133);
			this.picboxBoyReading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picboxBoyReading.TabIndex = 5;
			this.picboxBoyReading.TabStop = false;
			// 
			// grpboxBook
			// 
			this.grpboxBook.Controls.Add(this.lblYearOutput);
			this.grpboxBook.Controls.Add(this.lblYear);
			this.grpboxBook.Controls.Add(this.lblAuthorOutput);
			this.grpboxBook.Controls.Add(this.lblAuthor);
			this.grpboxBook.Controls.Add(this.lblPublisherOutput);
			this.grpboxBook.Controls.Add(this.lblPublisher);
			this.grpboxBook.Controls.Add(this.lblIsbnOutput);
			this.grpboxBook.Controls.Add(this.lblISBN);
			this.grpboxBook.Controls.Add(this.lblTitleOutput);
			this.grpboxBook.Controls.Add(this.lblTitle);
			this.grpboxBook.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpboxBook.Location = new System.Drawing.Point(12, 163);
			this.grpboxBook.Name = "grpboxBook";
			this.grpboxBook.Size = new System.Drawing.Size(831, 345);
			this.grpboxBook.TabIndex = 6;
			this.grpboxBook.TabStop = false;
			this.grpboxBook.Text = "Book Info";
			// 
			// lblYearOutput
			// 
			this.lblYearOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblYearOutput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblYearOutput.Location = new System.Drawing.Point(517, 248);
			this.lblYearOutput.Name = "lblYearOutput";
			this.lblYearOutput.Size = new System.Drawing.Size(281, 34);
			this.lblYearOutput.TabIndex = 9;
			this.lblYearOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblYear
			// 
			this.lblYear.AutoSize = true;
			this.lblYear.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblYear.Location = new System.Drawing.Point(371, 259);
			this.lblYear.Name = "lblYear";
			this.lblYear.Size = new System.Drawing.Size(144, 23);
			this.lblYear.TabIndex = 8;
			this.lblYear.Text = "Year Published: ";
			// 
			// lblAuthorOutput
			// 
			this.lblAuthorOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblAuthorOutput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAuthorOutput.Location = new System.Drawing.Point(84, 248);
			this.lblAuthorOutput.Name = "lblAuthorOutput";
			this.lblAuthorOutput.Size = new System.Drawing.Size(281, 34);
			this.lblAuthorOutput.TabIndex = 7;
			this.lblAuthorOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			// lblPublisherOutput
			// 
			this.lblPublisherOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblPublisherOutput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPublisherOutput.Location = new System.Drawing.Point(517, 148);
			this.lblPublisherOutput.Name = "lblPublisherOutput";
			this.lblPublisherOutput.Size = new System.Drawing.Size(281, 34);
			this.lblPublisherOutput.TabIndex = 5;
			this.lblPublisherOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPublisher
			// 
			this.lblPublisher.AutoSize = true;
			this.lblPublisher.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPublisher.Location = new System.Drawing.Point(413, 159);
			this.lblPublisher.Name = "lblPublisher";
			this.lblPublisher.Size = new System.Drawing.Size(98, 23);
			this.lblPublisher.TabIndex = 4;
			this.lblPublisher.Text = "Publisher: ";
			// 
			// lblIsbnOutput
			// 
			this.lblIsbnOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblIsbnOutput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIsbnOutput.Location = new System.Drawing.Point(84, 148);
			this.lblIsbnOutput.Name = "lblIsbnOutput";
			this.lblIsbnOutput.Size = new System.Drawing.Size(281, 34);
			this.lblIsbnOutput.TabIndex = 3;
			this.lblIsbnOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			// lblTitleOutput
			// 
			this.lblTitleOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblTitleOutput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitleOutput.Location = new System.Drawing.Point(84, 50);
			this.lblTitleOutput.Name = "lblTitleOutput";
			this.lblTitleOutput.Size = new System.Drawing.Size(714, 34);
			this.lblTitleOutput.TabIndex = 1;
			this.lblTitleOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			// btnNewBook
			// 
			this.btnNewBook.BackColor = System.Drawing.Color.Maroon;
			this.btnNewBook.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNewBook.ForeColor = System.Drawing.Color.Cornsilk;
			this.btnNewBook.Location = new System.Drawing.Point(12, 524);
			this.btnNewBook.Name = "btnNewBook";
			this.btnNewBook.Size = new System.Drawing.Size(188, 43);
			this.btnNewBook.TabIndex = 7;
			this.btnNewBook.Text = "Add New Book";
			this.btnNewBook.UseVisualStyleBackColor = false;
			this.btnNewBook.Click += new System.EventHandler(this.btnNewBook_Click);
			// 
			// btnGo
			// 
			this.btnGo.BackColor = System.Drawing.Color.Maroon;
			this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGo.ForeColor = System.Drawing.Color.Cornsilk;
			this.btnGo.Location = new System.Drawing.Point(922, 102);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(57, 23);
			this.btnGo.TabIndex = 8;
			this.btnGo.Text = "Go";
			this.btnGo.UseVisualStyleBackColor = false;
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// BooksForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1035, 611);
			this.Controls.Add(this.btnGo);
			this.Controls.Add(this.btnNewBook);
			this.Controls.Add(this.grpboxBook);
			this.Controls.Add(this.picboxBoyReading);
			this.Controls.Add(this.picboxSearchBook);
			this.Controls.Add(this.picboxGirlReading);
			this.Controls.Add(this.cboxBookTitle);
			this.Controls.Add(this.lblSelectTitle);
			this.Controls.Add(this.pnlHeader);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "BooksForm";
			this.Text = "BooksForm";
			this.Load += new System.EventHandler(this.BooksForm_Load);
			this.pnlHeader.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picFormIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picboxGirlReading)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picboxSearchBook)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picboxBoyReading)).EndInit();
			this.grpboxBook.ResumeLayout(false);
			this.grpboxBook.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlHeader;
		private System.Windows.Forms.Label lblFormTitle;
		private System.Windows.Forms.PictureBox picFormIcon;
		private System.Windows.Forms.Label lblSelectTitle;
		private System.Windows.Forms.ComboBox cboxBookTitle;
		private System.Windows.Forms.PictureBox picboxGirlReading;
		private System.Windows.Forms.PictureBox picboxSearchBook;
		private System.Windows.Forms.PictureBox picboxBoyReading;
		private System.Windows.Forms.GroupBox grpboxBook;
		private System.Windows.Forms.Label lblYearOutput;
		private System.Windows.Forms.Label lblYear;
		private System.Windows.Forms.Label lblAuthorOutput;
		private System.Windows.Forms.Label lblAuthor;
		private System.Windows.Forms.Label lblPublisherOutput;
		private System.Windows.Forms.Label lblPublisher;
		private System.Windows.Forms.Label lblIsbnOutput;
		private System.Windows.Forms.Label lblISBN;
		private System.Windows.Forms.Label lblTitleOutput;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Button btnNewBook;
		private System.Windows.Forms.Button btnGo;
	}
}