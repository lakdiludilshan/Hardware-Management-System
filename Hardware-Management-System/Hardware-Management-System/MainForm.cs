using Hardware_Management_System.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardware_Management_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn_max.PerformClick();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        public void AddControls(Form F)
        {
            this.CenterPanel.Controls.Clear();
            F.Dock = DockStyle.Fill;
            F.TopLevel = false;
            CenterPanel.Controls.Add(F);
            F.Show();
        }
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            btn_max.PerformClick();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            AddControls(new fromUserView());
        }
    }
}
