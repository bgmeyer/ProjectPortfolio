using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAccountManager;

namespace CTRL_ALT_ELITE_GroupProject
{
    public partial class SettingsForm : Form
    {
        /*This form will allow for users to update their information such as
         changing their password, favorite teams, etc.
         */
        public SelectFavoritesForm frmSelectFavs = new SelectFavoritesForm();
        public SettingsForm( Profile userInformation)
        {
            InitializeComponent();
            this.userInformation = userInformation;
            lblOutputFirstName.Text = userInformation.firstName;
            lblOutputLastName.Text = userInformation.lastName;
            lblOutputUserName.Text = userInformation.userName;
        }

        public Profile userInformation { get; set; }
        private void btnEditFavorites_Click(object sender, EventArgs e)
        {     
            frmSelectFavs.ShowDialog();
        }       

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            
        }

        public void Update_Fields()
        {
            this.userControlFavNFLPlayer.PlayersName = frmSelectFavs.userFavNFLPlayer;
            this.userControlFavNFLTeam.PlayersName = frmSelectFavs.userFavNFLTeams;
            this.userControlFavNBAPlayer.PlayersName = frmSelectFavs.userFavNBAPlayer;
            this.userControlFavNBATeam.PlayersName = frmSelectFavs.userFavNBATeams;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Update_Fields();
        }
    }
}
