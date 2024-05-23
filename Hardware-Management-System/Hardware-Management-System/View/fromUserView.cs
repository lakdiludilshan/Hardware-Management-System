using Hardware_Management_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardware_Management_System.View
{
    public partial class fromUserView : SampleView
    {
        public fromUserView()
        {
            InitializeComponent();
        }

        private void fromUserView_Load(object sender, EventArgs e)
        {

        }
        public override void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        public override void btn_add_click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new fromUserAdd());
        }

        private void LoadData()
        {
            ListBox lb = new ListBox();
            lb.Items.Add(uvId);
            lb.Items.Add(uvName);
            lb.Items.Add(uvUsername);
            lb.Items.Add(uvPass);
            lb.Items.Add(uvPhone);

            string qry = @"Select userId, uName, uUsername";
            MainClass.LoadData();
        }
    }
}
