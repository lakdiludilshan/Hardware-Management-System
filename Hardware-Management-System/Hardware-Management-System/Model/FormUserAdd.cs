using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardware_Management_System.Model
{
    public partial class FormUserAdd : SampleAdd
    {
        public FormUserAdd()
        {
            InitializeComponent();
        }

        public int id = 0;

        public void btn_save_Click_2(object sender, EventArgs e)
        {
            //if (MainClass.Validation(this)== false)
            //{
            //    gunaMessageDialog1.Buttons = Guna.UI.WinForms.GunaMessageDialogButtons.OK;
            //    gunaMessageDialog1.Caption = "POS";
            //}
            if (!MainClass.Validation(this))
            {
                MessageBox.Show("Please fill all required fields.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                
            }
        }

        public string filePath = "";
        Byte[] imageByteArray;
        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                txt_pic.Image = new Bitmap(filePath);
            }
        }
        private void FormUserAdd_Load(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
