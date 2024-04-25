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
    public partial class MainForm : Form

    {
        /*This form serves as the "Parent Form" because this form loads
         all other forms into the main panel which allows us to not have to 
         repeatedly close and create forms. The form object are created once upon
         the main form loading and displayed one at a time depending on the 
         users selection in the panel
         */
        
        public MainForm(Profile userInformation )
        {
            InitializeComponent();
            this.userInformation = userInformation;
            btnFormSettings.Text = userInformation.userName;
        }
        
        //Creating Form Objects
        public DashboardForm frmDashboard = new DashboardForm();
        public  MatchesForm frmMatches = new MatchesForm();
        public TeamsForm frmTeams = new TeamsForm();
        public PlayersForm frmPlayers = new PlayersForm();
        public nbaPlayersForm frmNbaPlayers = new nbaPlayersForm();
        public nbaTeamForm frmNbaTeams = new nbaTeamForm();
        public Profile userInformation { get; set; }
        


        public void Load_Form (object Form)
        {
            //Allows all the forms to be loaded into the main panel. Call the method and pass the form.
            if (this.pnlDisplaysSelectForm.Controls.Count > 0)
            {
                this.pnlDisplaysSelectForm.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlDisplaysSelectForm.Controls.Add(f);
            this.pnlDisplaysSelectForm.Tag = f;
            f.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Load_Form(frmDashboard);
        }
        
        private void BtnFormDashboard_Click(object sender, EventArgs e)
        {
            Load_Form(frmDashboard);
        }

        public void BtnFormSettings_Click(object sender, EventArgs e)
        {
            SettingsForm frmSettings = new SettingsForm(this.userInformation);
            Load_Form(frmSettings);
        }

        private void BtnFormMatches_Click(object sender, EventArgs e)
        {
            Load_Form(frmMatches);
        }

        private void BtnFormTeams_Click(object sender, EventArgs e)
        {
            Load_Form(frmTeams);
        }

        private void BtnFormPlayers_Click(object sender, EventArgs e)
        {
            Load_Form(frmPlayers);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            LoginForm newLoginForm = new LoginForm();
            this.Hide();
            newLoginForm.ShowDialog();
            
           
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFormNbaPlayers_Click(object sender, EventArgs e)
        {
            Load_Form(frmNbaPlayers);
        }

        private void btnFormNbaTeams_Click(object sender, EventArgs e)
        {
            Load_Form(frmNbaTeams);
        }
    }
}
