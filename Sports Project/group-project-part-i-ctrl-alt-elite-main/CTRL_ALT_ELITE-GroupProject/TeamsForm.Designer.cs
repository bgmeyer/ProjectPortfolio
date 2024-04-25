namespace CTRL_ALT_ELITE_GroupProject
{
    partial class TeamsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamsForm));
			this.pnlFormTitleBar = new System.Windows.Forms.Panel();
			this.picFormIcon = new System.Windows.Forms.PictureBox();
			this.lblFormTitle = new System.Windows.Forms.Label();
			this.btnGo = new System.Windows.Forms.Button();
			this.cboxTeamName = new System.Windows.Forms.ComboBox();
			this.lblOutputTeamName = new System.Windows.Forms.Label();
			this.groupBoxBasicInfo = new System.Windows.Forms.GroupBox();
			this.lblLocated = new System.Windows.Forms.Label();
			this.lblStateOutput = new System.Windows.Forms.Label();
			this.lblCityOutput = new System.Windows.Forms.Label();
			this.lblOwnerOutput = new System.Windows.Forms.Label();
			this.lblCoachOutput = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.picTeamLogo = new System.Windows.Forms.PictureBox();
			this.groupBoxSeasonInfo = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblRank = new System.Windows.Forms.Label();
			this.lblRankOutput = new System.Windows.Forms.Label();
			this.lblOutputPA = new System.Windows.Forms.Label();
			this.lblPA = new System.Windows.Forms.Label();
			this.lblOutputLosses = new System.Windows.Forms.Label();
			this.lblLosses = new System.Windows.Forms.Label();
			this.lblOutputPF = new System.Windows.Forms.Label();
			this.lblOutputPCT = new System.Windows.Forms.Label();
			this.lblOutputWins = new System.Windows.Forms.Label();
			this.lblPF = new System.Windows.Forms.Label();
			this.lblPCT = new System.Windows.Forms.Label();
			this.lblWins = new System.Windows.Forms.Label();
			this.nflTEAM_STATBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.nflTEAM_STATDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblTeamStat = new System.Windows.Forms.Label();
			this.pnlFormTitleBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picFormIcon)).BeginInit();
			this.groupBoxBasicInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picTeamLogo)).BeginInit();
			this.groupBoxSeasonInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nflTEAM_STATBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nflTEAM_STATDataGridView)).BeginInit();
			this.SuspendLayout();
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
			this.lblFormTitle.Text = "Teams";
			this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnGo
			// 
			this.btnGo.Location = new System.Drawing.Point(970, 70);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(39, 23);
			this.btnGo.TabIndex = 6;
			this.btnGo.Text = "&Go";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// cboxTeamName
			// 
			this.cboxTeamName.FormattingEnabled = true;
			this.cboxTeamName.Location = new System.Drawing.Point(792, 71);
			this.cboxTeamName.Name = "cboxTeamName";
			this.cboxTeamName.Size = new System.Drawing.Size(172, 21);
			this.cboxTeamName.TabIndex = 5;
			// 
			// lblOutputTeamName
			// 
			this.lblOutputTeamName.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOutputTeamName.Location = new System.Drawing.Point(29, 74);
			this.lblOutputTeamName.Name = "lblOutputTeamName";
			this.lblOutputTeamName.Size = new System.Drawing.Size(395, 23);
			this.lblOutputTeamName.TabIndex = 7;
			this.lblOutputTeamName.Text = "Teams Name";
			this.lblOutputTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblOutputTeamName.Visible = false;
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
			this.groupBoxBasicInfo.Location = new System.Drawing.Point(26, 123);
			this.groupBoxBasicInfo.Name = "groupBoxBasicInfo";
			this.groupBoxBasicInfo.Size = new System.Drawing.Size(308, 459);
			this.groupBoxBasicInfo.TabIndex = 8;
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
			// groupBoxSeasonInfo
			// 
			this.groupBoxSeasonInfo.Controls.Add(this.pictureBox1);
			this.groupBoxSeasonInfo.Controls.Add(this.lblRank);
			this.groupBoxSeasonInfo.Controls.Add(this.lblRankOutput);
			this.groupBoxSeasonInfo.Controls.Add(this.lblOutputPA);
			this.groupBoxSeasonInfo.Controls.Add(this.lblPA);
			this.groupBoxSeasonInfo.Controls.Add(this.lblOutputLosses);
			this.groupBoxSeasonInfo.Controls.Add(this.lblLosses);
			this.groupBoxSeasonInfo.Controls.Add(this.lblOutputPF);
			this.groupBoxSeasonInfo.Controls.Add(this.lblOutputPCT);
			this.groupBoxSeasonInfo.Controls.Add(this.lblOutputWins);
			this.groupBoxSeasonInfo.Controls.Add(this.lblPF);
			this.groupBoxSeasonInfo.Controls.Add(this.lblPCT);
			this.groupBoxSeasonInfo.Controls.Add(this.lblWins);
			this.groupBoxSeasonInfo.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxSeasonInfo.Location = new System.Drawing.Point(354, 123);
			this.groupBoxSeasonInfo.Name = "groupBoxSeasonInfo";
			this.groupBoxSeasonInfo.Size = new System.Drawing.Size(649, 240);
			this.groupBoxSeasonInfo.TabIndex = 10;
			this.groupBoxSeasonInfo.TabStop = false;
			this.groupBoxSeasonInfo.Text = "Teams Current Season Info";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(332, 34);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(291, 181);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 30;
			this.pictureBox1.TabStop = false;
			// 
			// lblRank
			// 
			this.lblRank.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRank.Location = new System.Drawing.Point(19, 209);
			this.lblRank.Name = "lblRank";
			this.lblRank.Size = new System.Drawing.Size(61, 23);
			this.lblRank.TabIndex = 29;
			this.lblRank.Text = "Rank:";
			this.lblRank.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblRankOutput
			// 
			this.lblRankOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblRankOutput.Location = new System.Drawing.Point(86, 204);
			this.lblRankOutput.Name = "lblRankOutput";
			this.lblRankOutput.Size = new System.Drawing.Size(187, 30);
			this.lblRankOutput.TabIndex = 28;
			this.lblRankOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblOutputPA
			// 
			this.lblOutputPA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblOutputPA.Location = new System.Drawing.Point(86, 161);
			this.lblOutputPA.Name = "lblOutputPA";
			this.lblOutputPA.Size = new System.Drawing.Size(187, 30);
			this.lblOutputPA.TabIndex = 24;
			this.lblOutputPA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPA
			// 
			this.lblPA.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPA.Location = new System.Drawing.Point(26, 166);
			this.lblPA.Name = "lblPA";
			this.lblPA.Size = new System.Drawing.Size(61, 23);
			this.lblPA.TabIndex = 22;
			this.lblPA.Text = "PA:";
			this.lblPA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblOutputLosses
			// 
			this.lblOutputLosses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblOutputLosses.Location = new System.Drawing.Point(199, 30);
			this.lblOutputLosses.Name = "lblOutputLosses";
			this.lblOutputLosses.Size = new System.Drawing.Size(70, 30);
			this.lblOutputLosses.TabIndex = 21;
			this.lblOutputLosses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblLosses
			// 
			this.lblLosses.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLosses.Location = new System.Drawing.Point(145, 34);
			this.lblLosses.Name = "lblLosses";
			this.lblLosses.Size = new System.Drawing.Size(55, 23);
			this.lblLosses.TabIndex = 20;
			this.lblLosses.Text = "Losses:";
			this.lblLosses.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblOutputPF
			// 
			this.lblOutputPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblOutputPF.Location = new System.Drawing.Point(86, 117);
			this.lblOutputPF.Name = "lblOutputPF";
			this.lblOutputPF.Size = new System.Drawing.Size(187, 30);
			this.lblOutputPF.TabIndex = 19;
			this.lblOutputPF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblOutputPCT
			// 
			this.lblOutputPCT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblOutputPCT.Location = new System.Drawing.Point(86, 76);
			this.lblOutputPCT.Name = "lblOutputPCT";
			this.lblOutputPCT.Size = new System.Drawing.Size(187, 30);
			this.lblOutputPCT.TabIndex = 18;
			this.lblOutputPCT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblOutputWins
			// 
			this.lblOutputWins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblOutputWins.Location = new System.Drawing.Point(69, 30);
			this.lblOutputWins.Name = "lblOutputWins";
			this.lblOutputWins.Size = new System.Drawing.Size(70, 30);
			this.lblOutputWins.TabIndex = 17;
			this.lblOutputWins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPF
			// 
			this.lblPF.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPF.Location = new System.Drawing.Point(7, 109);
			this.lblPF.Name = "lblPF";
			this.lblPF.Size = new System.Drawing.Size(80, 49);
			this.lblPF.TabIndex = 16;
			this.lblPF.Text = "PF:";
			this.lblPF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblPCT
			// 
			this.lblPCT.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPCT.Location = new System.Drawing.Point(26, 81);
			this.lblPCT.Name = "lblPCT";
			this.lblPCT.Size = new System.Drawing.Size(61, 23);
			this.lblPCT.TabIndex = 15;
			this.lblPCT.Text = "PCT:";
			this.lblPCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblWins
			// 
			this.lblWins.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWins.Location = new System.Drawing.Point(15, 34);
			this.lblWins.Name = "lblWins";
			this.lblWins.Size = new System.Drawing.Size(55, 23);
			this.lblWins.TabIndex = 14;
			this.lblWins.Text = "Wins:";
			this.lblWins.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nflTEAM_STATBindingSource
			// 
			this.nflTEAM_STATBindingSource.DataSource = typeof(CTRL_ALT_ELITE_GroupProject.nflTEAM_STAT);
			// 
			// nflTEAM_STATDataGridView
			// 
			this.nflTEAM_STATDataGridView.AllowUserToAddRows = false;
			this.nflTEAM_STATDataGridView.AllowUserToDeleteRows = false;
			this.nflTEAM_STATDataGridView.AutoGenerateColumns = false;
			this.nflTEAM_STATDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.nflTEAM_STATDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
			this.nflTEAM_STATDataGridView.DataSource = this.nflTEAM_STATBindingSource;
			this.nflTEAM_STATDataGridView.Location = new System.Drawing.Point(354, 407);
			this.nflTEAM_STATDataGridView.Name = "nflTEAM_STATDataGridView";
			this.nflTEAM_STATDataGridView.ReadOnly = true;
			this.nflTEAM_STATDataGridView.Size = new System.Drawing.Size(649, 161);
			this.nflTEAM_STATDataGridView.TabIndex = 11;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "TEAM_NAME";
			this.dataGridViewTextBoxColumn2.HeaderText = "TEAM NAME";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "STAT_YEAR";
			this.dataGridViewTextBoxColumn3.HeaderText = "STAT YEAR";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "WINS";
			this.dataGridViewTextBoxColumn4.HeaderText = "WINS";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "LOSSES";
			this.dataGridViewTextBoxColumn5.HeaderText = "LOSSES";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "PCT";
			this.dataGridViewTextBoxColumn6.HeaderText = "PCT";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "PF";
			this.dataGridViewTextBoxColumn7.HeaderText = "PF";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "PA";
			this.dataGridViewTextBoxColumn8.HeaderText = "PA";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "RANKING";
			this.dataGridViewTextBoxColumn9.HeaderText = "RANKING";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.ReadOnly = true;
			// 
			// lblTeamStat
			// 
			this.lblTeamStat.AutoSize = true;
			this.lblTeamStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTeamStat.Location = new System.Drawing.Point(355, 383);
			this.lblTeamStat.Name = "lblTeamStat";
			this.lblTeamStat.Size = new System.Drawing.Size(79, 15);
			this.lblTeamStat.TabIndex = 14;
			this.lblTeamStat.Text = "Team Stats";
			// 
			// TeamsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1035, 707);
			this.Controls.Add(this.lblTeamStat);
			this.Controls.Add(this.nflTEAM_STATDataGridView);
			this.Controls.Add(this.groupBoxSeasonInfo);
			this.Controls.Add(this.groupBoxBasicInfo);
			this.Controls.Add(this.lblOutputTeamName);
			this.Controls.Add(this.btnGo);
			this.Controls.Add(this.cboxTeamName);
			this.Controls.Add(this.pnlFormTitleBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "TeamsForm";
			this.Text = "TeamsForm";
			this.Load += new System.EventHandler(this.TeamsForm_Load);
			this.pnlFormTitleBar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picFormIcon)).EndInit();
			this.groupBoxBasicInfo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picTeamLogo)).EndInit();
			this.groupBoxSeasonInfo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nflTEAM_STATBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nflTEAM_STATDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormTitleBar;
        private System.Windows.Forms.PictureBox picFormIcon;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ComboBox cboxTeamName;
        private System.Windows.Forms.Label lblOutputTeamName;
        private System.Windows.Forms.GroupBox groupBoxBasicInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picTeamLogo;
        private System.Windows.Forms.GroupBox groupBoxSeasonInfo;
        private System.Windows.Forms.Label lblOwnerOutput;
        private System.Windows.Forms.Label lblCoachOutput;
        private System.Windows.Forms.Label lblOutputLosses;
        private System.Windows.Forms.Label lblLosses;
        private System.Windows.Forms.Label lblOutputPF;
        private System.Windows.Forms.Label lblOutputPCT;
        private System.Windows.Forms.Label lblOutputWins;
        private System.Windows.Forms.Label lblPF;
        private System.Windows.Forms.Label lblPCT;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lblOutputPA;
        private System.Windows.Forms.Label lblPA;
        private System.Windows.Forms.Label lblLocated;
        private System.Windows.Forms.Label lblStateOutput;
        private System.Windows.Forms.Label lblCityOutput;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Label lblRankOutput;
        private System.Windows.Forms.BindingSource nflTEAM_STATBindingSource;
        private System.Windows.Forms.DataGridView nflTEAM_STATDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label lblTeamStat;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}