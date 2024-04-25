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
    public partial class TeamsForm : Form
    {
        /*This form will allow for the user to view different teams, the players that are on
         the teams and stats about the team such as wins vs losses, touchdown count, and offense,
         defense stats
         */
        public TeamsForm()
        {
            InitializeComponent();
        }

        private void TeamsForm_Load(object sender, EventArgs e)
        {
            //populate combo box
            SportsDataContext db = new SportsDataContext();//create data context object
            var results = from team in db.nflTEAM_INFOs//query to get state ids to populate combo box
                          select team.TEAM_NAME;
            foreach (var team in results)
            {
                cboxTeamName.Items.Add(team);//populate combo box
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (cboxTeamName.SelectedIndex == -1)
            {
                MessageBox.Show("Error! Please select a team to view information about.");//error message if no team has been selected
            }
            else
            {
                string teamName = Convert.ToString(cboxTeamName.SelectedItem);//give selected player to variable

                //team name to label
                lblOutputTeamName.Visible = true;//make label visible
                lblOutputTeamName.Text = teamName;//give label team name to display

                //coach to label
                GetCoach(teamName);//call method to get coach and return it to label

                //owner to label
                GetOwner(teamName);//call method to get owner and return it to label

                //city to label
                GetCity(teamName);//call method to get city and return it to label 

                //state to label
                GetState(teamName);//call method to get state and return it to label

                //current rank to label
                GetRank(teamName);//call method to get team rank and return it to label

                //current wins to label
                GetCurrentWins(teamName);//call method to get current team wins and return to label

                //current losses to label
                GetCurrentLosses(teamName);//call method to get current team losses and return to label 

                //current PCT to label
                GetCurrentPCT(teamName);//call method to get current PCT of team and return to label 

                //current PF to label
                GetCurrentPF(teamName);//call method to get current PF of team and return to label

                //current PA to label
                GetCurrentPA(teamName);//call method to get current PA of team and return to label

                //fill data grid with team stats
                GetTeamStat(teamName);//call method to get team stats

            }
        }


        public void GetCoach(string teamName)// method to query coach of team
        {
            SportsDataContext db = new SportsDataContext();
            var results = from team in db.nflTEAM_INFOs
                          where team.TEAM_NAME.Contains(teamName)
                          select team.COACH;

            //assign results of query to controls
            foreach (var result in results)
            {
                lblCoachOutput.Text = result.ToString();
            }
        }

        public void GetOwner(string teamName)// method to query owner of team
        {
            SportsDataContext db = new SportsDataContext();
            var results = from team in db.nflTEAM_INFOs
                          where team.TEAM_NAME.Contains(teamName)
                          select team.OWNER;

            //assign results of query to controls
            foreach (var result in results)
            {
                lblOwnerOutput.Text = result.ToString();
            }
        }

        public void GetCity(string teamName)// method to query city of team
        {
            SportsDataContext db = new SportsDataContext();
            var results = from team in db.nflTEAM_INFOs
                          where team.TEAM_NAME.Contains(teamName)
                          select team.CITY;

            //assign results of query to controls
            foreach (var result in results)
            {
                lblCityOutput.Text = result.ToString();
            }
        }

        public void GetState(string teamName)// method to query state of team
        {
            SportsDataContext db = new SportsDataContext();
            var results = from team in db.nflTEAM_INFOs
                          where team.TEAM_NAME.Contains(teamName)
                          select team.STATE;

            //assign results of query to controls
            foreach (var result in results)
            {
                lblStateOutput.Text = result.ToString();
            }
        }

        public void GetRank(string teamName)// method to query rank of team
        {
            SportsDataContext db = new SportsDataContext();
            var results = from team in db.nflTEAM_STATs
                          where team.TEAM_NAME.Contains(teamName)
                          select team.RANKING;

            //assign results of query to controls
            foreach (var result in results)
            {
                lblRankOutput.Text = result.ToString();
            }
        }

        public void GetCurrentWins(string teamName)// method to query current wins of team
        {
            SportsDataContext db = new SportsDataContext();
            var results = from team in db.nflTEAM_STATs
                          where team.TEAM_NAME.Contains(teamName) && team.STAT_YEAR.Contains("2023")
                          select team.WINS;

            //assign results of query to controls
            foreach (var result in results)
            {
                lblOutputWins.Text = result.ToString();
            }
        }

        public void GetCurrentLosses(string teamName)// method to query current losses of team
        {
            SportsDataContext db = new SportsDataContext();
            var results = from team in db.nflTEAM_STATs
                          where team.TEAM_NAME.Contains(teamName) && team.STAT_YEAR.Contains("2023")
                          select team.LOSSES;

            //assign results of query to controls
            foreach (var result in results)
            {
                lblOutputLosses.Text = result.ToString();
            }
        }

        public void GetCurrentPCT(string teamName)// method to query current PCT of team
        {
            SportsDataContext db = new SportsDataContext();
            var results = from team in db.nflTEAM_STATs
                          where team.TEAM_NAME.Contains(teamName) && team.STAT_YEAR.Contains("2023")
                          select team.PCT;

            //assign results of query to controls
            foreach (var result in results)
            {
                lblOutputPCT.Text = result.ToString();
            }
        }

        public void GetCurrentPA(string teamName)// method to query current PA of team
        {
            SportsDataContext db = new SportsDataContext();
            var results = from team in db.nflTEAM_STATs
                          where team.TEAM_NAME.Contains(teamName) && team.STAT_YEAR.Contains("2023")
                          select team.PA;

            //assign results of query to controls
            foreach (var result in results)
            {
                lblOutputPA.Text = result.ToString();
            }
        }

        public void GetCurrentPF(string teamName)// method to query current PF of team
        {
            SportsDataContext db = new SportsDataContext();
            var results = from team in db.nflTEAM_STATs
                          where team.TEAM_NAME.Contains(teamName) && team.STAT_YEAR.Contains("2023")
                          select team.PF;

            //assign results of query to controls
            foreach (var result in results)
            {
                lblOutputPF.Text = result.ToString();
            }
        }

        public void GetTeamStat(string teamName)// method to query stats of team
        {
            SportsDataContext db = new SportsDataContext();
            var results = from team in db.nflTEAM_STATs
                          where team.TEAM_NAME.Contains(teamName)
                          select team;

            //assign results of query to datagrid
            nflTEAM_STATDataGridView.DataSource = results;

        }
    }
}
