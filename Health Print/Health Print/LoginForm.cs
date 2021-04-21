using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Print
{
    public partial class LoginForm : Form
    {
        private SignUpForm childForm;


        public LoginForm()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            childForm = new SignUpForm();
            childForm.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\UserDatabase.mdf;Integrated Security=True"))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("Select count(*) from [User] where Username=@Username", connection);
                command.Parameters.AddWithValue("@Username", usernameTextBox.Text);
                int userCount = (int) command.ExecuteScalar();
                if (userCount > 0)
                {
                    command = new SqlCommand("Select Password from [User] where Username=@Username");
                    command.Parameters.AddWithValue("@Username", usernameTextBox.Text);
                    // Had to reinitialize the connection, because exception was throwing that my connection was
                    // not initialized
                    // My guess is that it is because we are executing another command
                    command.Connection = connection;
                    string password = "";
                    using (SqlDataReader oReader = command.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            password = oReader["Password"].ToString();
                        }
                        connection.Close();
                    }
                    if (passwordTextBox.Text.Equals(password))
                    {
                        // NEW FORM
                        DialogResult result = MessageBox.Show(
                            "CORRECT PASSWORD", "Password SUCEESSFUL",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show(
                            "Incorrect Password. Please try again", "Password Unsuccessful",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                DialogResult result = MessageBox.Show(
                    "Your login was unsuccessful. Try again, or sign up if you have not", "Log In Unsuccessful",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
