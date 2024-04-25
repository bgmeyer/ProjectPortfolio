using System;
using System.ComponentModel.Design;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace UserAccountManager
{

    public class UserAccount
    {
        //Please enter your connection string here 
        private string connectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\jcc80\\Downloads\\group-project-part-i-ctrl-alt-elite-main\\group-project-part-i-ctrl-alt-elite-main\\UserAccountManager\\UsersDB.mdf;Integrated Security=True;User Instance=True";
        

        public int addUser(string username, string password)
        {

            // create object rng that is a cryptographically secure random number generator
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            //create salt array size of 32 byte 
            byte[] salt = new byte[32];
            //fill array with random bytes 
            rng.GetBytes(salt);

            //store Hash password with salt we generated
            Rfc2898DeriveBytes hasher = new Rfc2898DeriveBytes(password, salt, 1000);
            //store hashed password 
            byte[] hashedPassword = hasher.GetBytes(32);

            //convert salt and hashed password to string 
            string saltString = Convert.ToBase64String(salt);
            string hashedPasswordString = Convert.ToBase64String(hashedPassword);

            //Insert user into database 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                //add user information to tabel 
                string query = "INSERT INTO user_accounts (username, salt, hashed_password) VALUES (@username, @salt, @hashedPassword); SELECT SCOPE_IDENTITY();";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@salt", saltString);
                command.Parameters.AddWithValue("@hashedPassword", hashedPasswordString);
                //perfom Sql command 
                command.ExecuteNonQuery();
                int userId = Convert.ToInt32(command.ExecuteScalar());
                return userId;
            }
        }

        //Validate user 
        public bool validateUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                //select username from user_accounts table 
                string query = "SELECT salt, hashed_password FROM user_accounts WHERE username = @username";
                //Create a command object  with query and connection 
                SqlCommand command = new SqlCommand(query, connection);
                //add parameter @username and set value to username  
                command.Parameters.AddWithValue("@username", username);
                //store query output into a SqlDataReader object 
                SqlDataReader reader = command.ExecuteReader();
                
                //check to see if  reader returned a row 
                if (reader.Read())
                {
                    //store salt into userSalt 
                    string userSalt = reader["salt"].ToString();
                    //store hashed_password into userHashed Password 
                    string userHashedPassword = reader["hashed_password"].ToString();

                    //hash password user enetered with salt from DB 
                    Rfc2898DeriveBytes hasher = new Rfc2898DeriveBytes(password, Convert.FromBase64String(userSalt), 1000);
                    //store generated hash into variable 
                    byte[] enteredPasswordHash = hasher.GetBytes(32);
                    //check if hash from database and hash from user input are correct and return true
                    if (Convert.ToBase64String(enteredPasswordHash) == userHashedPassword)
                    {
                        return true;
                    }
                }
                //return false 
                return false;
            }
           
        }
        
        public bool checkUsername(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                //Search for username in User_accounts table
                string query = "SELECT COUNT (*) FROM user_accounts WHERE username = @username";
                //Create a command object  with query and connection 
                SqlCommand command = new SqlCommand(query, connection);
                //add parameter @username and set value to username  
                command.Parameters.AddWithValue("@username", username);
                // assing number of people returned to int
                int id = (int)command.ExecuteScalar();
                //check if there is user in the database 
                if (id != 0)
                {
                    return true;
                }
                return false;
            }
                
        }

        public void addProfile(int userId, string firstName, string lastName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO user_profiles(user_account_id, first_name, last_name) VALUES( @UserAccountId, @FirstName, @LastName); ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserAccountId", userId);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.ExecuteNonQuery();
            }

        }

        public Profile accountInformation(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT user_accounts.username, user_profiles.first_name, user_profiles.last_name, user_profiles.favorite_team, user_profiles.favorite_player FROM user_accounts JOIN user_profiles ON user_accounts.id = user_profiles.user_account_id WHERE user_accounts.username = @username;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string userName = reader["username"].ToString();
                    string firstName = reader["first_name"].ToString();
                    string lastName = reader["last_name"].ToString();
                    string favoriteTeam = reader["favorite_team"].ToString();
                    string favoritePlayer = reader["favorite_player"].ToString();
                    Profile userProfile = new Profile(userName, firstName, lastName, favoriteTeam, favoritePlayer);
                    return userProfile;
                }
            }
            return null;
        }










    }


}
