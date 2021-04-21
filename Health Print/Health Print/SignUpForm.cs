using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Print
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            /*Insert();*/
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (!isValid())
            {
                DialogResult result = MessageBox.Show(
                "Your sign up was unsuccesful. Input(s) have not followed a/some constraint(s)", "Sign Up Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!passwordTextBox.Text.Equals(retypePasswordTextBox.Text))
            {
                DialogResult result = MessageBox.Show(
                "Your sign up was unsuccesful. Passwords do not match", "Sign Up Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Else if ...
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\UserDatabase.mdf;Integrated Security=True"))
            {
                using (SqlCommand sqlCommand = new SqlCommand("Select count(*) from [User] where Username=@Username", connection))
                {
                    sqlCommand.Connection = connection;
                    sqlCommand.Parameters.AddWithValue("@Username", usernameTextBox.Text);
                    int userCount = 0;
                    try
                    {
                        connection.Open();
                        userCount = (int)sqlCommand.ExecuteScalar();

                    } catch (SqlException exception)
                    {
                    }
                    if (userCount > 0)
                    {
                        DialogResult result = MessageBox.Show(
                            "Your sign up was unsuccesful. This username already exists", "Sign Up Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connection.Close();
                        return;
                    }
                    else
                    {
                        connection.Close();
                    }
                }

                using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO [User] (username, first_name, last_name, age, weight, " +
                    "height, resting_heart_rate, sleep, password) " +
                        "VALUES(@Username, @FirstName, @LastName, @Age, @Weight, @Height, @RestingHeartRate, @Sleep, @Password)"))
                {
                    sqlCommand.Connection = connection;
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.Parameters.Add(new SqlParameter("Username", usernameTextBox.Text));
                    sqlCommand.Parameters.Add(new SqlParameter("FirstName", firstNameTextBox.Text));
                    sqlCommand.Parameters.Add(new SqlParameter("LastName", lastNameTextBox.Text));
                    sqlCommand.Parameters.Add(new SqlParameter("Age", ageTextBox.Text));
                    sqlCommand.Parameters.Add(new SqlParameter("Weight", weightTextBox.Text));
                    sqlCommand.Parameters.Add(new SqlParameter("Height", heightTextBox.Text));
                    sqlCommand.Parameters.Add(new SqlParameter("RestingHeartRate", restingHeartRateTextBox.Text));
                    sqlCommand.Parameters.Add(new SqlParameter("Sleep", sleepTextBox.Text));
                    sqlCommand.Parameters.Add(new SqlParameter("Password", passwordTextBox.Text));

                    try
                    {
                        connection.Open();
                        sqlCommand.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (SqlException exception)
                    {
                    }
                }
            }
        }

        public bool isValid()
        {
            Regex nameRegex = new Regex(@"^[A-Z][A-za-z-]{0,15}$");
            if (nameRegex.IsMatch(firstNameTextBox.Text) && nameRegex.IsMatch(lastNameTextBox.Text)
                && usernameTextBox.Text.Length >= 5 && passwordTextBox.Text.Length >= 8
                && ageTextBox.Text.All(char.IsDigit) && weightTextBox.Text.All(char.IsDigit) && heightTextBox.Text.All(char.IsDigit)
                && restingHeartRateTextBox.Text.All(char.IsDigit) && !isSignUpEmpty()) {
                return true;
            }
            return false;

            // int stringTest.All(char.IsDigit);
            // double  
        }

        public bool isSignUpEmpty()
        {
            foreach (Control control in this.Controls)
            {
                if (control.GetType().ToString() == "System.Windows.Form.Textbox")
                {
                    if (control.Text.Trim().Equals(""))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /*public void Insert()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\2021WinterAppDEV\PROJECT\Health Print\Health Print\UserDatabase.mdf;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO [User] (username, first_name, last_name, age, weight, height, resting_heart_rate, sleep, password) " +
                        "VALUES('christiankfoury', 'christian', 'kfoury', 18, 150, 170, 70, 8, 'abc123')";

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        firstNameTextBox.Text = e.Message;
                    }

                }
            }
        }*/
    }    
}
