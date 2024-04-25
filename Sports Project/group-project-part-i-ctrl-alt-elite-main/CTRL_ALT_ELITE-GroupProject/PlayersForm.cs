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
    /*This form will allow users to search for specific players and view their stats
     as well and maybe a graphic and picture
     */
    public partial class PlayersForm : Form
    {
        public PlayersForm()
        {
            InitializeComponent();
        }

        private void PlayersForm_Load(object sender, EventArgs e)
        {
            SportsDataContext db = new SportsDataContext();//create data context object
            var results = from player in db.nflPLAYER_INFOs//query to get state ids to populate combo box
                          select player.FULL_NAME;
            foreach (var player in results)
            {
                cboxPlayerName.Items.Add(player);//populate combo box
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (cboxPlayerName.SelectedIndex == -1)
            {
                MessageBox.Show("Error! Please select a player to view information about.");//error message if no player has been selected
            }
            else
            {
                string player = Convert.ToString(cboxPlayerName.SelectedItem);//give selected player to variable
                IQueryable<nflPLAYER_FUMBLES_STAT> resultsFumble;//variable for fumble query results
                IQueryable<nflPLAYER_INTERCEPTIONS_STAT> resultsInterception;//variable for interception query results
                IQueryable<nflPLAYER_PASSING_STAT> resultsPassing;//variable for interception query results
                IQueryable<nflPLAYER_RECEIVING_STAT> resultsReceiving;//variable for receiving query results
                IQueryable<nflPLAYER_RUSHING_STAT> resultsRushing;//variable for rushing query results
                IQueryable<nflPLAYER_TACKLES_STAT> resultsTackles;//variable for tackles query results

                //available stats to data grids

                resultsFumble = GetFumbleStat(player);//call method for fumble stats and set equal to result variable
                nflPLAYER_FUMBLES_STATDataGridView.DataSource = resultsFumble;//give data from query to datagrid

                resultsInterception = GetInterceptionStat(player);//call method for interception stats and set equal to results variable
                nflPLAYER_INTERCEPTIONS_STATDataGridView.DataSource = resultsInterception;//give data from query to datagrid

                resultsPassing = GetPassingStat(player);//call method for passing stats and set equal to results variable
                nflPLAYER_PASSING_STATDataGridView.DataSource = resultsPassing;//give data from query to datagrid

                resultsReceiving = GetReceivingStat(player);//call method for receiving stats and set equal to results variable
                nflPLAYER_RECEIVING_STATDataGridView.DataSource = resultsReceiving;//give data from query to datagrid

                resultsRushing = GetRushingStat(player);//call method for rushing stats and set equal to results variable
                nflPLAYER_RUSHING_STATDataGridView.DataSource = resultsRushing;//give data from query to datagrid

                resultsTackles = GetTacklesStat(player);//call method for tackles stats and set equal to results variable
                nflPLAYER_TACKLES_STATDataGridView.DataSource = resultsTackles;//give data from query to datagrid

                //player name to label (top left)
                lblOutputPlayerName.Visible = true;//make label visible
                lblOutputPlayerName.Text = player;//give label player name to display

                //player team to label
                lblTeam.Visible = true;//make label visible
                GetTeamName(player);//call method to get team name

                //player num to label
                lblPlayerNum.Visible = true;//make label visible
                GetPlayerNum(player);//call method to get player num 

                //player position to label
                GetPosition(player);//call method to get player position

                //player height to label
                GetHeight(player);//call method to get player height

                //player weight to label
                GetWeight(player);//call method to get player weight 

                //player dob to label
                GetDOB(player);//call method to get player dob


            }
        }

        public IQueryable<nflPLAYER_FUMBLES_STAT> GetFumbleStat(string playerName)//method to search player fumble stat
        {
            SportsDataContext db = new SportsDataContext();
            var results = from player in db.nflPLAYER_FUMBLES_STATs
                          where player.Player.Contains(playerName)
                          select player;
            return results;
        }

        public IQueryable<nflPLAYER_INTERCEPTIONS_STAT> GetInterceptionStat(string playerName)//method to search player interception stat
        {
            SportsDataContext db = new SportsDataContext();
            var results = from player in db.nflPLAYER_INTERCEPTIONS_STATs
                          where player.PLAYER.Contains(playerName)
                          select player;
            return results;
        }

        public IQueryable<nflPLAYER_PASSING_STAT> GetPassingStat(string playerName)//method to search player passing stat
        {
            SportsDataContext db = new SportsDataContext();
            var results = from player in db.nflPLAYER_PASSING_STATs
                          where player.Player.Contains(playerName)
                          select player;
            return results;
        }

        public IQueryable<nflPLAYER_RECEIVING_STAT> GetReceivingStat(string playerName)//method to search player receiving stat
        {
            SportsDataContext db = new SportsDataContext();
            var results = from player in db.nflPLAYER_RECEIVING_STATs
                          where player.Player.Contains(playerName)
                          select player;
            return results;
        }

        public IQueryable<nflPLAYER_RUSHING_STAT> GetRushingStat(string playerName)//method to search player rushing stat
        {
            SportsDataContext db = new SportsDataContext();
            var results = from player in db.nflPLAYER_RUSHING_STATs
                          where player.Player.Contains(playerName)
                          select player;
            return results;
        }

        public IQueryable<nflPLAYER_TACKLES_STAT> GetTacklesStat(string playerName)//method to search player tackles stat
        {
            SportsDataContext db = new SportsDataContext();
            var results = from player in db.nflPLAYER_TACKLES_STATs
                          where player.PLAYER.Contains(playerName)
                          select player;
            return results;
        }

        public void GetTeamName(string playerName)// method to query team of player
        {
            SportsDataContext db = new SportsDataContext();
            var results = from player in db.nflPLAYER_INFOs
                          where player.FULL_NAME.Contains(playerName)
                          select player.team;

            //assign results of query to controls
            foreach (var result in results)
            {
                lblTeam.Text = result.ToString();
            }
        }

        public void GetPlayerNum(string playerName)// method to query jersey num of player
        {
            SportsDataContext db = new SportsDataContext();
            var results = from player in db.nflPLAYER_INFOs
                          where player.FULL_NAME.Contains(playerName)
                          select player.NUMBER;

            //assign results of query to controls
            foreach (var result in results)
            {
                lblPlayerNum.Text = result.ToString();
            }
        }

        public void GetPosition(string playerName)// method to query position of player
        {
            SportsDataContext db = new SportsDataContext();
            var results = from player in db.nflPLAYER_INFOs
                          where player.FULL_NAME.Contains(playerName)
                          select player.POSITION;

            //assign results of query to controls
            foreach (var result in results)
            {
                lblOutputPosition.Text = result.ToString();
            }
        }

        public void GetHeight(string playerName)// method to query height of player
        {
            SportsDataContext db = new SportsDataContext();
            var results = from player in db.nflPLAYER_INFOs
                          where player.FULL_NAME.Contains(playerName)
                          select player.HEIGHT;

            //assign results of query to controls
            foreach (var result in results)
            {
                lblOutputHeight.Text = result.ToString();
            }
        }

        public void GetWeight(string playerName)// method to query weight of player
        {
            SportsDataContext db = new SportsDataContext();
            var results = from player in db.nflPLAYER_INFOs
                          where player.FULL_NAME.Contains(playerName)
                          select player.WEIGHT;

            //assign results of query to controls
            foreach (var result in results)
            {
                lblOutputWeight.Text = result.ToString();
            }
        }

        public void GetDOB(string playerName)// method to query dob of player
        {
            SportsDataContext db = new SportsDataContext();
            var results = from player in db.nflPLAYER_INFOs
                          where player.FULL_NAME.Contains(playerName)
                          select player.DOB;

            //assign results of query to controls
            foreach (var result in results)
            {
                lblOutputBirthday.Text = result.ToString();
            }
        }
    }
}
