
namespace BroecklynneMeyer_CPT_206_Library
{
	partial class AddMember
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMember));
			this.pnlHeader = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.lblFormTitle = new System.Windows.Forms.Label();
			this.picFormIcon = new System.Windows.Forms.PictureBox();
			this.btnSaveBook = new System.Windows.Forms.Button();
			this.grpboxMember = new System.Windows.Forms.GroupBox();
			this.lblZip = new System.Windows.Forms.Label();
			this.lblState = new System.Windows.Forms.Label();
			this.lblLastName = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblPhone = new System.Windows.Forms.Label();
			this.lblCity = new System.Windows.Forms.Label();
			this.lblAddress = new System.Windows.Forms.Label();
			this.lblFirstName = new System.Windows.Forms.Label();
			this.txtboxFirstInput = new System.Windows.Forms.TextBox();
			this.txtboxLastInput = new System.Windows.Forms.TextBox();
			this.txtboxCityInput = new System.Windows.Forms.TextBox();
			this.txtboxAddressInput = new System.Windows.Forms.TextBox();
			this.txtboxStateInput = new System.Windows.Forms.TextBox();
			this.txtboxZipcodeInput = new System.Windows.Forms.TextBox();
			this.txtboxPhoneInput = new System.Windows.Forms.TextBox();
			this.txtboxEmailInput = new System.Windows.Forms.TextBox();
			this.lblMemberId = new System.Windows.Forms.Label();
			this.txtBoxMemberIdInput = new System.Windows.Forms.TextBox();
			this.pnlHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picFormIcon)).BeginInit();
			this.grpboxMember.SuspendLayout();
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
			this.lblFormTitle.Size = new System.Drawing.Size(154, 41);
			this.lblFormTitle.TabIndex = 1;
			this.lblFormTitle.Text = "Add Member";
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
			// btnSaveBook
			// 
			this.btnSaveBook.BackColor = System.Drawing.Color.Maroon;
			this.btnSaveBook.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveBook.ForeColor = System.Drawing.Color.Cornsilk;
			this.btnSaveBook.Location = new System.Drawing.Point(723, 468);
			this.btnSaveBook.Name = "btnSaveBook";
			this.btnSaveBook.Size = new System.Drawing.Size(188, 43);
			this.btnSaveBook.TabIndex = 9;
			this.btnSaveBook.Text = "Save Member";
			this.btnSaveBook.UseVisualStyleBackColor = false;
			this.btnSaveBook.Click += new System.EventHandler(this.btnSaveBook_Click);
			// 
			// grpboxMember
			// 
			this.grpboxMember.Controls.Add(this.txtBoxMemberIdInput);
			this.grpboxMember.Controls.Add(this.lblMemberId);
			this.grpboxMember.Controls.Add(this.txtboxEmailInput);
			this.grpboxMember.Controls.Add(this.txtboxPhoneInput);
			this.grpboxMember.Controls.Add(this.txtboxZipcodeInput);
			this.grpboxMember.Controls.Add(this.txtboxStateInput);
			this.grpboxMember.Controls.Add(this.txtboxAddressInput);
			this.grpboxMember.Controls.Add(this.txtboxCityInput);
			this.grpboxMember.Controls.Add(this.txtboxLastInput);
			this.grpboxMember.Controls.Add(this.txtboxFirstInput);
			this.grpboxMember.Controls.Add(this.lblZip);
			this.grpboxMember.Controls.Add(this.lblState);
			this.grpboxMember.Controls.Add(this.lblLastName);
			this.grpboxMember.Controls.Add(this.lblEmail);
			this.grpboxMember.Controls.Add(this.lblPhone);
			this.grpboxMember.Controls.Add(this.lblCity);
			this.grpboxMember.Controls.Add(this.lblAddress);
			this.grpboxMember.Controls.Add(this.lblFirstName);
			this.grpboxMember.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpboxMember.Location = new System.Drawing.Point(85, 73);
			this.grpboxMember.Name = "grpboxMember";
			this.grpboxMember.Size = new System.Drawing.Size(826, 389);
			this.grpboxMember.TabIndex = 10;
			this.grpboxMember.TabStop = false;
			this.grpboxMember.Text = "Member Info";
			// 
			// lblZip
			// 
			this.lblZip.AutoSize = true;
			this.lblZip.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblZip.Location = new System.Drawing.Point(388, 206);
			this.lblZip.Name = "lblZip";
			this.lblZip.Size = new System.Drawing.Size(82, 23);
			this.lblZip.TabIndex = 14;
			this.lblZip.Text = "Zipcode:";
			// 
			// lblState
			// 
			this.lblState.AutoSize = true;
			this.lblState.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblState.Location = new System.Drawing.Point(35, 206);
			this.lblState.Name = "lblState";
			this.lblState.Size = new System.Drawing.Size(61, 23);
			this.lblState.TabIndex = 12;
			this.lblState.Text = "State:";
			// 
			// lblLastName
			// 
			this.lblLastName.AutoSize = true;
			this.lblLastName.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLastName.Location = new System.Drawing.Point(421, 47);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.Size = new System.Drawing.Size(51, 23);
			this.lblLastName.TabIndex = 10;
			this.lblLastName.Text = "Last:";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmail.Location = new System.Drawing.Point(403, 285);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(67, 23);
			this.lblEmail.TabIndex = 8;
			this.lblEmail.Text = "Email: ";
			// 
			// lblPhone
			// 
			this.lblPhone.AutoSize = true;
			this.lblPhone.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPhone.Location = new System.Drawing.Point(25, 285);
			this.lblPhone.Name = "lblPhone";
			this.lblPhone.Size = new System.Drawing.Size(70, 23);
			this.lblPhone.TabIndex = 6;
			this.lblPhone.Text = "Phone:";
			// 
			// lblCity
			// 
			this.lblCity.AutoSize = true;
			this.lblCity.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCity.Location = new System.Drawing.Point(421, 129);
			this.lblCity.Name = "lblCity";
			this.lblCity.Size = new System.Drawing.Size(49, 23);
			this.lblCity.TabIndex = 4;
			this.lblCity.Text = "City:";
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAddress.Location = new System.Drawing.Point(13, 129);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(83, 23);
			this.lblAddress.TabIndex = 2;
			this.lblAddress.Text = "Address:";
			// 
			// lblFirstName
			// 
			this.lblFirstName.AutoSize = true;
			this.lblFirstName.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFirstName.Location = new System.Drawing.Point(43, 47);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.Size = new System.Drawing.Size(53, 23);
			this.lblFirstName.TabIndex = 0;
			this.lblFirstName.Text = "First:";
			// 
			// txtboxFirstInput
			// 
			this.txtboxFirstInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtboxFirstInput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxFirstInput.Location = new System.Drawing.Point(101, 42);
			this.txtboxFirstInput.Name = "txtboxFirstInput";
			this.txtboxFirstInput.Size = new System.Drawing.Size(253, 29);
			this.txtboxFirstInput.TabIndex = 16;
			// 
			// txtboxLastInput
			// 
			this.txtboxLastInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtboxLastInput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxLastInput.Location = new System.Drawing.Point(494, 41);
			this.txtboxLastInput.Name = "txtboxLastInput";
			this.txtboxLastInput.Size = new System.Drawing.Size(253, 29);
			this.txtboxLastInput.TabIndex = 17;
			// 
			// txtboxCityInput
			// 
			this.txtboxCityInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtboxCityInput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxCityInput.Location = new System.Drawing.Point(494, 123);
			this.txtboxCityInput.Name = "txtboxCityInput";
			this.txtboxCityInput.Size = new System.Drawing.Size(253, 29);
			this.txtboxCityInput.TabIndex = 18;
			// 
			// txtboxAddressInput
			// 
			this.txtboxAddressInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtboxAddressInput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxAddressInput.Location = new System.Drawing.Point(102, 123);
			this.txtboxAddressInput.Name = "txtboxAddressInput";
			this.txtboxAddressInput.Size = new System.Drawing.Size(253, 29);
			this.txtboxAddressInput.TabIndex = 19;
			// 
			// txtboxStateInput
			// 
			this.txtboxStateInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtboxStateInput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxStateInput.Location = new System.Drawing.Point(102, 201);
			this.txtboxStateInput.Name = "txtboxStateInput";
			this.txtboxStateInput.Size = new System.Drawing.Size(253, 29);
			this.txtboxStateInput.TabIndex = 20;
			// 
			// txtboxZipcodeInput
			// 
			this.txtboxZipcodeInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtboxZipcodeInput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxZipcodeInput.Location = new System.Drawing.Point(494, 201);
			this.txtboxZipcodeInput.Name = "txtboxZipcodeInput";
			this.txtboxZipcodeInput.Size = new System.Drawing.Size(253, 29);
			this.txtboxZipcodeInput.TabIndex = 21;
			// 
			// txtboxPhoneInput
			// 
			this.txtboxPhoneInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtboxPhoneInput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxPhoneInput.Location = new System.Drawing.Point(101, 278);
			this.txtboxPhoneInput.Name = "txtboxPhoneInput";
			this.txtboxPhoneInput.Size = new System.Drawing.Size(253, 29);
			this.txtboxPhoneInput.TabIndex = 22;
			// 
			// txtboxEmailInput
			// 
			this.txtboxEmailInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtboxEmailInput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxEmailInput.Location = new System.Drawing.Point(494, 278);
			this.txtboxEmailInput.Name = "txtboxEmailInput";
			this.txtboxEmailInput.Size = new System.Drawing.Size(253, 29);
			this.txtboxEmailInput.TabIndex = 23;
			// 
			// lblMemberId
			// 
			this.lblMemberId.AutoSize = true;
			this.lblMemberId.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMemberId.Location = new System.Drawing.Point(362, 352);
			this.lblMemberId.Name = "lblMemberId";
			this.lblMemberId.Size = new System.Drawing.Size(108, 23);
			this.lblMemberId.TabIndex = 24;
			this.lblMemberId.Text = "Member ID:";
			// 
			// txtBoxMemberIdInput
			// 
			this.txtBoxMemberIdInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtBoxMemberIdInput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBoxMemberIdInput.Location = new System.Drawing.Point(494, 346);
			this.txtBoxMemberIdInput.Name = "txtBoxMemberIdInput";
			this.txtBoxMemberIdInput.Size = new System.Drawing.Size(253, 29);
			this.txtBoxMemberIdInput.TabIndex = 25;
			// 
			// AddMember
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1003, 528);
			this.Controls.Add(this.grpboxMember);
			this.Controls.Add(this.btnSaveBook);
			this.Controls.Add(this.pnlHeader);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AddMember";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddMember";
			this.pnlHeader.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picFormIcon)).EndInit();
			this.grpboxMember.ResumeLayout(false);
			this.grpboxMember.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlHeader;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label lblFormTitle;
		private System.Windows.Forms.PictureBox picFormIcon;
		private System.Windows.Forms.Button btnSaveBook;
		private System.Windows.Forms.GroupBox grpboxMember;
		private System.Windows.Forms.Label lblZip;
		private System.Windows.Forms.Label lblState;
		private System.Windows.Forms.Label lblLastName;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblPhone;
		private System.Windows.Forms.Label lblCity;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.Label lblFirstName;
		private System.Windows.Forms.TextBox txtboxEmailInput;
		private System.Windows.Forms.TextBox txtboxPhoneInput;
		private System.Windows.Forms.TextBox txtboxZipcodeInput;
		private System.Windows.Forms.TextBox txtboxStateInput;
		private System.Windows.Forms.TextBox txtboxAddressInput;
		private System.Windows.Forms.TextBox txtboxCityInput;
		private System.Windows.Forms.TextBox txtboxLastInput;
		private System.Windows.Forms.TextBox txtboxFirstInput;
		private System.Windows.Forms.TextBox txtBoxMemberIdInput;
		private System.Windows.Forms.Label lblMemberId;
	}
}