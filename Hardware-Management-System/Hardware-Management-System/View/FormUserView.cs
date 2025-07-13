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
    public partial class FormUserView : SampleView
    {
        public FormUserView()
        {
            InitializeComponent();
        }

        public void FormUserView_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public override void btn_add_click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new FormUserAdd());
        }

        public override void text_search_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvname);
            lb.Items.Add(dgvuserName);
            lb.Items.Add(dgvpass);
            lb.Items.Add(dgvphone);

            string qry = @"Select userID ,uName ,uUsername ,uPass ,uPhone from users
                            where uName like '%" + text_search.Text + "%' order by userID desc";
            MainClass.LoadData(qry,gunaDataGridView1,lb);

        }
    }
}
