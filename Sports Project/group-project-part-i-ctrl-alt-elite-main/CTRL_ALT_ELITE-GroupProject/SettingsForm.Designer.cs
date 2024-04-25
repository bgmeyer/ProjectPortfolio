namespace CTRL_ALT_ELITE_GroupProject
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.pnlFormTitleBar = new System.Windows.Forms.Panel();
            this.picFormIcon = new System.Windows.Forms.PictureBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblOutputPlayerName = new System.Windows.Forms.Label();
            this.lblFavPlayers = new System.Windows.Forms.Label();
            this.lblFavTeam = new System.Windows.Forms.Label();
            this.btnEditFavorites = new System.Windows.Forms.Button();
            this.groupBoxUserInfo = new System.Windows.Forms.GroupBox();
            this.lblOutputUserName = new System.Windows.Forms.Label();
            this.lblOutputLastName = new System.Windows.Forms.Label();
            this.lblOutputFirstName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.flowpanelFavPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.userControlFavNFLPlayer = new CTRL_ALT_ELITE_GroupProject.userControlFavNFLPlayers();
            this.userControlFavNBAPlayer = new CTRL_ALT_ELITE_GroupProject.userControlFavNFLPlayers();
            this.flowpanelFavTeams = new System.Windows.Forms.FlowLayoutPanel();
            this.userControlFavNFLTeam = new CTRL_ALT_ELITE_GroupProject.userControlFavNFLPlayers();
            this.userControlFavNBATeam = new CTRL_ALT_ELITE_GroupProject.userControlFavNFLPlayers();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlFormTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFormIcon)).BeginInit();
            this.groupBoxUserInfo.SuspendLayout();
            this.flowpanelFavPlayers.SuspendLayout();
            this.flowpanelFavTeams.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormTitleBar
            // 
            this.pnlFormTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(156)))));
            this.pnlFormTitleBar.Controls.Add(this.btnRefresh);
            this.pnlFormTitleBar.Controls.Add(this.picFormIcon);
            this.pnlFormTitleBar.Controls.Add(this.lblFormTitle);
            this.pnlFormTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlFormTitleBar.Name = "pnlFormTitleBar";
            this.pnlFormTitleBar.Size = new System.Drawing.Size(1035, 52);
            this.pnlFormTitleBar.TabIndex = 1;
            // 
            // picFormIcon
            // 
            this.picFormIcon.Image = ((System.Drawing.Image)(resources.GetObject("picFormIcon.Image")));
            this.picFormIcon.Location = new System.Drawing.Point(5, 5);
            this.picFormIcon.Name = "picFormIcon";
            this.picFormIcon.Size = new System.Drawing.Size(45, 41);
            this.picFormIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFormIcon.TabIndex = 5;
            this.picFormIcon.TabStop = false;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(56, 5);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(117, 41);
            this.lblFormTitle.TabIndex = 4;
            this.lblFormTitle.Text = "Settings";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutputPlayerName
            // 
            this.lblOutputPlayerName.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputPlayerName.Location = new System.Drawing.Point(26, 74);
            this.lblOutputPlayerName.Name = "lblOutputPlayerName";
            this.lblOutputPlayerName.Size = new System.Drawing.Size(247, 23);
            this.lblOutputPlayerName.TabIndex = 14;
            this.lblOutputPlayerName.Text = "Hello, \"Users Name\"";
            this.lblOutputPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFavPlayers
            // 
            this.lblFavPlayers.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavPlayers.Location = new System.Drawing.Point(546, 74);
            this.lblFavPlayers.Name = "lblFavPlayers";
            this.lblFavPlayers.Size = new System.Drawing.Size(125, 23);
            this.lblFavPlayers.TabIndex = 23;
            this.lblFavPlayers.Text = "Favorite Player:";
            this.lblFavPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFavTeam
            // 
            this.lblFavTeam.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavTeam.Location = new System.Drawing.Point(546, 325);
            this.lblFavTeam.Name = "lblFavTeam";
            this.lblFavTeam.Size = new System.Drawing.Size(125, 23);
            this.lblFavTeam.TabIndex = 25;
            this.lblFavTeam.Text = "Favorite Team:";
            this.lblFavTeam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEditFavorites
            // 
            this.btnEditFavorites.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditFavorites.Location = new System.Drawing.Point(153, 399);
            this.btnEditFavorites.Name = "btnEditFavorites";
            this.btnEditFavorites.Size = new System.Drawing.Size(141, 52);
            this.btnEditFavorites.TabIndex = 26;
            this.btnEditFavorites.Text = "Edit Favorite Teams or Players";
            this.btnEditFavorites.UseVisualStyleBackColor = true;
            this.btnEditFavorites.Click += new System.EventHandler(this.btnEditFavorites_Click);
            // 
            // groupBoxUserInfo
            // 
            this.groupBoxUserInfo.Controls.Add(this.lblOutputUserName);
            this.groupBoxUserInfo.Controls.Add(this.lblOutputLastName);
            this.groupBoxUserInfo.Controls.Add(this.lblOutputFirstName);
            this.groupBoxUserInfo.Controls.Add(this.lblUserName);
            this.groupBoxUserInfo.Controls.Add(this.lblLastName);
            this.groupBoxUserInfo.Controls.Add(this.lblFirstName);
            this.groupBoxUserInfo.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUserInfo.Location = new System.Drawing.Point(60, 106);
            this.groupBoxUserInfo.Name = "groupBoxUserInfo";
            this.groupBoxUserInfo.Size = new System.Drawing.Size(338, 197);
            this.groupBoxUserInfo.TabIndex = 27;
            this.groupBoxUserInfo.TabStop = false;
            this.groupBoxUserInfo.Text = "User Information";
            // 
            // lblOutputUserName
            // 
            this.lblOutputUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutputUserName.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputUserName.Location = new System.Drawing.Point(126, 128);
            this.lblOutputUserName.Name = "lblOutputUserName";
            this.lblOutputUserName.Size = new System.Drawing.Size(187, 30);
            this.lblOutputUserName.TabIndex = 27;
            this.lblOutputUserName.Text = "Output";
            this.lblOutputUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutputLastName
            // 
            this.lblOutputLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutputLastName.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputLastName.Location = new System.Drawing.Point(126, 82);
            this.lblOutputLastName.Name = "lblOutputLastName";
            this.lblOutputLastName.Size = new System.Drawing.Size(187, 30);
            this.lblOutputLastName.TabIndex = 26;
            this.lblOutputLastName.Text = "Output";
            this.lblOutputLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutputFirstName
            // 
            this.lblOutputFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutputFirstName.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputFirstName.Location = new System.Drawing.Point(126, 37);
            this.lblOutputFirstName.Name = "lblOutputFirstName";
            this.lblOutputFirstName.Size = new System.Drawing.Size(187, 30);
            this.lblOutputFirstName.TabIndex = 25;
            this.lblOutputFirstName.Text = "Output";
            this.lblOutputFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(26, 132);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(94, 23);
            this.lblUserName.TabIndex = 24;
            this.lblUserName.Text = "UserName:";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLastName
            // 
            this.lblLastName.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(26, 85);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(94, 23);
            this.lblLastName.TabIndex = 23;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(26, 41);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(94, 23);
            this.lblFirstName.TabIndex = 22;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowpanelFavPlayers
            // 
            this.flowpanelFavPlayers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowpanelFavPlayers.Controls.Add(this.userControlFavNFLPlayer);
            this.flowpanelFavPlayers.Controls.Add(this.userControlFavNBAPlayer);
            this.flowpanelFavPlayers.Location = new System.Drawing.Point(614, 100);
            this.flowpanelFavPlayers.Name = "flowpanelFavPlayers";
            this.flowpanelFavPlayers.Size = new System.Drawing.Size(340, 203);
            this.flowpanelFavPlayers.TabIndex = 30;
            // 
            // userControlFavNFLPlayer
            // 
            this.userControlFavNFLPlayer.Icon = ((System.Drawing.Image)(resources.GetObject("userControlFavNFLPlayer.Icon")));
            this.userControlFavNFLPlayer.Location = new System.Drawing.Point(3, 3);
            this.userControlFavNFLPlayer.Name = "userControlFavNFLPlayer";
            this.userControlFavNFLPlayer.PlayersName = "";
            this.userControlFavNFLPlayer.PlayerTitle = "Favorite NFL Player:";
            this.userControlFavNFLPlayer.Size = new System.Drawing.Size(329, 95);
            this.userControlFavNFLPlayer.TabIndex = 0;
            // 
            // userControlFavNBAPlayer
            // 
            this.userControlFavNBAPlayer.Icon = ((System.Drawing.Image)(resources.GetObject("userControlFavNBAPlayer.Icon")));
            this.userControlFavNBAPlayer.Location = new System.Drawing.Point(3, 104);
            this.userControlFavNBAPlayer.Name = "userControlFavNBAPlayer";
            this.userControlFavNBAPlayer.PlayersName = "";
            this.userControlFavNBAPlayer.PlayerTitle = "Favorite NBA Player:";
            this.userControlFavNBAPlayer.Size = new System.Drawing.Size(329, 95);
            this.userControlFavNBAPlayer.TabIndex = 1;
            // 
            // flowpanelFavTeams
            // 
            this.flowpanelFavTeams.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowpanelFavTeams.Controls.Add(this.userControlFavNFLTeam);
            this.flowpanelFavTeams.Controls.Add(this.userControlFavNBATeam);
            this.flowpanelFavTeams.Location = new System.Drawing.Point(614, 361);
            this.flowpanelFavTeams.Name = "flowpanelFavTeams";
            this.flowpanelFavTeams.Size = new System.Drawing.Size(340, 203);
            this.flowpanelFavTeams.TabIndex = 31;
            // 
            // userControlFavNFLTeam
            // 
            this.userControlFavNFLTeam.Icon = ((System.Drawing.Image)(resources.GetObject("userControlFavNFLTeam.Icon")));
            this.userControlFavNFLTeam.Location = new System.Drawing.Point(3, 3);
            this.userControlFavNFLTeam.Name = "userControlFavNFLTeam";
            this.userControlFavNFLTeam.PlayersName = "";
            this.userControlFavNFLTeam.PlayerTitle = "Favorite NFL Team:";
            this.userControlFavNFLTeam.Size = new System.Drawing.Size(329, 95);
            this.userControlFavNFLTeam.TabIndex = 0;
            // 
            // userControlFavNBATeam
            // 
            this.userControlFavNBATeam.Icon = ((System.Drawing.Image)(resources.GetObject("userControlFavNBATeam.Icon")));
            this.userControlFavNBATeam.Location = new System.Drawing.Point(3, 104);
            this.userControlFavNBATeam.Name = "userControlFavNBATeam";
            this.userControlFavNBATeam.PlayersName = "";
            this.userControlFavNBATeam.PlayerTitle = "Favorite NBA Team:";
            this.userControlFavNBATeam.Size = new System.Drawing.Size(329, 95);
            this.userControlFavNBATeam.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(942, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(81, 33);
            this.btnRefresh.TabIndex = 32;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1035, 606);
            this.Controls.Add(this.flowpanelFavTeams);
            this.Controls.Add(this.flowpanelFavPlayers);
            this.Controls.Add(this.groupBoxUserInfo);
            this.Controls.Add(this.btnEditFavorites);
            this.Controls.Add(this.lblFavTeam);
            this.Controls.Add(this.lblFavPlayers);
            this.Controls.Add(this.lblOutputPlayerName);
            this.Controls.Add(this.pnlFormTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.pnlFormTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFormIcon)).EndInit();
            this.groupBoxUserInfo.ResumeLayout(false);
            this.flowpanelFavPlayers.ResumeLayout(false);
            this.flowpanelFavTeams.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormTitleBar;
        private System.Windows.Forms.PictureBox picFormIcon;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblOutputPlayerName;
        private System.Windows.Forms.Label lblFavPlayers;
        private System.Windows.Forms.Label lblFavTeam;
        private System.Windows.Forms.Button btnEditFavorites;
        private System.Windows.Forms.GroupBox groupBoxUserInfo;
        private System.Windows.Forms.Label lblOutputUserName;
        private System.Windows.Forms.Label lblOutputLastName;
        private System.Windows.Forms.Label lblOutputFirstName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        public userControlFavNFLPlayers userControlFavNFLPlayer;
        public userControlFavNFLPlayers userControlFavNBAPlayer;
        public userControlFavNFLPlayers userControlFavNFLTeam;
        public userControlFavNFLPlayers userControlFavNBATeam;
        public System.Windows.Forms.FlowLayoutPanel flowpanelFavPlayers;
        public System.Windows.Forms.FlowLayoutPanel flowpanelFavTeams;
        private System.Windows.Forms.Button btnRefresh;
    }
}