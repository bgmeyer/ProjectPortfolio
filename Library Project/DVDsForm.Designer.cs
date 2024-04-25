
namespace BroecklynneMeyer_CPT_206_Library
{
	partial class DVDsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DVDsForm));
			this.pnlHeader = new System.Windows.Forms.Panel();
			this.lblFormTitle = new System.Windows.Forms.Label();
			this.picFormIcon = new System.Windows.Forms.PictureBox();
			this.lblSelectTitle = new System.Windows.Forms.Label();
			this.cboxDVDTitle = new System.Windows.Forms.ComboBox();
			this.picboxDVD = new System.Windows.Forms.PictureBox();
			this.picboxDVDPlayer = new System.Windows.Forms.PictureBox();
			this.picboxPopcorn = new System.Windows.Forms.PictureBox();
			this.grpboxDVD = new System.Windows.Forms.GroupBox();
			this.lblLanguageOutput = new System.Windows.Forms.Label();
			this.lblLanguage = new System.Windows.Forms.Label();
			this.lblRuntimeOutput = new System.Windows.Forms.Label();
			this.lblRuntime = new System.Windows.Forms.Label();
			this.lblGenreOutput = new System.Windows.Forms.Label();
			this.lblGenre = new System.Windows.Forms.Label();
			this.lblReleasedOutput = new System.Windows.Forms.Label();
			this.lblReleased = new System.Windows.Forms.Label();
			this.lblIsbnOutput = new System.Windows.Forms.Label();
			this.lblISBN = new System.Windows.Forms.Label();
			this.lblTitleOutput = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.btnNewDVD = new System.Windows.Forms.Button();
			this.btnGo = new System.Windows.Forms.Button();
			this.pnlHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picFormIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picboxDVD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picboxDVDPlayer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picboxPopcorn)).BeginInit();
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
			this.lblFormTitle.Text = "DVDs";
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
			// lblSelectTitle
			// 
			this.lblSelectTitle.AutoSize = true;
			this.lblSelectTitle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSelectTitle.Location = new System.Drawing.Point(578, 65);
			this.lblSelectTitle.Name = "lblSelectTitle";
			this.lblSelectTitle.Size = new System.Drawing.Size(242, 19);
			this.lblSelectTitle.TabIndex = 2;
			this.lblSelectTitle.Text = "Select a title for DVD information:";
			// 
			// cboxDVDTitle
			// 
			this.cboxDVDTitle.DropDownWidth = 376;
			this.cboxDVDTitle.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboxDVDTitle.FormattingEnabled = true;
			this.cboxDVDTitle.Location = new System.Drawing.Point(582, 87);
			this.cboxDVDTitle.Name = "cboxDVDTitle";
			this.cboxDVDTitle.Size = new System.Drawing.Size(376, 22);
			this.cboxDVDTitle.TabIndex = 3;
			// 
			// picboxDVD
			// 
			this.picboxDVD.Image = ((System.Drawing.Image)(resources.GetObject("picboxDVD.Image")));
			this.picboxDVD.Location = new System.Drawing.Point(835, 125);
			this.picboxDVD.Name = "picboxDVD";
			this.picboxDVD.Size = new System.Drawing.Size(161, 134);
			this.picboxDVD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picboxDVD.TabIndex = 4;
			this.picboxDVD.TabStop = false;
			// 
			// picboxDVDPlayer
			// 
			this.picboxDVDPlayer.Image = ((System.Drawing.Image)(resources.GetObject("picboxDVDPlayer.Image")));
			this.picboxDVDPlayer.Location = new System.Drawing.Point(835, 284);
			this.picboxDVDPlayer.Name = "picboxDVDPlayer";
			this.picboxDVDPlayer.Size = new System.Drawing.Size(163, 134);
			this.picboxDVDPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picboxDVDPlayer.TabIndex = 5;
			this.picboxDVDPlayer.TabStop = false;
			// 
			// picboxPopcorn
			// 
			this.picboxPopcorn.Image = ((System.Drawing.Image)(resources.GetObject("picboxPopcorn.Image")));
			this.picboxPopcorn.Location = new System.Drawing.Point(835, 444);
			this.picboxPopcorn.Name = "picboxPopcorn";
			this.picboxPopcorn.Size = new System.Drawing.Size(161, 134);
			this.picboxPopcorn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picboxPopcorn.TabIndex = 6;
			this.picboxPopcorn.TabStop = false;
			// 
			// grpboxDVD
			// 
			this.grpboxDVD.Controls.Add(this.lblLanguageOutput);
			this.grpboxDVD.Controls.Add(this.lblLanguage);
			this.grpboxDVD.Controls.Add(this.lblRuntimeOutput);
			this.grpboxDVD.Controls.Add(this.lblRuntime);
			this.grpboxDVD.Controls.Add(this.lblGenreOutput);
			this.grpboxDVD.Controls.Add(this.lblGenre);
			this.grpboxDVD.Controls.Add(this.lblReleasedOutput);
			this.grpboxDVD.Controls.Add(this.lblReleased);
			this.grpboxDVD.Controls.Add(this.lblIsbnOutput);
			this.grpboxDVD.Controls.Add(this.lblISBN);
			this.grpboxDVD.Controls.Add(this.lblTitleOutput);
			this.grpboxDVD.Controls.Add(this.lblTitle);
			this.grpboxDVD.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpboxDVD.Location = new System.Drawing.Point(35, 141);
			this.grpboxDVD.Name = "grpboxDVD";
			this.grpboxDVD.Size = new System.Drawing.Size(778, 364);
			this.grpboxDVD.TabIndex = 7;
			this.grpboxDVD.TabStop = false;
			this.grpboxDVD.Text = "DVD Info";
			// 
			// lblLanguageOutput
			// 
			this.lblLanguageOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblLanguageOutput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLanguageOutput.Location = new System.Drawing.Point(536, 46);
			this.lblLanguageOutput.Name = "lblLanguageOutput";
			this.lblLanguageOutput.Size = new System.Drawing.Size(204, 30);
			this.lblLanguageOutput.TabIndex = 11;
			this.lblLanguageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblLanguage
			// 
			this.lblLanguage.AutoSize = true;
			this.lblLanguage.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLanguage.Location = new System.Drawing.Point(436, 53);
			this.lblLanguage.Name = "lblLanguage";
			this.lblLanguage.Size = new System.Drawing.Size(101, 23);
			this.lblLanguage.TabIndex = 10;
			this.lblLanguage.Text = "Language: ";
			// 
			// lblRuntimeOutput
			// 
			this.lblRuntimeOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblRuntimeOutput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRuntimeOutput.Location = new System.Drawing.Point(536, 207);
			this.lblRuntimeOutput.Name = "lblRuntimeOutput";
			this.lblRuntimeOutput.Size = new System.Drawing.Size(204, 30);
			this.lblRuntimeOutput.TabIndex = 9;
			this.lblRuntimeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblRuntime
			// 
			this.lblRuntime.AutoSize = true;
			this.lblRuntime.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRuntime.Location = new System.Drawing.Point(436, 214);
			this.lblRuntime.Name = "lblRuntime";
			this.lblRuntime.Size = new System.Drawing.Size(91, 23);
			this.lblRuntime.TabIndex = 8;
			this.lblRuntime.Text = "Runtime: ";
			// 
			// lblGenreOutput
			// 
			this.lblGenreOutput.AutoEllipsis = true;
			this.lblGenreOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblGenreOutput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGenreOutput.Location = new System.Drawing.Point(89, 207);
			this.lblGenreOutput.Name = "lblGenreOutput";
			this.lblGenreOutput.Size = new System.Drawing.Size(334, 110);
			this.lblGenreOutput.TabIndex = 7;
			this.lblGenreOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblGenre
			// 
			this.lblGenre.AutoSize = true;
			this.lblGenre.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGenre.Location = new System.Drawing.Point(12, 214);
			this.lblGenre.Name = "lblGenre";
			this.lblGenre.Size = new System.Drawing.Size(71, 23);
			this.lblGenre.TabIndex = 6;
			this.lblGenre.Text = "Genre: ";
			// 
			// lblReleasedOutput
			// 
			this.lblReleasedOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblReleasedOutput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblReleasedOutput.Location = new System.Drawing.Point(536, 126);
			this.lblReleasedOutput.Name = "lblReleasedOutput";
			this.lblReleasedOutput.Size = new System.Drawing.Size(204, 30);
			this.lblReleasedOutput.TabIndex = 5;
			this.lblReleasedOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblReleased
			// 
			this.lblReleased.AutoSize = true;
			this.lblReleased.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblReleased.Location = new System.Drawing.Point(440, 133);
			this.lblReleased.Name = "lblReleased";
			this.lblReleased.Size = new System.Drawing.Size(96, 23);
			this.lblReleased.TabIndex = 4;
			this.lblReleased.Text = "Released: ";
			// 
			// lblIsbnOutput
			// 
			this.lblIsbnOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblIsbnOutput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIsbnOutput.Location = new System.Drawing.Point(89, 126);
			this.lblIsbnOutput.Name = "lblIsbnOutput";
			this.lblIsbnOutput.Size = new System.Drawing.Size(334, 30);
			this.lblIsbnOutput.TabIndex = 3;
			this.lblIsbnOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblISBN
			// 
			this.lblISBN.AutoSize = true;
			this.lblISBN.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblISBN.Location = new System.Drawing.Point(25, 133);
			this.lblISBN.Name = "lblISBN";
			this.lblISBN.Size = new System.Drawing.Size(62, 23);
			this.lblISBN.TabIndex = 2;
			this.lblISBN.Text = "ISBN: ";
			// 
			// lblTitleOutput
			// 
			this.lblTitleOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblTitleOutput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitleOutput.Location = new System.Drawing.Point(89, 46);
			this.lblTitleOutput.Name = "lblTitleOutput";
			this.lblTitleOutput.Size = new System.Drawing.Size(334, 30);
			this.lblTitleOutput.TabIndex = 1;
			this.lblTitleOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(29, 53);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(58, 23);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Title: ";
			// 
			// btnNewDVD
			// 
			this.btnNewDVD.BackColor = System.Drawing.Color.Maroon;
			this.btnNewDVD.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNewDVD.ForeColor = System.Drawing.Color.Cornsilk;
			this.btnNewDVD.Location = new System.Drawing.Point(35, 524);
			this.btnNewDVD.Name = "btnNewDVD";
			this.btnNewDVD.Size = new System.Drawing.Size(188, 43);
			this.btnNewDVD.TabIndex = 8;
			this.btnNewDVD.Text = "Add New DVD";
			this.btnNewDVD.UseVisualStyleBackColor = false;
			this.btnNewDVD.Click += new System.EventHandler(this.btnNewDVD_Click);
			// 
			// btnGo
			// 
			this.btnGo.BackColor = System.Drawing.Color.Maroon;
			this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGo.ForeColor = System.Drawing.Color.Cornsilk;
			this.btnGo.Location = new System.Drawing.Point(966, 86);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(57, 23);
			this.btnGo.TabIndex = 9;
			this.btnGo.Text = "Go";
			this.btnGo.UseVisualStyleBackColor = false;
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// DVDsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1035, 606);
			this.Controls.Add(this.btnGo);
			this.Controls.Add(this.btnNewDVD);
			this.Controls.Add(this.grpboxDVD);
			this.Controls.Add(this.picboxPopcorn);
			this.Controls.Add(this.picboxDVDPlayer);
			this.Controls.Add(this.picboxDVD);
			this.Controls.Add(this.cboxDVDTitle);
			this.Controls.Add(this.lblSelectTitle);
			this.Controls.Add(this.pnlHeader);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "DVDsForm";
			this.Text = "DVDsForm";
			this.Load += new System.EventHandler(this.DVDsForm_Load);
			this.pnlHeader.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picFormIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picboxDVD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picboxDVDPlayer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picboxPopcorn)).EndInit();
			this.grpboxDVD.ResumeLayout(false);
			this.grpboxDVD.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlHeader;
		private System.Windows.Forms.Label lblFormTitle;
		private System.Windows.Forms.PictureBox picFormIcon;
		private System.Windows.Forms.Label lblSelectTitle;
		private System.Windows.Forms.ComboBox cboxDVDTitle;
		private System.Windows.Forms.PictureBox picboxDVD;
		private System.Windows.Forms.PictureBox picboxDVDPlayer;
		private System.Windows.Forms.PictureBox picboxPopcorn;
		private System.Windows.Forms.GroupBox grpboxDVD;
		private System.Windows.Forms.Label lblLanguageOutput;
		private System.Windows.Forms.Label lblLanguage;
		private System.Windows.Forms.Label lblRuntimeOutput;
		private System.Windows.Forms.Label lblRuntime;
		private System.Windows.Forms.Label lblGenreOutput;
		private System.Windows.Forms.Label lblGenre;
		private System.Windows.Forms.Label lblReleasedOutput;
		private System.Windows.Forms.Label lblReleased;
		private System.Windows.Forms.Label lblIsbnOutput;
		private System.Windows.Forms.Label lblISBN;
		private System.Windows.Forms.Label lblTitleOutput;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Button btnNewDVD;
		private System.Windows.Forms.Button btnGo;
	}
}