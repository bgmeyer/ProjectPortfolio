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
    public partial class nbaPlayersForm : Form
    {
        public nbaPlayersForm()
        {
            InitializeComponent();
        }

        private void nbaPlayersForm_Load(object sender, EventArgs e)
        {
            SportsDataContext db = new SportsDataContext();//create data context object
            var results = from player in db.nbaPLAYER_STATs//query to get state ids to populate combo box
                          select player.PLAYER_ID;
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
                var testcase = player;
                var split = testcase.Split(new char[] { ' ' }, 2);
                var firstName = "";
                var lastName = "";
                firstName = split[0];
                lastName = split[1];



                //player name to label (top left)
                lblOutputPlayerName.Visible = true;//make label visible
                lblOutputPlayerName.Text = player;//give label player name to display

                //player team to label
                lblTeam.Visible = true;//make label visible
                GetTeamName(firstName, lastName);//call method to get team name

                //player num to label
                lblPlayerNum.Visible = true;//make label visible
                GetPlayerNum(firstName, lastName);//call method to get player num 

                //player position to label
                GetPosition(firstName, lastName);//call method to get player position

                //player height to label
                GetHeight(firstName, lastName);//call method to get player height

                //player weight to label
                GetWeight(firstName, lastName);//call method to get player weight 

                //player dob to label
                GetDOB(firstName, lastName);//call method to get player dob

                //stat year to label
                GetYear(player);//call method to get stat year

                //stat point per game to label
                GetPoints(player);//call method to get points per game

                //stat rebounds per game to label
                GetRebounds(player);//call method to get rebounds per game

                //stat assists per game to label
                GetAssists(player);//call method to get assists per game

                //stat minutes per game to label
                GetMinutes(player);//call method to get minutes per game
            }
        }


        public void GetTeamName(string first, string last)// method to query team of player
        {
            SportsDataContext db = new SportsDataContext();
            var results = from player in db.nbaPLAYER_INFOs
                          where player.LAST_NAME.Contains(last) && player.FIRST_NAME.Contains(first)
                          select player.TEAM;

            //assign results of query to controls
            foreach (var result in results)
            {
                lblTeam.Text = result.ToString();
            }
        }

        public void GetPlayerNum(string first, string last)// method to query jersey num of player
        {
            SportsDataContext db = new SportsDataContext();
            var results = from player in db.nbaPLAYER_INFOs
                          where player.FIRST_NAME.Contains(first) && player.LAST_NAME.Contains(last)
                          select player.NUMBER;

            //assign results of query to controls
            foreach (var result in results)
            {
                lblPlayerNum.Text = result.ToString();
            }
        }

        public void GetPosition(string first, string last)// method to query position of player
        {
            SportsDataContext db = new SportsDataContext();
            var results = from player in db.nbaPLAYER_INFOs
                          where player.FIRST_NAME.Contains(first) && player.LAST_NAME.Contains(last)
                          select player.POSITION;

            //assign results of query to controls
            foreach (var result in results)
            {
                lblOutputPosition.Text = result.ToString();
            }
        }

        public void GetHeight(string first, string last)// method to query height of player
        {
            SportsDataContext db = new SportsDataContext();
            var results = from player in db.nbaPLAYER_INFOs
                          where player.FIRST_NAME.Contains(first) && player.LAST_NAME.Contains(last)
                          select player.HEIGHT;

            //assign results of query to controls
            foreach (var result in results)
            {
                lblOutputHeight.Text = result.ToString();
            }
        }

        public void GetWeight(string first, string last)// method to query weight of player
        {
            SportsDataContext db = new SportsDataContext();
            var results = from player in db.nbaPLAYER_INFOs
                          where player.FIRST_NAME.Contains(first) && player.LAST_NAME.Contains(last)
                          select player.WEIGHT;

            //assign results of query to controls
            foreach (var result in results)
            {
                lblOutputWeight.Text = result.ToString();
            }
        }

        public void GetDOB(string first, string last)// method to query dob of player
        {
            SportsDataContext db = new SportsDataContext();
            var results = from player in db.nbaPLAYER_INFOs
                          where player.FIRST_NAME.Contains(first) && player.LAST_NAME.Contains(last)
                          select player.DOB;

            //assign results of query to controls
            foreach (var result in results)
            {
                lblOutputBirthday.Text = result.ToString();
            }
        }

        public void GetYear(string playerName)//method to query year of player stat
        {
            SportsDataContext db = new SportsDataContext();
            var results = from player in db.nbaPLAYER_STATs
                          where player.PLAYER_ID.Contains(playerName)
                          select player.STAT_YEAR;

            //assign results of query to control
            foreach (var result in results)
            {
                lblOutputYear.Text = result.ToString();
            }
        }

        public void GetPoints(string playerName)//method to query points per game
        {
            SportsDataContext db = new SportsDataContext();
            var results = from player in db.nbaPLAYER_STATs
                          where player.PLAYER_ID.Contains(playerName)
                          select player.POINTS_PER_GAME;

            //assign results of query to control
            foreach (var result in results)
            {
                lblOutputPoints.Text = result.ToString();
            }
        }

        public void GetRebounds(string playerName)//method to query points per game
        {
            SportsDataContext db = new SportsDataContext();
            var results = from player in db.nbaPLAYER_STATs
                          where player.PLAYER_ID.Contains(playerName)
                          select player.REBOUNDS_PER_GAME;

            //assign results of query to control
            foreach (var result in results)
            {
                lblOutputRebounds.Text = result.ToString();
            }
        }

        public void GetAssists(string playerName)//method to query points per game
        {
            SportsDataContext db = new SportsDataContext();
            var results = from player in db.nbaPLAYER_STATs
                          where player.PLAYER_ID.Contains(playerName)
                          select player.ASSISTS_PER_GAME;

            //assign results of query to control
            foreach (var result in results)
            {
                lblOutputAssists.Text = result.ToString();
            }
        }

        public void GetMinutes(string playerName)//method to query minutes per game
        {
            SportsDataContext db = new SportsDataContext();
            var results = from player in db.nbaPLAYER_STATs
                          where player.PLAYER_ID.Contains(playerName)
                          select player.MINUTES_PER_GAME;

            //assign results of query to control
            foreach (var result in results)
            {
                lblOutputMinutes.Text = result.ToString();
            }
        }
    }
}
