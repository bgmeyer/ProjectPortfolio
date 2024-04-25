namespace CTRL_ALT_ELITE_GroupProject
{
    partial class userControlUpcomingGame
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userControlUpcomingGame));
            this.picTeamLogo = new System.Windows.Forms.PictureBox();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.lblOpponentName = new System.Windows.Forms.Label();
            this.lblGameDate = new System.Windows.Forms.Label();
            this.lblGameTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picTeamLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picTeamLogo
            // 
            this.picTeamLogo.BackColor = System.Drawing.Color.Transparent;
            this.picTeamLogo.Image = ((System.Drawing.Image)(resources.GetObject("picTeamLogo.Image")));
            this.picTeamLogo.Location = new System.Drawing.Point(116, 45);
            this.picTeamLogo.Name = "picTeamLogo";
            this.picTeamLogo.Size = new System.Drawing.Size(85, 71);
            this.picTeamLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTeamLogo.TabIndex = 0;
            this.picTeamLogo.TabStop = false;
            // 
            // lblTeamName
            // 
            this.lblTeamName.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamName.Location = new System.Drawing.Point(3, 52);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(97, 55);
            this.lblTeamName.TabIndex = 1;
            this.lblTeamName.Text = "Team Name";
            this.lblTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOpponentName
            // 
            this.lblOpponentName.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpponentName.Location = new System.Drawing.Point(210, 52);
            this.lblOpponentName.Name = "lblOpponentName";
            this.lblOpponentName.Size = new System.Drawing.Size(115, 55);
            this.lblOpponentName.TabIndex = 3;
            this.lblOpponentName.Text = "Opponent Name";
            this.lblOpponentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGameDate
            // 
            this.lblGameDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(156)))));
            this.lblGameDate.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameDate.ForeColor = System.Drawing.Color.White;
            this.lblGameDate.Location = new System.Drawing.Point(40, 7);
            this.lblGameDate.Name = "lblGameDate";
            this.lblGameDate.Size = new System.Drawing.Size(140, 23);
            this.lblGameDate.TabIndex = 4;
            this.lblGameDate.Text = "January 01, 2024";
            this.lblGameDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGameTime
            // 
            this.lblGameTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(156)))));
            this.lblGameTime.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTime.ForeColor = System.Drawing.Color.White;
            this.lblGameTime.Location = new System.Drawing.Point(187, 7);
            this.lblGameTime.Name = "lblGameTime";
            this.lblGameTime.Size = new System.Drawing.Size(99, 23);
            this.lblGameTime.TabIndex = 5;
            this.lblGameTime.Text = "8:00 PM";
            this.lblGameTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(156)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 36);
            this.panel1.TabIndex = 6;
            // 
            // userControlUpcomingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblGameTime);
            this.Controls.Add(this.lblGameDate);
            this.Controls.Add(this.lblOpponentName);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.picTeamLogo);
            this.Controls.Add(this.panel1);
            this.Name = "userControlUpcomingGame";
            this.Size = new System.Drawing.Size(325, 129);
            ((System.ComponentModel.ISupportInitialize)(this.picTeamLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picTeamLogo;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Label lblOpponentName;
        private System.Windows.Forms.Label lblGameDate;
        private System.Windows.Forms.Label lblGameTime;
        private System.Windows.Forms.Panel panel1;
    }
}
