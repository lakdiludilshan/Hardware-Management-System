using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;
using System.IO;


namespace Hardware_Management_System
{
    internal class MainClass
    {
        // 🔧 Define your connection string here
        private static readonly string con_string = "Data Source=LAKDILU\\SQLEXPRESS;Initial Catalog=\"Hardware management system\";Integrated Security=True;";
        public static SqlConnection con = new SqlConnection(con_string);



        // 🔧 User credentials (should ideally not be global like this)
        private static string _user;
        private static Image _img;

        public static string USER
        {
            get { return _user; }
            private set { _user = value; }
        }

        public static Image IMG
        {
            get { return _img; }
            private set { _img = value; }
        }

        // ✅ Check user validation with parameterized query
        public static bool IsValidUser(string user, string password)
        {
            bool isValid = false;
            string qry = "SELECT * FROM users WHERE username = @user AND upass = @pass";

            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@pass", password);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    isValid = true;
                    USER = dt.Rows[0]["uName"].ToString();

                    Byte[] imageArray = (byte[])dt.Rows[0]["uImage"];
                    byte[] imageByteArray = imageArray;
                    IMG = Image.FromStream(new MemoryStream(imageArray));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Error");
            }

            return isValid;
        }

        // ✅ Enable/Disable double buffering on a Panel
        public static void StopBuffering(System.Windows.Forms.Panel ctr, bool doubleBuffer)
        {
            try
            {
                typeof(Control).InvokeMember("DoubleBuffered",
                    BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                    null, ctr, new object[] { doubleBuffer });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // ✅ Generic SQL execution with parameters
        public static int SQ1(string qry, Hashtable ht)
        {
            int res = 0;

            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.CommandType = CommandType.Text;

                    foreach (DictionaryEntry item in ht)
                    {
                        cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                    }

                    if (con.State == ConnectionState.Closed) con.Open();
                    res = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "DB Error");
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }

            return res;
        }

        // ✅ Load data from DB into DataGridView and bind columns based on ListBox items
        public static void LoadData(string qry, DataGridView gv, System.Windows.Forms.ListBox lb)
        {
            gv.CellFormatting += new DataGridViewCellFormattingEventHandler(gv_CellFormatting);

            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colName = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colName].DataPropertyName = dt.Columns[i].ColumnName;
                }

                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }

        private static void gv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Guna.UI.WinForms.GunaDataGridView gv = (Guna.UI.WinForms.GunaDataGridView)sender;
            int count = 0;

            foreach (DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        // ✅ Show a blurred background modal
        public static void BlurBackground(Form Model)
        {
            Form background = new Form();
            using (Model)
            {
                background.StartPosition = FormStartPosition.Manual;
                background.FormBorderStyle = FormBorderStyle.None;
                background.Opacity = 0.5d;
                background.BackColor = Color.Black;

                // 🔧 MainForm.Instance should be declared in MainForm.cs
                // Example:
                // public static MainForm Instance { get; private set; }
                // Instance = this; in the MainForm constructor.
                // Uncomment the following lines after ensuring Instance is implemented

                background.Size = MainForm.Instance.Size;
                background.Location = MainForm.Instance.Location;
                background.ShowInTaskbar = false;
                background.Show();
                Model.Owner = background;
                Model.ShowDialog(background);
                background.Dispose();
            }     
        }

        // ✅ Fill ComboBox from database
        public static void CBFill(string qry, ComboBox cb)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cb.DisplayMember = "name"; // Ensure column exists in result
                cb.ValueMember = "Id";     // Ensure column exists in result
                cb.DataSource = dt;
                cb.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ComboBox Fill Error");
            }
        }

        // ❌ Not implemented method stub
        internal static void LoadData()
        {
            throw new NotImplementedException("LoadData with no parameters is not yet implemented.");
        }

        //public static bool Validation(Form F)
        //{
        //    bool isValid = false;

        //    int count = 0;

        //    foreach (Control c in F.Controls)
        //    {
        //        if (Convert.ToString(c.Tag) != "" && Convert.ToString(c.Tag) != null)
        //        {
        //            if (c is Guna.UI.WinForms.GunaTextBox)
        //            {
        //                Guna.UI.WinForms.GunaTextBox t = (Guna.UI.WinForms.GunaTextBox)c;
        //                if (t.Text.Trim() == "")
        //                {
        //                    t.BorderColor = Color.Red;
        //                    t.FocusedBorderColor = Color.Red;
        //                    t.FocusedForeColor = Color.Black;
        //                    t.ForeColor = Color.Black;
        //                    count++;
        //                }
        //                else
        //                {
        //                    t.BorderColor = Color.FromArgb(213, 218, 223);
        //                    t.FocusedBorderColor = Color.FromArgb(30, 144, 255);
        //                    t.FocusedForeColor = Color.FromArgb(30, 144, 255);
        //                }
        //            }
        //        }

        //        if (count == 0)
        //        {
        //            isValid = true;
        //        }
        //        else
        //        {
        //            isValid = false;
        //        }
        //    }

        //    return isValid;
        //}

        public static bool Validation(Form F)
        {
            bool isValid = true; // Assume valid initially
            int count = 0;

            foreach (Control c in F.Controls)
            {
                if (!string.IsNullOrWhiteSpace(Convert.ToString(c.Tag)))
                {
                    if (c is Guna.UI.WinForms.GunaTextBox t)
                    {
                        if (string.IsNullOrWhiteSpace(t.Text))
                        {
                            // Mark textbox as invalid
                            t.BorderColor = Color.Red;
                            t.FocusedBorderColor = Color.Red;
                            t.FocusedForeColor = Color.Black;
                            t.ForeColor = Color.Black;

                            count++;
                        }
                        else
                        {
                            // Reset to normal style
                            t.BorderColor = Color.FromArgb(213, 218, 223);
                            t.FocusedBorderColor = Color.FromArgb(30, 144, 255);
                            t.FocusedForeColor = Color.FromArgb(30, 144, 255);
                        }
                    }
                }
            }

            // Final result
            isValid = count == 0;

            return isValid;
        }

    }
}
