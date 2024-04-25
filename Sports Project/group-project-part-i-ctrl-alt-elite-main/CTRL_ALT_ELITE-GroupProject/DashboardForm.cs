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
    public partial class DashboardForm : Form
    {
        /*This form will be the first form to display and will show information on
         weekly stats, as well as top teams and players*/
         

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            lblOutputTopTeamName.Text = "Baltimore Ravens";
            lblOutputTopTeamWins.Text = "13";
            lblOutputTopTeamLosses.Text = "4";
            lblOutputTopPlayerName.Text = "Brandon Aubrey";
            lblOutputTopPlayerPoints.Text = "157";
            lblTPPoints.Text = "Points Earned In Season";
            lblOutputRecentGameTeam.Text = "Dallas Cowboys";
            lblOutputWinnerScore.Text = "38";
            lblOpponentTeamScore.Text = "10";

        }

        private void btnNBA_Click(object sender, EventArgs e)
        {
            btnNBA.Visible = false;
            btnNFL.Visible = true;
            lblOutputTopTeamName.Text = "Boston Celtics";
            lblOutputTopTeamWins.Text = "45";
            lblOutputTopTeamLosses.Text = "12";
            lblOutputTopPlayerName.Text = "Joel Embiid";
            lblOutputTopPlayerPoints.Text = "35.3";
            lblTPPoints.Text = "PTS";
            lblOutputRecentGameTeam.Text = "Philidelphia 76ers";
            lblOutputWinnerScore.Text = "120";
            lblOpponentTeamScore.Text = "16";
        }

        private void btnNFL_Click(object sender, EventArgs e)
        {
            btnNBA.Visible = true;
            btnNFL.Visible = false;
            lblOutputTopTeamName.Text = "Baltimore Ravens";
            lblOutputTopTeamWins.Text = "13";
            lblOutputTopTeamLosses.Text = "4";
            lblOutputTopPlayerName.Text = "Brandon Aubrey";
            lblOutputTopPlayerPoints.Text = "157";
            lblTPPoints.Text = "Points Earned In Season";
            lblOutputRecentGameTeam.Text = "Dallas Cowboys";
            lblOutputWinnerScore.Text = "38";
            lblOpponentTeamScore.Text = "10";
        }
    }
}
