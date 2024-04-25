
namespace CTRL_ALT_ELITE_GroupProject
{
    partial class nbaTeamForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nbaTeamForm));
            this.lblRank = new System.Windows.Forms.Label();
            this.lblRankOutput = new System.Windows.Forms.Label();
            this.lblOutputLosses = new System.Windows.Forms.Label();
            this.lblLosses = new System.Windows.Forms.Label();
            this.lblTeamStat = new System.Windows.Forms.Label();
            this.pnlFormTitleBar = new System.Windows.Forms.Panel();
            this.picFormIcon = new System.Windows.Forms.PictureBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblOutputWins = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.groupBoxBasicInfo = new System.Windows.Forms.GroupBox();
            this.lblLocated = new System.Windows.Forms.Label();
            this.lblStateOutput = new System.Windows.Forms.Label();
            this.lblCityOutput = new System.Windows.Forms.Label();
            this.lblOwnerOutput = new System.Windows.Forms.Label();
            this.lblCoachOutput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picTeamLogo = new System.Windows.Forms.PictureBox();
            this.lblOutputTeamName = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.cboxTeamName = new System.Windows.Forms.ComboBox();
            this.groupBoxSeasonInfo = new System.Windows.Forms.GroupBox();
            this.nbaTEAM_STATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nbaTEAM_STATDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlFormTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFormIcon)).BeginInit();
            this.groupBoxBasicInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTeamLogo)).BeginInit();
            this.groupBoxSeasonInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbaTEAM_STATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbaTEAM_STATDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRank
            // 
            this.lblRank.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank.Location = new System.Drawing.Point(19, 186);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(61, 23);
            this.lblRank.TabIndex = 29;
            this.lblRank.Text = "Rank:";
            this.lblRank.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRankOutput
            // 
            this.lblRankOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRankOutput.Location = new System.Drawing.Point(86, 181);
            this.lblRankOutput.Name = "lblRankOutput";
            this.lblRankOutput.Size = new System.Drawing.Size(160, 30);
            this.lblRankOutput.TabIndex = 28;
            this.lblRankOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutputLosses
            // 
            this.lblOutputLosses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutputLosses.Location = new System.Drawing.Point(86, 115);
            this.lblOutputLosses.Name = "lblOutputLosses";
            this.lblOutputLosses.Size = new System.Drawing.Size(160, 30);
            this.lblOutputLosses.TabIndex = 21;
            this.lblOutputLosses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLosses
            // 
            this.lblLosses.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLosses.Location = new System.Drawing.Point(25, 122);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(55, 23);
            this.lblLosses.TabIndex = 20;
            this.lblLosses.Text = "Losses:";
            this.lblLosses.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTeamStat
            // 
            this.lblTeamStat.AutoSize = true;
            this.lblTeamStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamStat.Location = new System.Drawing.Point(354, 392);
            this.lblTeamStat.Name = "lblTeamStat";
            this.lblTeamStat.Size = new System.Drawing.Size(79, 15);
            this.lblTeamStat.TabIndex = 22;
            this.lblTeamStat.Text = "Team Stats";
            // 
            // pnlFormTitleBar
            // 
            this.pnlFormTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(156)))));
            this.pnlFormTitleBar.Controls.Add(this.picFormIcon);
            this.pnlFormTitleBar.Controls.Add(this.lblFormTitle);
            this.pnlFormTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlFormTitleBar.Name = "pnlFormTitleBar";
            this.pnlFormTitleBar.Size = new System.Drawing.Size(1035, 52);
            this.pnlFormTitleBar.TabIndex = 15;
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
            this.lblFormTitle.Text = "Teams";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutputWins
            // 
            this.lblOutputWins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutputWins.Location = new System.Drawing.Point(86, 46);
            this.lblOutputWins.Name = "lblOutputWins";
            this.lblOutputWins.Size = new System.Drawing.Size(160, 30);
            this.lblOutputWins.TabIndex = 17;
            this.lblOutputWins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWins
            // 
            this.lblWins.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWins.Location = new System.Drawing.Point(25, 51);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(55, 23);
            this.lblWins.TabIndex = 14;
            this.lblWins.Text = "Wins:";
            this.lblWins.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBoxBasicInfo
            // 
            this.groupBoxBasicInfo.Controls.Add(this.lblLocated);
            this.groupBoxBasicInfo.Controls.Add(this.lblStateOutput);
            this.groupBoxBasicInfo.Controls.Add(this.lblCityOutput);
            this.groupBoxBasicInfo.Controls.Add(this.lblOwnerOutput);
            this.groupBoxBasicInfo.Controls.Add(this.lblCoachOutput);
            this.groupBoxBasicInfo.Controls.Add(this.label2);
            this.groupBoxBasicInfo.Controls.Add(this.label1);
            this.groupBoxBasicInfo.Controls.Add(this.picTeamLogo);
            this.groupBoxBasicInfo.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBasicInfo.Location = new System.Drawing.Point(25, 122);
            this.groupBoxBasicInfo.Name = "groupBoxBasicInfo";
            this.groupBoxBasicInfo.Size = new System.Drawing.Size(308, 459);
            this.groupBoxBasicInfo.TabIndex = 19;
            this.groupBoxBasicInfo.TabStop = false;
            this.groupBoxBasicInfo.Text = "Basic Team Info";
            // 
            // lblLocated
            // 
            this.lblLocated.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocated.Location = new System.Drawing.Point(11, 363);
            this.lblLocated.Name = "lblLocated";
            this.lblLocated.Size = new System.Drawing.Size(80, 49);
            this.lblLocated.TabIndex = 18;
            this.lblLocated.Text = "Located:";
            this.lblLocated.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStateOutput
            // 
            this.lblStateOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStateOutput.Location = new System.Drawing.Point(91, 413);
            this.lblStateOutput.Name = "lblStateOutput";
            this.lblStateOutput.Size = new System.Drawing.Size(187, 30);
            this.lblStateOutput.TabIndex = 17;
            this.lblStateOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCityOutput
            // 
            this.lblCityOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCityOutput.Location = new System.Drawing.Point(91, 371);
            this.lblCityOutput.Name = "lblCityOutput";
            this.lblCityOutput.Size = new System.Drawing.Size(187, 30);
            this.lblCityOutput.TabIndex = 16;
            this.lblCityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOwnerOutput
            // 
            this.lblOwnerOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOwnerOutput.Location = new System.Drawing.Point(91, 313);
            this.lblOwnerOutput.Name = "lblOwnerOutput";
            this.lblOwnerOutput.Size = new System.Drawing.Size(187, 30);
            this.lblOwnerOutput.TabIndex = 12;
            this.lblOwnerOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCoachOutput
            // 
            this.lblCoachOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCoachOutput.Location = new System.Drawing.Point(91, 255);
            this.lblCoachOutput.Name = "lblCoachOutput";
            this.lblCoachOutput.Size = new System.Drawing.Size(187, 30);
            this.lblCoachOutput.TabIndex = 11;
            this.lblCoachOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Owner:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Coach:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picTeamLogo
            // 
            this.picTeamLogo.Image = ((System.Drawing.Image)(resources.GetObject("picTeamLogo.Image")));
            this.picTeamLogo.Location = new System.Drawing.Point(46, 33);
            this.picTeamLogo.Name = "picTeamLogo";
            this.picTeamLogo.Size = new System.Drawing.Size(221, 189);
            this.picTeamLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTeamLogo.TabIndex = 0;
            this.picTeamLogo.TabStop = false;
            // 
            // lblOutputTeamName
            // 
            this.lblOutputTeamName.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputTeamName.Location = new System.Drawing.Point(28, 73);
            this.lblOutputTeamName.Name = "lblOutputTeamName";
            this.lblOutputTeamName.Size = new System.Drawing.Size(395, 23);
            this.lblOutputTeamName.TabIndex = 18;
            this.lblOutputTeamName.Text = "Teams Name";
            this.lblOutputTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOutputTeamName.Visible = false;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(969, 69);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(39, 23);
            this.btnGo.TabIndex = 17;
            this.btnGo.Text = "&Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // cboxTeamName
            // 
            this.cboxTeamName.FormattingEnabled = true;
            this.cboxTeamName.Location = new System.Drawing.Point(791, 70);
            this.cboxTeamName.Name = "cboxTeamName";
            this.cboxTeamName.Size = new System.Drawing.Size(172, 21);
            this.cboxTeamName.TabIndex = 16;
            // 
            // groupBoxSeasonInfo
            // 
            this.groupBoxSeasonInfo.Controls.Add(this.pictureBox1);
            this.groupBoxSeasonInfo.Controls.Add(this.lblRank);
            this.groupBoxSeasonInfo.Controls.Add(this.lblRankOutput);
            this.groupBoxSeasonInfo.Controls.Add(this.lblOutputLosses);
            this.groupBoxSeasonInfo.Controls.Add(this.lblLosses);
            this.groupBoxSeasonInfo.Controls.Add(this.lblOutputWins);
            this.groupBoxSeasonInfo.Controls.Add(this.lblWins);
            this.groupBoxSeasonInfo.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSeasonInfo.Location = new System.Drawing.Point(353, 122);
            this.groupBoxSeasonInfo.Name = "groupBoxSeasonInfo";
            this.groupBoxSeasonInfo.Size = new System.Drawing.Size(649, 240);
            this.groupBoxSeasonInfo.TabIndex = 20;
            this.groupBoxSeasonInfo.TabStop = false;
            // 
            // nbaTEAM_STATBindingSource
            // 
            this.nbaTEAM_STATBindingSource.DataSource = typeof(CTRL_ALT_ELITE_GroupProject.nbaTEAM_STAT);
            // 
            // nbaTEAM_STATDataGridView
            // 
            this.nbaTEAM_STATDataGridView.AllowUserToAddRows = false;
            this.nbaTEAM_STATDataGridView.AllowUserToDeleteRows = false;
            this.nbaTEAM_STATDataGridView.AutoGenerateColumns = false;
            this.nbaTEAM_STATDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nbaTEAM_STATDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.nbaTEAM_STATDataGridView.DataSource = this.nbaTEAM_STATBindingSource;
            this.nbaTEAM_STATDataGridView.Location = new System.Drawing.Point(353, 426);
            this.nbaTEAM_STATDataGridView.Name = "nbaTEAM_STATDataGridView";
            this.nbaTEAM_STATDataGridView.ReadOnly = true;
            this.nbaTEAM_STATDataGridView.Size = new System.Drawing.Size(649, 126);
            this.nbaTEAM_STATDataGridView.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TEAM_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "TEAM";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "STAT_YEAR";
            this.dataGridViewTextBoxColumn3.HeaderText = "YEAR";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "POINTS_PER_GAME";
            this.dataGridViewTextBoxColumn6.HeaderText = "PTS";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "REBOUNDS_PER_GAME";
            this.dataGridViewTextBoxColumn7.HeaderText = "RPG";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ASSISTS_PER_GAME";
            this.dataGridViewTextBoxColumn8.HeaderText = "APG";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "OPPONENT_POINTS_PER_GAME";
            this.dataGridViewTextBoxColumn9.HeaderText = "OPPG";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 115;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(355, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // nbaTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1035, 707);
            this.Controls.Add(this.nbaTEAM_STATDataGridView);
            this.Controls.Add(this.lblTeamStat);
            this.Controls.Add(this.pnlFormTitleBar);
            this.Controls.Add(this.groupBoxBasicInfo);
            this.Controls.Add(this.lblOutputTeamName);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.cboxTeamName);
            this.Controls.Add(this.groupBoxSeasonInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "nbaTeamForm";
            this.Text = "nbaTeamForm";
            this.Load += new System.EventHandler(this.nbaTeamForm_Load);
            this.pnlFormTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFormIcon)).EndInit();
            this.groupBoxBasicInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTeamLogo)).EndInit();
            this.groupBoxSeasonInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nbaTEAM_STATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbaTEAM_STATDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Label lblRankOutput;
        private System.Windows.Forms.Label lblOutputLosses;
        private System.Windows.Forms.Label lblLosses;
        private System.Windows.Forms.Label lblTeamStat;
        private System.Windows.Forms.Panel pnlFormTitleBar;
        private System.Windows.Forms.PictureBox picFormIcon;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblOutputWins;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.GroupBox groupBoxBasicInfo;
        private System.Windows.Forms.Label lblLocated;
        private System.Windows.Forms.Label lblStateOutput;
        private System.Windows.Forms.Label lblCityOutput;
        private System.Windows.Forms.Label lblOwnerOutput;
        private System.Windows.Forms.Label lblCoachOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picTeamLogo;
        private System.Windows.Forms.Label lblOutputTeamName;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ComboBox cboxTeamName;
        private System.Windows.Forms.GroupBox groupBoxSeasonInfo;
        private System.Windows.Forms.BindingSource nbaTEAM_STATBindingSource;
        private System.Windows.Forms.DataGridView nbaTEAM_STATDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}