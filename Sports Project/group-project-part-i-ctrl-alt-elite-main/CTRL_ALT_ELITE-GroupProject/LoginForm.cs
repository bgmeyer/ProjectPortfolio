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
    public partial class LoginForm : Form
    {
        /*This form will allow users to login and create new users the 
         data entered will be cross checked by the connected database and
         allow or deny entry depending on the data
         */

        public LoginForm()
        {
            InitializeComponent();
            lblMessage.Text = "";
            
        }
        //clear text boxes
        private void clearText()
        {
            txtUserName.Clear();
            txtUserPassword.Clear();
        }
       
        private void BtnTesting_Click(object sender, EventArgs e)
        {
            //This button will be deleted when the login feature is completed

           // MainForm form = new MainForm();
           // form.ShowDialog();
            //this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserAccount validate = new UserAccount();
            if (validate.validateUser(txtUserName.Text , txtUserPassword.Text))
            {
                
                MessageBox.Show("Welcome!");
                Profile userInformation = validate.accountInformation(txtUserName.Text);
                MainForm form = new MainForm(userInformation);
                form.ShowDialog();
                this.Close();
            }
            else
            {
                lblMessage.Text = "Invlaid username or password";
                clearText(); 
            }
            

           
        }

        private void btnCreateNewUser_Click(object sender, EventArgs e)
        {
            CreateUserForm newCreateUserForm = new CreateUserForm();
            newCreateUserForm.ShowDialog();
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
