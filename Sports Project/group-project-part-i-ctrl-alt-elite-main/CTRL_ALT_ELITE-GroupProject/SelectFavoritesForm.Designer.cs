namespace CTRL_ALT_ELITE_GroupProject
{
    partial class SelectFavoritesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectFavoritesForm));
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.pnlFormTitleBar = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.picFormIcon = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNFLTitle = new System.Windows.Forms.Label();
            this.listboxNBAPlayers = new System.Windows.Forms.ListBox();
            this.listboxNFLPlayers = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listboxNBATeams = new System.Windows.Forms.ListBox();
            this.listboxNFLTeams = new System.Windows.Forms.ListBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pnlFormTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFormIcon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(70, 0);
            this.lblFormTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(218, 63);
            this.lblFormTitle.TabIndex = 4;
            this.lblFormTitle.Text = "Select Favorites:";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFormTitleBar
            // 
            this.pnlFormTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(156)))));
            this.pnlFormTitleBar.Controls.Add(this.btnClose);
            this.pnlFormTitleBar.Controls.Add(this.picFormIcon);
            this.pnlFormTitleBar.Controls.Add(this.lblFormTitle);
            this.pnlFormTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlFormTitleBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlFormTitleBar.Name = "pnlFormTitleBar";
            this.pnlFormTitleBar.Size = new System.Drawing.Size(689, 66);
            this.pnlFormTitleBar.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(626, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(54, 52);
            this.btnClose.TabIndex = 6;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picFormIcon
            // 
            this.picFormIcon.Image = ((System.Drawing.Image)(resources.GetObject("picFormIcon.Image")));
            this.picFormIcon.Location = new System.Drawing.Point(8, 8);
            this.picFormIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picFormIcon.Name = "picFormIcon";
            this.picFormIcon.Size = new System.Drawing.Size(54, 49);
            this.picFormIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFormIcon.TabIndex = 5;
            this.picFormIcon.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblNFLTitle);
            this.groupBox1.Controls.Add(this.listboxNBAPlayers);
            this.groupBox1.Controls.Add(this.listboxNFLPlayers);
            this.groupBox1.Location = new System.Drawing.Point(31, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 217);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Players";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(437, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "NBA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNFLTitle
            // 
            this.lblNFLTitle.AutoSize = true;
            this.lblNFLTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblNFLTitle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNFLTitle.ForeColor = System.Drawing.Color.Black;
            this.lblNFLTitle.Location = new System.Drawing.Point(142, 20);
            this.lblNFLTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNFLTitle.Name = "lblNFLTitle";
            this.lblNFLTitle.Size = new System.Drawing.Size(36, 19);
            this.lblNFLTitle.TabIndex = 7;
            this.lblNFLTitle.Text = "NFL";
            this.lblNFLTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listboxNBAPlayers
            // 
            this.listboxNBAPlayers.FormattingEnabled = true;
            this.listboxNBAPlayers.ItemHeight = 15;
            this.listboxNBAPlayers.Location = new System.Drawing.Point(348, 43);
            this.listboxNBAPlayers.Name = "listboxNBAPlayers";
            this.listboxNBAPlayers.Size = new System.Drawing.Size(224, 124);
            this.listboxNBAPlayers.TabIndex = 1;
            // 
            // listboxNFLPlayers
            // 
            this.listboxNFLPlayers.FormattingEnabled = true;
            this.listboxNFLPlayers.ItemHeight = 15;
            this.listboxNFLPlayers.Location = new System.Drawing.Point(60, 43);
            this.listboxNFLPlayers.Name = "listboxNFLPlayers";
            this.listboxNFLPlayers.Size = new System.Drawing.Size(224, 124);
            this.listboxNFLPlayers.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.listboxNBATeams);
            this.groupBox2.Controls.Add(this.listboxNFLTeams);
            this.groupBox2.Location = new System.Drawing.Point(31, 336);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(622, 217);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Teams";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(437, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "NBA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(142, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "NFL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listboxNBATeams
            // 
            this.listboxNBATeams.FormattingEnabled = true;
            this.listboxNBATeams.ItemHeight = 15;
            this.listboxNBATeams.Location = new System.Drawing.Point(348, 50);
            this.listboxNBATeams.Name = "listboxNBATeams";
            this.listboxNBATeams.Size = new System.Drawing.Size(224, 124);
            this.listboxNBATeams.TabIndex = 3;
            // 
            // listboxNFLTeams
            // 
            this.listboxNFLTeams.FormattingEnabled = true;
            this.listboxNFLTeams.ItemHeight = 15;
            this.listboxNFLTeams.Location = new System.Drawing.Point(60, 50);
            this.listboxNFLTeams.Name = "listboxNFLTeams";
            this.listboxNFLTeams.Size = new System.Drawing.Size(224, 124);
            this.listboxNFLTeams.TabIndex = 2;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(279, 572);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(147, 48);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // SelectFavoritesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(689, 639);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlFormTitleBar);
            this.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SelectFavoritesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectFavoritesForm";
            this.Load += new System.EventHandler(this.SelectFavoritesForm_Load);
            this.pnlFormTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFormIcon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Panel pnlFormTitleBar;
        private System.Windows.Forms.PictureBox picFormIcon;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listboxNBAPlayers;
        private System.Windows.Forms.ListBox listboxNFLPlayers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listboxNBATeams;
        private System.Windows.Forms.ListBox listboxNFLTeams;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblNFLTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}