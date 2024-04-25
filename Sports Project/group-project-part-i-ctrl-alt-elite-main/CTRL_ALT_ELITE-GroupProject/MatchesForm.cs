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
    /*This form will display upcoming games this can be by calendar view or possibly
     bracket or ranking. It will allow users to sort through matches by the day, week,
     or month.
     */

    public partial class MatchesForm : Form
    {
        public MatchesForm()
        {
            InitializeComponent();
        }
        Boolean nfl = true;//global variable for switching
        private void MatchesForm_Load(object sender, EventArgs e)
        {
            //populate combo box
            SportsDataContext db = new SportsDataContext();//create data context object
            var results = from team in db.nflTEAM_INFOs//query to get state ids to populate combo box
                          select team.TEAM_NAME;
            foreach (var team in results)
            {
                cboxTeamName.Items.Add(team);//populate combo box
            }

            //fill datagrid with nfl schedule
            var result = from match in db.nflMATCHes//get all entries from matches table for schedule
                         select match;
            //assign results of query to DataGridView control
            nflMATCHDataGridView.DataSource = result;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (nfl == true)
            {
                if (cboxTeamName.SelectedIndex == -1)
                {
                    MessageBox.Show("Error! Please select a team to view their schedule.");//error message if no team has been selected
                }
                else
                {
                    string teamName = Convert.ToString(cboxTeamName.SelectedItem);//give selected team to variable

                    SportsDataContext db = new SportsDataContext();//create data context object
                    var results = from match in db.nflMATCHes//query to get matches of chosen team
                                  where match.HOME_TEAM.Contains(teamName) || match.AWAY_TEAM.Contains(teamName)
                                  select match;
                    nflMATCHDataGridView.DataSource = results;//assign results to datagrid

                }
            }
            else
            {
                if (cboxTeamName.SelectedIndex == -1)
                {
                    MessageBox.Show("Error! Please select a team to view their schedule.");//error message if no team has been selected
                }
                else
                {
                    string teamName = Convert.ToString(cboxTeamName.SelectedItem);//give selected team to variable

                    SportsDataContext db = new SportsDataContext();//create data context object
                    var results = from match in db.nbaMATCHes//query to get matches of chosen team
                                  where match.HOME_TEAM.Contains(teamName) || match.AWAY_TEAM.Contains(teamName)
                                  select match;
                    nbaMATCHDataGridView.DataSource = results;//assign results to datagrid

                }
            }

        }

        private void btnWholeSchedule_Click(object sender, EventArgs e)
        {
            if (nfl == true)
            {
                SportsDataContext db = new SportsDataContext();//create data context object
                 //fill datagrid with nfl schedule
                var result = from match in db.nflMATCHes//get all entries from matches table for schedule
                             select match;
                //assign results of query to DataGridView control
                nflMATCHDataGridView.DataSource = result;
            }
            else
            {
                SportsDataContext db = new SportsDataContext();//create data context object
                //fill datagrid with nba schedule
                var result = from match in db.nbaMATCHes//get all entries from matches table for schedule
                             select match;
                //assign results of query to data grid view control
                nbaMATCHDataGridView.DataSource = result;
            }
        }

        private void btnNflView_Click(object sender, EventArgs e)
        {
            nfl = true;//bool for nfl view
            nflMATCHDataGridView.Visible = true;//make nfl data grid visible
            nbaMATCHDataGridView.Visible = false;//make nba data grid invisible
            btnNflView.Visible = false;
            btnNbaView.Visible = true;

            cboxTeamName.Items.Clear();//clear combo box
            //populate combo box
            SportsDataContext db = new SportsDataContext();//create data context object
            var results = from team in db.nflTEAM_INFOs//query to get state ids to populate combo box
                          select team.TEAM_NAME;
            foreach (var team in results)
            {
                cboxTeamName.Items.Add(team);//populate combo box
            }

            //fill datagrid with nfl schedule
            var result = from match in db.nflMATCHes//get all entries from matches table for schedule
                         select match;
            //assign results of query to DataGridView control
            nflMATCHDataGridView.DataSource = result;
        }

        private void btnNbaView_Click(object sender, EventArgs e)
        {
            nflMATCHDataGridView.Visible = false;
            nbaMATCHDataGridView.Visible = true;
            btnNbaView.Visible = false;
            btnNflView.Visible = true;

            nfl = false;//set global variable to false for nba

            cboxTeamName.Items.Clear();

            //populate combo box
            SportsDataContext db = new SportsDataContext();//create data context object
            var results = from team in db.nbaTEAM_INFOs //query to get state ids to populate combo box
                          select team.TEAM_NAME;
            foreach (var team in results)
            {
                cboxTeamName.Items.Add(team);//populate combo box
            }

            //fill datagrid with nfl schedule
            var result = from match in db.nbaMATCHes//get all entries from matches table for schedule
                         select match;
            //assign results of query to DataGridView control
            nbaMATCHDataGridView.DataSource = result;
        }
    }
}
