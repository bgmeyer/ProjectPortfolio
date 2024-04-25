namespace CTRL_ALT_ELITE_GroupProject
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlNavBar = new System.Windows.Forms.Panel();
            this.btnFormNbaTeams = new System.Windows.Forms.Button();
            this.btnFormNbaPlayers = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnFormNflPlayers = new System.Windows.Forms.Button();
            this.btnFormNflTeams = new System.Windows.Forms.Button();
            this.btnFormMatches = new System.Windows.Forms.Button();
            this.btnFormDashboard = new System.Windows.Forms.Button();
            this.pnlUserInfo = new System.Windows.Forms.Panel();
            this.btnFormSettings = new System.Windows.Forms.Button();
            this.pnlDisplaysSelectForm = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlNavBar.SuspendLayout();
            this.pnlUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(53, 11);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(192, 19);
            this.lblFormTitle.TabIndex = 1;
            this.lblFormTitle.Text = "Football Tracking Program";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1212, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 34);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(44)))), ((int)(((byte)(86)))));
            this.pnlHeader.Controls.Add(this.picLogo);
            this.pnlHeader.Controls.Add(this.lblFormTitle);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1251, 58);
            this.pnlHeader.TabIndex = 1;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(7, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(42, 35);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // pnlNavBar
            // 
            this.pnlNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(44)))), ((int)(((byte)(86)))));
            this.pnlNavBar.Controls.Add(this.btnFormNbaTeams);
            this.pnlNavBar.Controls.Add(this.btnFormNbaPlayers);
            this.pnlNavBar.Controls.Add(this.btnLogout);
            this.pnlNavBar.Controls.Add(this.btnFormNflPlayers);
            this.pnlNavBar.Controls.Add(this.btnFormNflTeams);
            this.pnlNavBar.Controls.Add(this.btnFormMatches);
            this.pnlNavBar.Controls.Add(this.btnFormDashboard);
            this.pnlNavBar.Controls.Add(this.pnlUserInfo);
            this.pnlNavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavBar.Location = new System.Drawing.Point(0, 58);
            this.pnlNavBar.Name = "pnlNavBar";
            this.pnlNavBar.Size = new System.Drawing.Size(216, 590);
            this.pnlNavBar.TabIndex = 2;
            // 
            // btnFormNbaTeams
            // 
            this.btnFormNbaTeams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(156)))));
            this.btnFormNbaTeams.FlatAppearance.BorderSize = 0;
            this.btnFormNbaTeams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormNbaTeams.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormNbaTeams.ForeColor = System.Drawing.Color.White;
            this.btnFormNbaTeams.Image = ((System.Drawing.Image)(resources.GetObject("btnFormNbaTeams.Image")));
            this.btnFormNbaTeams.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormNbaTeams.Location = new System.Drawing.Point(0, 405);
            this.btnFormNbaTeams.Name = "btnFormNbaTeams";
            this.btnFormNbaTeams.Size = new System.Drawing.Size(216, 57);
            this.btnFormNbaTeams.TabIndex = 10;
            this.btnFormNbaTeams.Text = "          NBA Teams";
            this.btnFormNbaTeams.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFormNbaTeams.UseVisualStyleBackColor = false;
            this.btnFormNbaTeams.Click += new System.EventHandler(this.btnFormNbaTeams_Click);
            // 
            // btnFormNbaPlayers
            // 
            this.btnFormNbaPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(156)))));
            this.btnFormNbaPlayers.FlatAppearance.BorderSize = 0;
            this.btnFormNbaPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormNbaPlayers.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormNbaPlayers.ForeColor = System.Drawing.Color.White;
            this.btnFormNbaPlayers.Image = ((System.Drawing.Image)(resources.GetObject("btnFormNbaPlayers.Image")));
            this.btnFormNbaPlayers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormNbaPlayers.Location = new System.Drawing.Point(1, 468);
            this.btnFormNbaPlayers.Name = "btnFormNbaPlayers";
            this.btnFormNbaPlayers.Size = new System.Drawing.Size(216, 57);
            this.btnFormNbaPlayers.TabIndex = 9;
            this.btnFormNbaPlayers.Text = "         NBA  Players";
            this.btnFormNbaPlayers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFormNbaPlayers.UseVisualStyleBackColor = false;
            this.btnFormNbaPlayers.Click += new System.EventHandler(this.btnFormNbaPlayers_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(156)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.Location = new System.Drawing.Point(0, 546);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(216, 57);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnFormNflPlayers
            // 
            this.btnFormNflPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(156)))));
            this.btnFormNflPlayers.FlatAppearance.BorderSize = 0;
            this.btnFormNflPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormNflPlayers.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormNflPlayers.ForeColor = System.Drawing.Color.White;
            this.btnFormNflPlayers.Image = ((System.Drawing.Image)(resources.GetObject("btnFormNflPlayers.Image")));
            this.btnFormNflPlayers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormNflPlayers.Location = new System.Drawing.Point(0, 341);
            this.btnFormNflPlayers.Name = "btnFormNflPlayers";
            this.btnFormNflPlayers.Size = new System.Drawing.Size(216, 57);
            this.btnFormNflPlayers.TabIndex = 7;
            this.btnFormNflPlayers.Text = "             NFL  Players";
            this.btnFormNflPlayers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFormNflPlayers.UseVisualStyleBackColor = false;
            this.btnFormNflPlayers.Click += new System.EventHandler(this.BtnFormPlayers_Click);
            // 
            // btnFormNflTeams
            // 
            this.btnFormNflTeams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(156)))));
            this.btnFormNflTeams.FlatAppearance.BorderSize = 0;
            this.btnFormNflTeams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormNflTeams.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormNflTeams.ForeColor = System.Drawing.Color.White;
            this.btnFormNflTeams.Image = ((System.Drawing.Image)(resources.GetObject("btnFormNflTeams.Image")));
            this.btnFormNflTeams.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormNflTeams.Location = new System.Drawing.Point(0, 276);
            this.btnFormNflTeams.Name = "btnFormNflTeams";
            this.btnFormNflTeams.Size = new System.Drawing.Size(216, 57);
            this.btnFormNflTeams.TabIndex = 6;
            this.btnFormNflTeams.Text = "             NFL Teams";
            this.btnFormNflTeams.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFormNflTeams.UseVisualStyleBackColor = false;
            this.btnFormNflTeams.Click += new System.EventHandler(this.BtnFormTeams_Click);
            // 
            // btnFormMatches
            // 
            this.btnFormMatches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(156)))));
            this.btnFormMatches.FlatAppearance.BorderSize = 0;
            this.btnFormMatches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormMatches.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormMatches.ForeColor = System.Drawing.Color.White;
            this.btnFormMatches.Image = ((System.Drawing.Image)(resources.GetObject("btnFormMatches.Image")));
            this.btnFormMatches.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormMatches.Location = new System.Drawing.Point(0, 211);
            this.btnFormMatches.Name = "btnFormMatches";
            this.btnFormMatches.Size = new System.Drawing.Size(216, 57);
            this.btnFormMatches.TabIndex = 5;
            this.btnFormMatches.Text = "             Matches";
            this.btnFormMatches.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFormMatches.UseVisualStyleBackColor = false;
            this.btnFormMatches.Click += new System.EventHandler(this.BtnFormMatches_Click);
            // 
            // btnFormDashboard
            // 
            this.btnFormDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(156)))));
            this.btnFormDashboard.FlatAppearance.BorderSize = 0;
            this.btnFormDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormDashboard.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormDashboard.ForeColor = System.Drawing.Color.White;
            this.btnFormDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnFormDashboard.Image")));
            this.btnFormDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormDashboard.Location = new System.Drawing.Point(0, 146);
            this.btnFormDashboard.Name = "btnFormDashboard";
            this.btnFormDashboard.Size = new System.Drawing.Size(216, 57);
            this.btnFormDashboard.TabIndex = 4;
            this.btnFormDashboard.Text = "            Dashboard";
            this.btnFormDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFormDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFormDashboard.UseVisualStyleBackColor = false;
            this.btnFormDashboard.Click += new System.EventHandler(this.BtnFormDashboard_Click);
            // 
            // pnlUserInfo
            // 
            this.pnlUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(44)))), ((int)(((byte)(86)))));
            this.pnlUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUserInfo.Controls.Add(this.btnFormSettings);
            this.pnlUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlUserInfo.Name = "pnlUserInfo";
            this.pnlUserInfo.Size = new System.Drawing.Size(216, 118);
            this.pnlUserInfo.TabIndex = 3;
            // 
            // btnFormSettings
            // 
            this.btnFormSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(156)))));
            this.btnFormSettings.FlatAppearance.BorderSize = 0;
            this.btnFormSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormSettings.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormSettings.ForeColor = System.Drawing.Color.White;
            this.btnFormSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnFormSettings.Image")));
            this.btnFormSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFormSettings.Location = new System.Drawing.Point(0, -1);
            this.btnFormSettings.Name = "btnFormSettings";
            this.btnFormSettings.Size = new System.Drawing.Size(216, 118);
            this.btnFormSettings.TabIndex = 9;
            this.btnFormSettings.Text = "Logged In Users Name";
            this.btnFormSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFormSettings.UseVisualStyleBackColor = false;
            this.btnFormSettings.Click += new System.EventHandler(this.BtnFormSettings_Click);
            // 
            // pnlDisplaysSelectForm
            // 
            this.pnlDisplaysSelectForm.BackColor = System.Drawing.Color.White;
            this.pnlDisplaysSelectForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisplaysSelectForm.Location = new System.Drawing.Point(216, 58);
            this.pnlDisplaysSelectForm.Name = "pnlDisplaysSelectForm";
            this.pnlDisplaysSelectForm.Size = new System.Drawing.Size(1035, 590);
            this.pnlDisplaysSelectForm.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 648);
            this.Controls.Add(this.pnlDisplaysSelectForm);
            this.Controls.Add(this.pnlNavBar);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlNavBar.ResumeLayout(false);
            this.pnlUserInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlNavBar;
        private System.Windows.Forms.Panel pnlUserInfo;
        private System.Windows.Forms.Panel pnlDisplaysSelectForm;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnFormNflPlayers;
        private System.Windows.Forms.Button btnFormNflTeams;
        private System.Windows.Forms.Button btnFormMatches;
        private System.Windows.Forms.Button btnFormDashboard;
        private System.Windows.Forms.Button btnFormSettings;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnFormNbaPlayers;
        private System.Windows.Forms.Button btnFormNbaTeams;
    }
}