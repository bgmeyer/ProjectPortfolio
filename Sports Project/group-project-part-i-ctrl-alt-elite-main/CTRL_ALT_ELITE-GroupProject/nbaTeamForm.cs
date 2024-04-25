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
    public partial class nbaTeamForm : Form
    {
        public nbaTeamForm()
        {
            InitializeComponent();
        }

        private void nbaTeamForm_Load(object sender, EventArgs e)
        {
            //populate combo box
            SportsDataContext db = new SportsDataContext();//create data context object
            var results = from team in db.nbaTEAM_INFOs//query to get state ids to populate combo box
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

               

                //fill data grid with team stats
                GetTeamStat(teamName);//call method to get team stats

            }
        }


        public void GetCoach(string teamName)// method to query coach of team
        {
            SportsDataContext db = new SportsDataContext();
            var results = from team in db.nbaTEAM_INFOs
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
            var results = from team in db.nbaTEAM_INFOs
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
            var results = from team in db.nbaTEAM_INFOs
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
            var results = from team in db.nbaTEAM_INFOs
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
            var results = from team in db.nbaTEAM_STATs
                          where team.TEAM_ID.Contains(teamName)
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
            var results = from team in db.nbaTEAM_STATs
                          where team.TEAM_ID.Contains(teamName) 
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
            var results = from team in db.nbaTEAM_STATs
                          where team.TEAM_ID.Contains(teamName) 
                          select team.LOSSES;

            //assign results of query to controls
            foreach (var result in results)
            {
                lblOutputLosses.Text = result.ToString();
            }
        }

       

        public void GetTeamStat(string teamName)// method to query stats of team
        {
            SportsDataContext db = new SportsDataContext();
            var results = from team in db.nbaTEAM_STATs
                          where team.TEAM_ID.Contains(teamName)
                          select team;

            //assign results of query to datagrid
            nbaTEAM_STATDataGridView.DataSource = results;

        }
    }
}
