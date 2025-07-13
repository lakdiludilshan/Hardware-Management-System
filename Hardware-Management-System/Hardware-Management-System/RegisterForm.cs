using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Hardware_Management_System
{
    public partial class RegisterForm : Sample
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lakdilu\Documents\hardware.mdf;Integrated Security=True;Connect Timeout=30");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void log_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void reg_signinbtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void log_showpass_CheckedChanged(object sender, EventArgs e)
        {
            reg_password.PasswordChar = reg_showpass.Checked ? '\0' : '*';
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            if(reg_username.Text == "" || reg_password.Text == "")
            {
                MessageBox.Show("Please fill all the blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        //To check if the user still existing
                        string selectUsername = "SELECT COUNT(id) FROM users WHERE username = @user";

                        using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@user", reg_username.Text.Trim());
                            int count = (int)checkUser.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(reg_username.Text.Trim() + " is already taken"
                                , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;

                                String insertData = "INSERT INTO users" +
                                    "(username, password, date_register)" +
                                    "VALUES(@username, @password, @dateReg)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", reg_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", reg_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateReg", today);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered Successfully!!"
                                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    LoginForm loginForm = new LoginForm();
                                    loginForm.Show();
                                    this.Hide();
                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }

                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
