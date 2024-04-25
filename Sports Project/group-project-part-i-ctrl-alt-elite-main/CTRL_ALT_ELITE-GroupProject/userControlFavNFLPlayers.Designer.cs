
namespace CTRL_ALT_ELITE_GroupProject
{
    partial class userControlFavNFLPlayers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userControlFavNFLPlayers));
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNFLPlayerName = new System.Windows.Forms.Label();
            this.lblPlayerTitle = new System.Windows.Forms.Label();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(149)))), ((int)(((byte)(90)))));
            this.pnlBackground.Controls.Add(this.panel1);
            this.pnlBackground.Controls.Add(this.lblNFLPlayerName);
            this.pnlBackground.Controls.Add(this.lblPlayerTitle);
            this.pnlBackground.Controls.Add(this.picPlayer);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(329, 95);
            this.pnlBackground.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-11, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 10);
            this.panel1.TabIndex = 11;
            // 
            // lblNFLPlayerName
            // 
            this.lblNFLPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.lblNFLPlayerName.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNFLPlayerName.ForeColor = System.Drawing.Color.Black;
            this.lblNFLPlayerName.Location = new System.Drawing.Point(140, 43);
            this.lblNFLPlayerName.Name = "lblNFLPlayerName";
            this.lblNFLPlayerName.Size = new System.Drawing.Size(165, 23);
            this.lblNFLPlayerName.TabIndex = 10;
            this.lblNFLPlayerName.Text = "Players Name";
            this.lblNFLPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPlayerTitle
            // 
            this.lblPlayerTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerTitle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTitle.ForeColor = System.Drawing.Color.Black;
            this.lblPlayerTitle.Location = new System.Drawing.Point(103, 20);
            this.lblPlayerTitle.Name = "lblPlayerTitle";
            this.lblPlayerTitle.Size = new System.Drawing.Size(165, 23);
            this.lblPlayerTitle.TabIndex = 9;
            this.lblPlayerTitle.Text = "Favorite NFL Player:";
            this.lblPlayerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picPlayer
            // 
            this.picPlayer.Image = ((System.Drawing.Image)(resources.GetObject("picPlayer.Image")));
            this.picPlayer.Location = new System.Drawing.Point(21, 9);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(76, 74);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // userControlFavNFLPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBackground);
            this.Name = "userControlFavNFLPlayers";
            this.Size = new System.Drawing.Size(329, 95);
            this.pnlBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.Label lblPlayerTitle;
        private System.Windows.Forms.Label lblNFLPlayerName;
        private System.Windows.Forms.Panel panel1;
    }
}
