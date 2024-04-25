using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTRL_ALT_ELITE_GroupProject
{
    public partial class SelectFavoritesForm : Form
    {
        public string userFavNBAPlayer = "";
        public string userFavNBATeams = "";
        public string userFavNFLPlayer = "";
        public string userFavNFLTeams = "";

        public SelectFavoritesForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void SelectFavoritesForm_Load(object sender, EventArgs e)
        {
            //Populate list boxes with data
            SportsDataContext db = new SportsDataContext();//create data context object
            var nflTeamResults = from team in db.nflTEAM_INFOs//query to get state ids to populate combo box
                          select team.TEAM_NAME;
            foreach (var team in nflTeamResults)
            {
                listboxNFLTeams.Items.Add(team);//populate list box
            }

            var nflPlayerResults = from player in db.nflPLAYER_INFOs//query to get state ids to populate combo box
                          select player.FULL_NAME;
            foreach (var player in nflPlayerResults)
            {
                listboxNFLPlayers.Items.Add(player);//populate list box
            }

            var nbaPlayerResults = from player in db.nbaPLAYER_STATs//query to get state ids to populate combo box
                                   select player.PLAYER_ID;
            foreach (var player in nbaPlayerResults)
            {
                listboxNBAPlayers.Items.Add(player);//populate list box
            }

            var nbaTeamResults = from team in db.nbaTEAM_INFOs//query to get state ids to populate combo box
                                   select team.TEAM_NAME;
            foreach (var team in nbaTeamResults)
            {
                listboxNBATeams.Items.Add(team);//populate list box
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //Grabs Users Input
            userFavNBAPlayer = listboxNBAPlayers.SelectedItem.ToString();
            userFavNBATeams = listboxNBATeams.SelectedItem.ToString();
            userFavNFLPlayer = listboxNFLPlayers.SelectedItem.ToString();
            userFavNFLTeams = listboxNFLTeams.SelectedItem.ToString();

            MessageBox.Show(userFavNBAPlayer);
            
            

            this.Close();
            
        }
    }
}
