namespace CTRL_ALT_ELITE_GroupProject
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.pnlFormTitleBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNFL = new System.Windows.Forms.Button();
            this.btnNBA = new System.Windows.Forms.Button();
            this.picFormIcon = new System.Windows.Forms.PictureBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblOutputTopTeamLosses = new System.Windows.Forms.Label();
            this.lblTTLosses = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblOutputTopTeamWins = new System.Windows.Forms.Label();
            this.lblTTWins = new System.Windows.Forms.Label();
            this.lblOutputTopTeamName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblOutputTopPlayerName = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblOutputTopPlayerPoints = new System.Windows.Forms.Label();
            this.lblTPPoints = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblOpponentTeamScore = new System.Windows.Forms.Label();
            this.lblOutputWinnerScore = new System.Windows.Forms.Label();
            this.lblOutputLastMatchResult = new System.Windows.Forms.Label();
            this.lblOutputRecentGameTeam = new System.Windows.Forms.Label();
            this.lblRecentGame = new System.Windows.Forms.Label();
            this.lblTopTeam = new System.Windows.Forms.Label();
            this.lblTopPlayer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlFormTitleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFormIcon)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFormTitleBar
            // 
            this.pnlFormTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(156)))));
            this.pnlFormTitleBar.Controls.Add(this.panel1);
            this.pnlFormTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlFormTitleBar.Name = "pnlFormTitleBar";
            this.pnlFormTitleBar.Size = new System.Drawing.Size(1035, 52);
            this.pnlFormTitleBar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.btnNFL);
            this.panel1.Controls.Add(this.btnNBA);
            this.panel1.Controls.Add(this.picFormIcon);
            this.panel1.Controls.Add(this.lblFormTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 52);
            this.panel1.TabIndex = 1;
            // 
            // btnNFL
            // 
            this.btnNFL.Location = new System.Drawing.Point(849, 12);
            this.btnNFL.Name = "btnNFL";
            this.btnNFL.Size = new System.Drawing.Size(84, 27);
            this.btnNFL.TabIndex = 7;
            this.btnNFL.Text = "NFL";
            this.btnNFL.UseVisualStyleBackColor = true;
            this.btnNFL.Visible = false;
            this.btnNFL.Click += new System.EventHandler(this.btnNFL_Click);
            // 
            // btnNBA
            // 
            this.btnNBA.Location = new System.Drawing.Point(939, 12);
            this.btnNBA.Name = "btnNBA";
            this.btnNBA.Size = new System.Drawing.Size(84, 27);
            this.btnNBA.TabIndex = 6;
            this.btnNBA.Text = "NBA";
            this.btnNBA.UseVisualStyleBackColor = true;
            this.btnNBA.Click += new System.EventHandler(this.btnNBA_Click);
            // 
            // picFormIcon
            // 
            this.picFormIcon.Image = ((System.Drawing.Image)(resources.GetObject("picFormIcon.Image")));
            this.picFormIcon.Location = new System.Drawing.Point(5, 5);
            this.picFormIcon.Name = "picFormIcon";
            this.picFormIcon.Size = new System.Drawing.Size(45, 41);
            this.picFormIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFormIcon.TabIndex = 3;
            this.picFormIcon.TabStop = false;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(56, 5);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(117, 41);
            this.lblFormTitle.TabIndex = 2;
            this.lblFormTitle.Text = "Dashboard";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(149)))), ((int)(((byte)(90)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.lblOutputTopTeamName);
            this.panel2.Location = new System.Drawing.Point(731, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 131);
            this.panel2.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.lblOutputTopTeamLosses);
            this.panel7.Controls.Add(this.lblTTLosses);
            this.panel7.Location = new System.Drawing.Point(141, 37);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(96, 87);
            this.panel7.TabIndex = 1;
            // 
            // lblOutputTopTeamLosses
            // 
            this.lblOutputTopTeamLosses.BackColor = System.Drawing.Color.Transparent;
            this.lblOutputTopTeamLosses.Font = new System.Drawing.Font("Corbel", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputTopTeamLosses.ForeColor = System.Drawing.Color.White;
            this.lblOutputTopTeamLosses.Location = new System.Drawing.Point(14, 25);
            this.lblOutputTopTeamLosses.Name = "lblOutputTopTeamLosses";
            this.lblOutputTopTeamLosses.Size = new System.Drawing.Size(67, 51);
            this.lblOutputTopTeamLosses.TabIndex = 12;
            this.lblOutputTopTeamLosses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTTLosses
            // 
            this.lblTTLosses.BackColor = System.Drawing.Color.Transparent;
            this.lblTTLosses.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTLosses.ForeColor = System.Drawing.Color.White;
            this.lblTTLosses.Location = new System.Drawing.Point(13, 2);
            this.lblTTLosses.Name = "lblTTLosses";
            this.lblTTLosses.Size = new System.Drawing.Size(68, 23);
            this.lblTTLosses.TabIndex = 12;
            this.lblTTLosses.Text = "Losses";
            this.lblTTLosses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lblOutputTopTeamWins);
            this.panel6.Controls.Add(this.lblTTWins);
            this.panel6.Location = new System.Drawing.Point(11, 37);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(96, 87);
            this.panel6.TabIndex = 0;
            // 
            // lblOutputTopTeamWins
            // 
            this.lblOutputTopTeamWins.BackColor = System.Drawing.Color.Transparent;
            this.lblOutputTopTeamWins.Font = new System.Drawing.Font("Corbel", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputTopTeamWins.ForeColor = System.Drawing.Color.White;
            this.lblOutputTopTeamWins.Location = new System.Drawing.Point(14, 25);
            this.lblOutputTopTeamWins.Name = "lblOutputTopTeamWins";
            this.lblOutputTopTeamWins.Size = new System.Drawing.Size(67, 51);
            this.lblOutputTopTeamWins.TabIndex = 12;
            this.lblOutputTopTeamWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTTWins
            // 
            this.lblTTWins.BackColor = System.Drawing.Color.Transparent;
            this.lblTTWins.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTWins.ForeColor = System.Drawing.Color.White;
            this.lblTTWins.Location = new System.Drawing.Point(21, 2);
            this.lblTTWins.Name = "lblTTWins";
            this.lblTTWins.Size = new System.Drawing.Size(52, 23);
            this.lblTTWins.TabIndex = 11;
            this.lblTTWins.Text = "Wins";
            this.lblTTWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutputTopTeamName
            // 
            this.lblOutputTopTeamName.BackColor = System.Drawing.Color.Transparent;
            this.lblOutputTopTeamName.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputTopTeamName.ForeColor = System.Drawing.Color.White;
            this.lblOutputTopTeamName.Location = new System.Drawing.Point(7, 7);
            this.lblOutputTopTeamName.Name = "lblOutputTopTeamName";
            this.lblOutputTopTeamName.Size = new System.Drawing.Size(230, 23);
            this.lblOutputTopTeamName.TabIndex = 10;
            this.lblOutputTopTeamName.Text = "Teams Name";
            this.lblOutputTopTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(149)))), ((int)(((byte)(90)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblOutputTopPlayerName);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Location = new System.Drawing.Point(731, 276);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(256, 131);
            this.panel3.TabIndex = 5;
            // 
            // lblOutputTopPlayerName
            // 
            this.lblOutputTopPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.lblOutputTopPlayerName.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputTopPlayerName.ForeColor = System.Drawing.Color.White;
            this.lblOutputTopPlayerName.Location = new System.Drawing.Point(11, 6);
            this.lblOutputTopPlayerName.Name = "lblOutputTopPlayerName";
            this.lblOutputTopPlayerName.Size = new System.Drawing.Size(230, 23);
            this.lblOutputTopPlayerName.TabIndex = 13;
            this.lblOutputTopPlayerName.Text = "Players Name";
            this.lblOutputTopPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.lblOutputTopPlayerPoints);
            this.panel9.Controls.Add(this.lblTPPoints);
            this.panel9.Location = new System.Drawing.Point(15, 34);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(226, 87);
            this.panel9.TabIndex = 11;
            // 
            // lblOutputTopPlayerPoints
            // 
            this.lblOutputTopPlayerPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblOutputTopPlayerPoints.Font = new System.Drawing.Font("Corbel", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputTopPlayerPoints.ForeColor = System.Drawing.Color.White;
            this.lblOutputTopPlayerPoints.Location = new System.Drawing.Point(64, 25);
            this.lblOutputTopPlayerPoints.Name = "lblOutputTopPlayerPoints";
            this.lblOutputTopPlayerPoints.Size = new System.Drawing.Size(100, 51);
            this.lblOutputTopPlayerPoints.TabIndex = 12;
            this.lblOutputTopPlayerPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTPPoints
            // 
            this.lblTPPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblTPPoints.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPPoints.ForeColor = System.Drawing.Color.White;
            this.lblTPPoints.Location = new System.Drawing.Point(9, 2);
            this.lblTPPoints.Name = "lblTPPoints";
            this.lblTPPoints.Size = new System.Drawing.Size(204, 23);
            this.lblTPPoints.TabIndex = 11;
            this.lblTPPoints.Text = "Points Earned In Season";
            this.lblTPPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(149)))), ((int)(((byte)(90)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.lblOutputRecentGameTeam);
            this.panel4.Location = new System.Drawing.Point(731, 463);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(256, 131);
            this.panel4.TabIndex = 5;
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.lblOpponentTeamScore);
            this.panel10.Controls.Add(this.lblOutputWinnerScore);
            this.panel10.Controls.Add(this.lblOutputLastMatchResult);
            this.panel10.Location = new System.Drawing.Point(15, 35);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(226, 87);
            this.panel10.TabIndex = 11;
            // 
            // lblOpponentTeamScore
            // 
            this.lblOpponentTeamScore.BackColor = System.Drawing.Color.Transparent;
            this.lblOpponentTeamScore.Font = new System.Drawing.Font("Corbel", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpponentTeamScore.ForeColor = System.Drawing.Color.White;
            this.lblOpponentTeamScore.Location = new System.Drawing.Point(143, 27);
            this.lblOpponentTeamScore.Name = "lblOpponentTeamScore";
            this.lblOpponentTeamScore.Size = new System.Drawing.Size(67, 51);
            this.lblOpponentTeamScore.TabIndex = 13;
            this.lblOpponentTeamScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutputWinnerScore
            // 
            this.lblOutputWinnerScore.BackColor = System.Drawing.Color.Transparent;
            this.lblOutputWinnerScore.Font = new System.Drawing.Font("Corbel", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputWinnerScore.ForeColor = System.Drawing.Color.White;
            this.lblOutputWinnerScore.Location = new System.Drawing.Point(14, 25);
            this.lblOutputWinnerScore.Name = "lblOutputWinnerScore";
            this.lblOutputWinnerScore.Size = new System.Drawing.Size(67, 51);
            this.lblOutputWinnerScore.TabIndex = 12;
            this.lblOutputWinnerScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutputLastMatchResult
            // 
            this.lblOutputLastMatchResult.BackColor = System.Drawing.Color.Transparent;
            this.lblOutputLastMatchResult.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputLastMatchResult.ForeColor = System.Drawing.Color.White;
            this.lblOutputLastMatchResult.Location = new System.Drawing.Point(69, 4);
            this.lblOutputLastMatchResult.Name = "lblOutputLastMatchResult";
            this.lblOutputLastMatchResult.Size = new System.Drawing.Size(82, 23);
            this.lblOutputLastMatchResult.TabIndex = 11;
            this.lblOutputLastMatchResult.Text = "Win";
            this.lblOutputLastMatchResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutputRecentGameTeam
            // 
            this.lblOutputRecentGameTeam.BackColor = System.Drawing.Color.Transparent;
            this.lblOutputRecentGameTeam.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputRecentGameTeam.ForeColor = System.Drawing.Color.White;
            this.lblOutputRecentGameTeam.Location = new System.Drawing.Point(11, 6);
            this.lblOutputRecentGameTeam.Name = "lblOutputRecentGameTeam";
            this.lblOutputRecentGameTeam.Size = new System.Drawing.Size(230, 23);
            this.lblOutputRecentGameTeam.TabIndex = 13;
            this.lblOutputRecentGameTeam.Text = "Teams Name";
            this.lblOutputRecentGameTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecentGame
            // 
            this.lblRecentGame.BackColor = System.Drawing.Color.Transparent;
            this.lblRecentGame.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentGame.ForeColor = System.Drawing.Color.Black;
            this.lblRecentGame.Location = new System.Drawing.Point(484, 471);
            this.lblRecentGame.Name = "lblRecentGame";
            this.lblRecentGame.Size = new System.Drawing.Size(203, 23);
            this.lblRecentGame.TabIndex = 4;
            this.lblRecentGame.Text = "Most Recent Game Winner:";
            this.lblRecentGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTopTeam
            // 
            this.lblTopTeam.BackColor = System.Drawing.Color.Transparent;
            this.lblTopTeam.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopTeam.ForeColor = System.Drawing.Color.Black;
            this.lblTopTeam.Location = new System.Drawing.Point(501, 90);
            this.lblTopTeam.Name = "lblTopTeam";
            this.lblTopTeam.Size = new System.Drawing.Size(186, 23);
            this.lblTopTeam.TabIndex = 8;
            this.lblTopTeam.Text = "Top Team for the Season:";
            this.lblTopTeam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTopPlayer
            // 
            this.lblTopPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lblTopPlayer.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopPlayer.ForeColor = System.Drawing.Color.Black;
            this.lblTopPlayer.Location = new System.Drawing.Point(505, 284);
            this.lblTopPlayer.Name = "lblTopPlayer";
            this.lblTopPlayer.Size = new System.Drawing.Size(182, 23);
            this.lblTopPlayer.TabIndex = 9;
            this.lblTopPlayer.Text = "Highest Scoring Player:";
            this.lblTopPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1035, 606);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTopPlayer);
            this.Controls.Add(this.lblTopTeam);
            this.Controls.Add(this.lblRecentGame);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlFormTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.pnlFormTitleBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFormIcon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormTitleBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picFormIcon;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblRecentGame;
        private System.Windows.Forms.Label lblTopTeam;
        private System.Windows.Forms.Label lblTopPlayer;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblOutputTopTeamLosses;
        private System.Windows.Forms.Label lblTTLosses;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblOutputTopTeamWins;
        private System.Windows.Forms.Label lblTTWins;
        private System.Windows.Forms.Label lblOutputTopTeamName;
        private System.Windows.Forms.Label lblOutputTopPlayerName;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblOutputTopPlayerPoints;
        private System.Windows.Forms.Label lblTPPoints;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lblOpponentTeamScore;
        private System.Windows.Forms.Label lblOutputWinnerScore;
        private System.Windows.Forms.Label lblOutputLastMatchResult;
        private System.Windows.Forms.Label lblOutputRecentGameTeam;
        private System.Windows.Forms.Button btnNFL;
        private System.Windows.Forms.Button btnNBA;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}