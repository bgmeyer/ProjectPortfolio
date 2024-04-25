namespace CTRL_ALT_ELITE_GroupProject
{
    partial class CreateUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUserForm));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCreateNewUser = new System.Windows.Forms.Button();
            this.gboxLoginInfo = new System.Windows.Forms.GroupBox();
            this.txtUsersConPassword = new System.Windows.Forms.TextBox();
            this.txtUsersPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserLastName = new System.Windows.Forms.TextBox();
            this.txtUserFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlBackground.SuspendLayout();
            this.gboxLoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.picLogo);
            this.pnlHeader.Controls.Add(this.lblFormTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(611, 38);
            this.pnlHeader.TabIndex = 1;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(3, 3);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(39, 32);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(47, 7);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(153, 24);
            this.lblFormTitle.TabIndex = 1;
            this.lblFormTitle.Text = "Create New User";
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(156)))));
            this.pnlBackground.Controls.Add(this.btnClose);
            this.pnlBackground.Controls.Add(this.btnCreateNewUser);
            this.pnlBackground.Controls.Add(this.gboxLoginInfo);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(0, 38);
            this.pnlBackground.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(611, 387);
            this.pnlBackground.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(325, 322);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 42);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCreateNewUser
            // 
            this.btnCreateNewUser.BackColor = System.Drawing.Color.White;
            this.btnCreateNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNewUser.Location = new System.Drawing.Point(129, 322);
            this.btnCreateNewUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateNewUser.Name = "btnCreateNewUser";
            this.btnCreateNewUser.Size = new System.Drawing.Size(148, 42);
            this.btnCreateNewUser.TabIndex = 17;
            this.btnCreateNewUser.Text = "Create";
            this.btnCreateNewUser.UseVisualStyleBackColor = false;
            this.btnCreateNewUser.Click += new System.EventHandler(this.btnCreateNewUser_Click);
            // 
            // gboxLoginInfo
            // 
            this.gboxLoginInfo.BackColor = System.Drawing.Color.White;
            this.gboxLoginInfo.Controls.Add(this.txtUsersConPassword);
            this.gboxLoginInfo.Controls.Add(this.txtUsersPassword);
            this.gboxLoginInfo.Controls.Add(this.txtUserName);
            this.gboxLoginInfo.Controls.Add(this.txtUserLastName);
            this.gboxLoginInfo.Controls.Add(this.txtUserFirstName);
            this.gboxLoginInfo.Controls.Add(this.label4);
            this.gboxLoginInfo.Controls.Add(this.label3);
            this.gboxLoginInfo.Controls.Add(this.label2);
            this.gboxLoginInfo.Controls.Add(this.label1);
            this.gboxLoginInfo.Controls.Add(this.lblUserName);
            this.gboxLoginInfo.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxLoginInfo.Location = new System.Drawing.Point(75, 34);
            this.gboxLoginInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboxLoginInfo.Name = "gboxLoginInfo";
            this.gboxLoginInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboxLoginInfo.Size = new System.Drawing.Size(464, 274);
            this.gboxLoginInfo.TabIndex = 16;
            this.gboxLoginInfo.TabStop = false;
            this.gboxLoginInfo.Text = "New User Information";
            // 
            // txtUsersConPassword
            // 
            this.txtUsersConPassword.Location = new System.Drawing.Point(192, 218);
            this.txtUsersConPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsersConPassword.Name = "txtUsersConPassword";
            this.txtUsersConPassword.PasswordChar = '*';
            this.txtUsersConPassword.Size = new System.Drawing.Size(205, 27);
            this.txtUsersConPassword.TabIndex = 26;
            // 
            // txtUsersPassword
            // 
            this.txtUsersPassword.Location = new System.Drawing.Point(192, 174);
            this.txtUsersPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsersPassword.Name = "txtUsersPassword";
            this.txtUsersPassword.PasswordChar = '*';
            this.txtUsersPassword.Size = new System.Drawing.Size(205, 27);
            this.txtUsersPassword.TabIndex = 25;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(192, 134);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(205, 27);
            this.txtUserName.TabIndex = 24;
            // 
            // txtUserLastName
            // 
            this.txtUserLastName.Location = new System.Drawing.Point(192, 89);
            this.txtUserLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserLastName.Name = "txtUserLastName";
            this.txtUserLastName.Size = new System.Drawing.Size(205, 27);
            this.txtUserLastName.TabIndex = 23;
            // 
            // txtUserFirstName
            // 
            this.txtUserFirstName.Location = new System.Drawing.Point(192, 46);
            this.txtUserFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserFirstName.Name = "txtUserFirstName";
            this.txtUserFirstName.Size = new System.Drawing.Size(205, 27);
            this.txtUserFirstName.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Confirm Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(83, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(68, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "User Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(72, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Last Name:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(72, 46);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(107, 24);
            this.lblUserName.TabIndex = 17;
            this.lblUserName.Text = "First Name:";
            // 
            // CreateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(611, 425);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateUserForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateUserForm";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlBackground.ResumeLayout(false);
            this.gboxLoginInfo.ResumeLayout(false);
            this.gboxLoginInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.GroupBox gboxLoginInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUsersConPassword;
        private System.Windows.Forms.TextBox txtUsersPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserLastName;
        private System.Windows.Forms.TextBox txtUserFirstName;
        private System.Windows.Forms.Button btnCreateNewUser;
        private System.Windows.Forms.Button btnClose;
    }
}