
namespace BroecklynneMeyer_CPT_206_Library
{
	partial class AddCD
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCD));
			this.pnlHeader = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.lblFormTitle = new System.Windows.Forms.Label();
			this.picFormIcon = new System.Windows.Forms.PictureBox();
			this.grpboxCD = new System.Windows.Forms.GroupBox();
			this.txtboxGenreInput = new System.Windows.Forms.TextBox();
			this.txtboxReleasedInput = new System.Windows.Forms.TextBox();
			this.txtboxIsbnInput = new System.Windows.Forms.TextBox();
			this.txtboxArtistInput = new System.Windows.Forms.TextBox();
			this.txtboxAlbumInput = new System.Windows.Forms.TextBox();
			this.lblArtist = new System.Windows.Forms.Label();
			this.LblDescription = new System.Windows.Forms.Label();
			this.lblGenre = new System.Windows.Forms.Label();
			this.lblReleased = new System.Windows.Forms.Label();
			this.lblISBN = new System.Windows.Forms.Label();
			this.lblAlbum = new System.Windows.Forms.Label();
			this.btnSaveCD = new System.Windows.Forms.Button();
			this.txtboxDescriptionInput = new System.Windows.Forms.TextBox();
			this.pnlHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picFormIcon)).BeginInit();
			this.grpboxCD.SuspendLayout();
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
			this.lblFormTitle.Text = "Add CD";
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
			// grpboxCD
			// 
			this.grpboxCD.Controls.Add(this.txtboxDescriptionInput);
			this.grpboxCD.Controls.Add(this.txtboxGenreInput);
			this.grpboxCD.Controls.Add(this.txtboxReleasedInput);
			this.grpboxCD.Controls.Add(this.txtboxIsbnInput);
			this.grpboxCD.Controls.Add(this.txtboxArtistInput);
			this.grpboxCD.Controls.Add(this.txtboxAlbumInput);
			this.grpboxCD.Controls.Add(this.lblArtist);
			this.grpboxCD.Controls.Add(this.LblDescription);
			this.grpboxCD.Controls.Add(this.lblGenre);
			this.grpboxCD.Controls.Add(this.lblReleased);
			this.grpboxCD.Controls.Add(this.lblISBN);
			this.grpboxCD.Controls.Add(this.lblAlbum);
			this.grpboxCD.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpboxCD.Location = new System.Drawing.Point(93, 87);
			this.grpboxCD.Name = "grpboxCD";
			this.grpboxCD.Size = new System.Drawing.Size(819, 364);
			this.grpboxCD.TabIndex = 8;
			this.grpboxCD.TabStop = false;
			this.grpboxCD.Text = "CD Info";
			// 
			// txtboxGenreInput
			// 
			this.txtboxGenreInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtboxGenreInput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxGenreInput.Location = new System.Drawing.Point(95, 216);
			this.txtboxGenreInput.Multiline = true;
			this.txtboxGenreInput.Name = "txtboxGenreInput";
			this.txtboxGenreInput.Size = new System.Drawing.Size(241, 124);
			this.txtboxGenreInput.TabIndex = 16;
			// 
			// txtboxReleasedInput
			// 
			this.txtboxReleasedInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtboxReleasedInput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxReleasedInput.Location = new System.Drawing.Point(458, 130);
			this.txtboxReleasedInput.Name = "txtboxReleasedInput";
			this.txtboxReleasedInput.Size = new System.Drawing.Size(282, 29);
			this.txtboxReleasedInput.TabIndex = 15;
			// 
			// txtboxIsbnInput
			// 
			this.txtboxIsbnInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtboxIsbnInput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxIsbnInput.Location = new System.Drawing.Point(95, 129);
			this.txtboxIsbnInput.Name = "txtboxIsbnInput";
			this.txtboxIsbnInput.Size = new System.Drawing.Size(241, 29);
			this.txtboxIsbnInput.TabIndex = 14;
			// 
			// txtboxArtistInput
			// 
			this.txtboxArtistInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtboxArtistInput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxArtistInput.Location = new System.Drawing.Point(458, 48);
			this.txtboxArtistInput.Name = "txtboxArtistInput";
			this.txtboxArtistInput.Size = new System.Drawing.Size(282, 29);
			this.txtboxArtistInput.TabIndex = 13;
			// 
			// txtboxAlbumInput
			// 
			this.txtboxAlbumInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtboxAlbumInput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxAlbumInput.Location = new System.Drawing.Point(95, 48);
			this.txtboxAlbumInput.Name = "txtboxAlbumInput";
			this.txtboxAlbumInput.Size = new System.Drawing.Size(278, 29);
			this.txtboxAlbumInput.TabIndex = 12;
			// 
			// lblArtist
			// 
			this.lblArtist.AutoSize = true;
			this.lblArtist.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblArtist.Location = new System.Drawing.Point(394, 53);
			this.lblArtist.Name = "lblArtist";
			this.lblArtist.Size = new System.Drawing.Size(62, 23);
			this.lblArtist.TabIndex = 10;
			this.lblArtist.Text = "Artist:";
			// 
			// LblDescription
			// 
			this.LblDescription.AutoSize = true;
			this.LblDescription.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblDescription.Location = new System.Drawing.Point(351, 216);
			this.LblDescription.Name = "LblDescription";
			this.LblDescription.Size = new System.Drawing.Size(115, 23);
			this.LblDescription.TabIndex = 8;
			this.LblDescription.Text = "Description: ";
			// 
			// lblGenre
			// 
			this.lblGenre.AutoSize = true;
			this.lblGenre.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGenre.Location = new System.Drawing.Point(21, 214);
			this.lblGenre.Name = "lblGenre";
			this.lblGenre.Size = new System.Drawing.Size(71, 23);
			this.lblGenre.TabIndex = 6;
			this.lblGenre.Text = "Genre: ";
			// 
			// lblReleased
			// 
			this.lblReleased.AutoSize = true;
			this.lblReleased.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblReleased.Location = new System.Drawing.Point(367, 134);
			this.lblReleased.Name = "lblReleased";
			this.lblReleased.Size = new System.Drawing.Size(96, 23);
			this.lblReleased.TabIndex = 4;
			this.lblReleased.Text = "Released: ";
			// 
			// lblISBN
			// 
			this.lblISBN.AutoSize = true;
			this.lblISBN.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblISBN.Location = new System.Drawing.Point(41, 134);
			this.lblISBN.Name = "lblISBN";
			this.lblISBN.Size = new System.Drawing.Size(62, 23);
			this.lblISBN.TabIndex = 2;
			this.lblISBN.Text = "ISBN: ";
			// 
			// lblAlbum
			// 
			this.lblAlbum.AutoSize = true;
			this.lblAlbum.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAlbum.Location = new System.Drawing.Point(29, 53);
			this.lblAlbum.Name = "lblAlbum";
			this.lblAlbum.Size = new System.Drawing.Size(70, 23);
			this.lblAlbum.TabIndex = 0;
			this.lblAlbum.Text = "Album:";
			// 
			// btnSaveCD
			// 
			this.btnSaveCD.BackColor = System.Drawing.Color.Maroon;
			this.btnSaveCD.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveCD.ForeColor = System.Drawing.Color.Cornsilk;
			this.btnSaveCD.Location = new System.Drawing.Point(724, 457);
			this.btnSaveCD.Name = "btnSaveCD";
			this.btnSaveCD.Size = new System.Drawing.Size(188, 43);
			this.btnSaveCD.TabIndex = 9;
			this.btnSaveCD.Text = "Save CD";
			this.btnSaveCD.UseVisualStyleBackColor = false;
			this.btnSaveCD.Click += new System.EventHandler(this.btnSaveCD_Click);
			// 
			// txtboxDescriptionInput
			// 
			this.txtboxDescriptionInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtboxDescriptionInput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxDescriptionInput.Location = new System.Drawing.Point(461, 216);
			this.txtboxDescriptionInput.Multiline = true;
			this.txtboxDescriptionInput.Name = "txtboxDescriptionInput";
			this.txtboxDescriptionInput.Size = new System.Drawing.Size(279, 124);
			this.txtboxDescriptionInput.TabIndex = 17;
			// 
			// AddCD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1003, 528);
			this.Controls.Add(this.btnSaveCD);
			this.Controls.Add(this.grpboxCD);
			this.Controls.Add(this.pnlHeader);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AddCD";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddCD";
			this.pnlHeader.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picFormIcon)).EndInit();
			this.grpboxCD.ResumeLayout(false);
			this.grpboxCD.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlHeader;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label lblFormTitle;
		private System.Windows.Forms.PictureBox picFormIcon;
		private System.Windows.Forms.GroupBox grpboxCD;
		private System.Windows.Forms.Label lblArtist;
		private System.Windows.Forms.Label LblDescription;
		private System.Windows.Forms.Label lblGenre;
		private System.Windows.Forms.Label lblReleased;
		private System.Windows.Forms.Label lblISBN;
		private System.Windows.Forms.Label lblAlbum;
		private System.Windows.Forms.TextBox txtboxArtistInput;
		private System.Windows.Forms.TextBox txtboxAlbumInput;
		private System.Windows.Forms.Button btnSaveCD;
		private System.Windows.Forms.TextBox txtboxIsbnInput;
		private System.Windows.Forms.TextBox txtboxGenreInput;
		private System.Windows.Forms.TextBox txtboxReleasedInput;
		private System.Windows.Forms.TextBox txtboxDescriptionInput;
	}
}