
namespace BroecklynneMeyer_CPT_206_Library
{
	partial class AddDVD
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDVD));
			this.pnlHeader = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.lblFormTitle = new System.Windows.Forms.Label();
			this.picFormIcon = new System.Windows.Forms.PictureBox();
			this.grpboxDVD = new System.Windows.Forms.GroupBox();
			this.txtboxGenreInput = new System.Windows.Forms.TextBox();
			this.txtboxRuntimeInput = new System.Windows.Forms.TextBox();
			this.txtboxReleasedInput = new System.Windows.Forms.TextBox();
			this.txtboxIsbnInput = new System.Windows.Forms.TextBox();
			this.txtboxLanguageInput = new System.Windows.Forms.TextBox();
			this.txtboxTitleInput = new System.Windows.Forms.TextBox();
			this.lblLanguage = new System.Windows.Forms.Label();
			this.lblRuntime = new System.Windows.Forms.Label();
			this.lblGenre = new System.Windows.Forms.Label();
			this.lblReleased = new System.Windows.Forms.Label();
			this.lblISBN = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.btnSaveDVD = new System.Windows.Forms.Button();
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
			this.lblFormTitle.Size = new System.Drawing.Size(117, 41);
			this.lblFormTitle.TabIndex = 1;
			this.lblFormTitle.Text = "Add DVD";
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
			this.grpboxDVD.Controls.Add(this.txtboxGenreInput);
			this.grpboxDVD.Controls.Add(this.txtboxRuntimeInput);
			this.grpboxDVD.Controls.Add(this.txtboxReleasedInput);
			this.grpboxDVD.Controls.Add(this.txtboxIsbnInput);
			this.grpboxDVD.Controls.Add(this.txtboxLanguageInput);
			this.grpboxDVD.Controls.Add(this.txtboxTitleInput);
			this.grpboxDVD.Controls.Add(this.lblLanguage);
			this.grpboxDVD.Controls.Add(this.lblRuntime);
			this.grpboxDVD.Controls.Add(this.lblGenre);
			this.grpboxDVD.Controls.Add(this.lblReleased);
			this.grpboxDVD.Controls.Add(this.lblISBN);
			this.grpboxDVD.Controls.Add(this.lblTitle);
			this.grpboxDVD.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpboxDVD.Location = new System.Drawing.Point(98, 92);
			this.grpboxDVD.Name = "grpboxDVD";
			this.grpboxDVD.Size = new System.Drawing.Size(800, 358);
			this.grpboxDVD.TabIndex = 8;
			this.grpboxDVD.TabStop = false;
			this.grpboxDVD.Text = "DVD Info";
			// 
			// txtboxGenreInput
			// 
			this.txtboxGenreInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtboxGenreInput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxGenreInput.Location = new System.Drawing.Point(89, 217);
			this.txtboxGenreInput.Multiline = true;
			this.txtboxGenreInput.Name = "txtboxGenreInput";
			this.txtboxGenreInput.Size = new System.Drawing.Size(334, 116);
			this.txtboxGenreInput.TabIndex = 17;
			// 
			// txtboxRuntimeInput
			// 
			this.txtboxRuntimeInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtboxRuntimeInput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxRuntimeInput.Location = new System.Drawing.Point(536, 207);
			this.txtboxRuntimeInput.Name = "txtboxRuntimeInput";
			this.txtboxRuntimeInput.Size = new System.Drawing.Size(204, 29);
			this.txtboxRuntimeInput.TabIndex = 16;
			// 
			// txtboxReleasedInput
			// 
			this.txtboxReleasedInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtboxReleasedInput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxReleasedInput.Location = new System.Drawing.Point(536, 127);
			this.txtboxReleasedInput.Name = "txtboxReleasedInput";
			this.txtboxReleasedInput.Size = new System.Drawing.Size(204, 29);
			this.txtboxReleasedInput.TabIndex = 15;
			// 
			// txtboxIsbnInput
			// 
			this.txtboxIsbnInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtboxIsbnInput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxIsbnInput.Location = new System.Drawing.Point(89, 127);
			this.txtboxIsbnInput.Name = "txtboxIsbnInput";
			this.txtboxIsbnInput.Size = new System.Drawing.Size(334, 29);
			this.txtboxIsbnInput.TabIndex = 14;
			// 
			// txtboxLanguageInput
			// 
			this.txtboxLanguageInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtboxLanguageInput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxLanguageInput.Location = new System.Drawing.Point(536, 49);
			this.txtboxLanguageInput.Name = "txtboxLanguageInput";
			this.txtboxLanguageInput.Size = new System.Drawing.Size(204, 29);
			this.txtboxLanguageInput.TabIndex = 13;
			// 
			// txtboxTitleInput
			// 
			this.txtboxTitleInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtboxTitleInput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxTitleInput.Location = new System.Drawing.Point(89, 49);
			this.txtboxTitleInput.Name = "txtboxTitleInput";
			this.txtboxTitleInput.Size = new System.Drawing.Size(334, 29);
			this.txtboxTitleInput.TabIndex = 12;
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
			// btnSaveDVD
			// 
			this.btnSaveDVD.BackColor = System.Drawing.Color.Maroon;
			this.btnSaveDVD.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveDVD.ForeColor = System.Drawing.Color.Cornsilk;
			this.btnSaveDVD.Location = new System.Drawing.Point(704, 456);
			this.btnSaveDVD.Name = "btnSaveDVD";
			this.btnSaveDVD.Size = new System.Drawing.Size(188, 43);
			this.btnSaveDVD.TabIndex = 9;
			this.btnSaveDVD.Text = "Save DVD";
			this.btnSaveDVD.UseVisualStyleBackColor = false;
			this.btnSaveDVD.Click += new System.EventHandler(this.btnSaveDVD_Click);
			// 
			// AddDVD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1003, 528);
			this.Controls.Add(this.btnSaveDVD);
			this.Controls.Add(this.grpboxDVD);
			this.Controls.Add(this.pnlHeader);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AddDVD";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddDVD";
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
		private System.Windows.Forms.Label lblLanguage;
		private System.Windows.Forms.Label lblRuntime;
		private System.Windows.Forms.Label lblGenre;
		private System.Windows.Forms.Label lblReleased;
		private System.Windows.Forms.Label lblISBN;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.TextBox txtboxIsbnInput;
		private System.Windows.Forms.TextBox txtboxLanguageInput;
		private System.Windows.Forms.TextBox txtboxTitleInput;
		private System.Windows.Forms.Button btnSaveDVD;
		private System.Windows.Forms.TextBox txtboxReleasedInput;
		private System.Windows.Forms.TextBox txtboxRuntimeInput;
		private System.Windows.Forms.TextBox txtboxGenreInput;
	}
}