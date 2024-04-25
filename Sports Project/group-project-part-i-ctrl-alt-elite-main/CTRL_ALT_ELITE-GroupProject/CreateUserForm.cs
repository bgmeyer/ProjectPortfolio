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
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnCreateNewUser_Click(object sender, EventArgs e)
        {
           TextProcessor validateTxt = new TextProcessor();

            //remove white space from all inputs 
            string fName = validateTxt.removeWhiteSpace(txtUserFirstName.Text);
            string lName = validateTxt.removeWhiteSpace(txtUserLastName.Text);
            string userName = validateTxt.removeWhiteSpace(txtUserName.Text);
            string fPassword = validateTxt.removeWhiteSpace(txtUsersPassword.Text);
            string sPassword = validateTxt.removeWhiteSpace(txtUsersConPassword.Text);
           

            //check is any input is empty 
            if(!validateTxt.isEmpty(fName,lName,userName,fPassword,sPassword))
            {
                //check to make sure passwords match 
                if(fPassword == sPassword)
                {
                    //make sure passwords meets requirments 
                    if(validateTxt.passwordValidation(fPassword))
                    {

                        UserAccount validate = new UserAccount();
                        //check if username is valid 
                        if (validate.checkUsername(txtUserName.Text))
                        {
                            MessageBox.Show("Username is Taken");
                        }
                        //if not taken run this 
                        else
                        {
                            //add user to database 
                            int num = validate.addUser(userName.ToLower(), fPassword);
                            //add user information to profile 
                            validate.addProfile(num, fName, lName);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please make password have a special  character and atleast one number.");
                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match");
                    txtUsersPassword.Clear();
                    txtUsersConPassword.Clear();
                }
            }
            else
            {
                MessageBox.Show("One or more fields are empty ");
            }

           
        }
    }
}
