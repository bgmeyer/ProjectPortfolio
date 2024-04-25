namespace CTRL_ALT_ELITE_GroupProject
{
    partial class MatchesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatchesForm));
            this.pnlFormTitleBar = new System.Windows.Forms.Panel();
            this.picFormIcon = new System.Windows.Forms.PictureBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.cboxTeamName = new System.Windows.Forms.ComboBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.nflMATCHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nflMATCHDataGridView = new System.Windows.Forms.DataGridView();
            this.btnWholeSchedule = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbaMATCHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nbaMATCHDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNbaView = new System.Windows.Forms.Button();
            this.btnNflView = new System.Windows.Forms.Button();
            this.pnlFormTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFormIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nflMATCHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nflMATCHDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbaMATCHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbaMATCHDataGridView)).BeginInit();
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
            this.lblFormTitle.Text = "Matches";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboxTeamName
            // 
            this.cboxTeamName.FormattingEnabled = true;
            this.cboxTeamName.Location = new System.Drawing.Point(771, 76);
            this.cboxTeamName.Name = "cboxTeamName";
            this.cboxTeamName.Size = new System.Drawing.Size(172, 21);
            this.cboxTeamName.TabIndex = 3;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(949, 75);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(39, 23);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "&Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // nflMATCHBindingSource
            // 
            this.nflMATCHBindingSource.DataSource = typeof(CTRL_ALT_ELITE_GroupProject.nflMATCH);
            // 
            // nflMATCHDataGridView
            // 
            this.nflMATCHDataGridView.AllowUserToAddRows = false;
            this.nflMATCHDataGridView.AllowUserToDeleteRows = false;
            this.nflMATCHDataGridView.AutoGenerateColumns = false;
            this.nflMATCHDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nflMATCHDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.nflMATCHDataGridView.DataSource = this.nflMATCHBindingSource;
            this.nflMATCHDataGridView.Location = new System.Drawing.Point(60, 137);
            this.nflMATCHDataGridView.Name = "nflMATCHDataGridView";
            this.nflMATCHDataGridView.ReadOnly = true;
            this.nflMATCHDataGridView.Size = new System.Drawing.Size(913, 428);
            this.nflMATCHDataGridView.TabIndex = 5;
            // 
            // btnWholeSchedule
            // 
            this.btnWholeSchedule.Location = new System.Drawing.Point(60, 108);
            this.btnWholeSchedule.Name = "btnWholeSchedule";
            this.btnWholeSchedule.Size = new System.Drawing.Size(120, 23);
            this.btnWholeSchedule.TabIndex = 8;
            this.btnWholeSchedule.Text = "&View Whole Schedule";
            this.btnWholeSchedule.UseVisualStyleBackColor = true;
            this.btnWholeSchedule.Click += new System.EventHandler(this.btnWholeSchedule_Click);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TV_STATION";
            this.dataGridViewTextBoxColumn6.HeaderText = "TV STATION";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TIME";
            this.dataGridViewTextBoxColumn5.HeaderText = "TIME";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MATCH_DATE";
            this.dataGridViewTextBoxColumn4.HeaderText = "MATCH DATE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AWAY_TEAM";
            this.dataGridViewTextBoxColumn3.HeaderText = "AWAY TEAM";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HOME_TEAM";
            this.dataGridViewTextBoxColumn2.HeaderText = "HOME TEAM";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // nbaMATCHBindingSource
            // 
            this.nbaMATCHBindingSource.DataSource = typeof(CTRL_ALT_ELITE_GroupProject.nbaMATCH);
            // 
            // nbaMATCHDataGridView
            // 
            this.nbaMATCHDataGridView.AllowUserToAddRows = false;
            this.nbaMATCHDataGridView.AllowUserToDeleteRows = false;
            this.nbaMATCHDataGridView.AutoGenerateColumns = false;
            this.nbaMATCHDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nbaMATCHDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.nbaMATCHDataGridView.DataSource = this.nbaMATCHBindingSource;
            this.nbaMATCHDataGridView.Location = new System.Drawing.Point(60, 137);
            this.nbaMATCHDataGridView.Name = "nbaMATCHDataGridView";
            this.nbaMATCHDataGridView.ReadOnly = true;
            this.nbaMATCHDataGridView.Size = new System.Drawing.Size(913, 403);
            this.nbaMATCHDataGridView.TabIndex = 8;
            this.nbaMATCHDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "HOME_TEAM";
            this.dataGridViewTextBoxColumn7.HeaderText = "HOME TEAM";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 250;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "AWAY_TEAM";
            this.dataGridViewTextBoxColumn8.HeaderText = "AWAY TEAM";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 250;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "MATCH_DATE";
            this.dataGridViewTextBoxColumn9.HeaderText = "MATCH DATE";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 200;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ARENA";
            this.dataGridViewTextBoxColumn10.HeaderText = "ARENA";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 200;
            // 
            // btnNbaView
            // 
            this.btnNbaView.Location = new System.Drawing.Point(853, 571);
            this.btnNbaView.Name = "btnNbaView";
            this.btnNbaView.Size = new System.Drawing.Size(120, 23);
            this.btnNbaView.TabIndex = 9;
            this.btnNbaView.Text = "N&BA View";
            this.btnNbaView.UseVisualStyleBackColor = true;
            this.btnNbaView.Click += new System.EventHandler(this.btnNbaView_Click);
            // 
            // btnNflView
            // 
            this.btnNflView.Location = new System.Drawing.Point(727, 571);
            this.btnNflView.Name = "btnNflView";
            this.btnNflView.Size = new System.Drawing.Size(120, 23);
            this.btnNflView.TabIndex = 10;
            this.btnNflView.Text = "&NFL View";
            this.btnNflView.UseVisualStyleBackColor = true;
            this.btnNflView.Visible = false;
            this.btnNflView.Click += new System.EventHandler(this.btnNflView_Click);
            // 
            // MatchesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1035, 606);
            this.Controls.Add(this.btnNflView);
            this.Controls.Add(this.btnNbaView);
            this.Controls.Add(this.nbaMATCHDataGridView);
            this.Controls.Add(this.btnWholeSchedule);
            this.Controls.Add(this.nflMATCHDataGridView);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.cboxTeamName);
            this.Controls.Add(this.pnlFormTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MatchesForm";
            this.Text = "MatchesForm";
            this.Load += new System.EventHandler(this.MatchesForm_Load);
            this.pnlFormTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFormIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nflMATCHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nflMATCHDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbaMATCHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbaMATCHDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormTitleBar;
        private System.Windows.Forms.PictureBox picFormIcon;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.ComboBox cboxTeamName;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.BindingSource nflMATCHBindingSource;
        private System.Windows.Forms.DataGridView nflMATCHDataGridView;
        private System.Windows.Forms.Button btnWholeSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource nbaMATCHBindingSource;
        private System.Windows.Forms.DataGridView nbaMATCHDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Button btnNbaView;
        private System.Windows.Forms.Button btnNflView;
    }
}