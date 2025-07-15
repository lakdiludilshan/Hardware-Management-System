namespace Hardware_Management_System.Model
{
    partial class FormUserAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new Guna.UI.WinForms.GunaTextBox();
            this.txt_user = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pass = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_phone = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_pic = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.btn_browse = new Guna.UI.WinForms.GunaButton();
            this.message1 = new System.Messaging.Message();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.ButtonType = Guna.UI.WinForms.AdvenceButtonType.DefaultButton;
            this.btn_save.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_save.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click_2);
            // 
            // btn_close
            // 
            this.btn_close.ButtonType = Guna.UI.WinForms.AdvenceButtonType.DefaultButton;
            this.btn_close.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_close.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // txt_name
            // 
            this.txt_name.BaseColor = System.Drawing.Color.White;
            this.txt_name.BorderColor = System.Drawing.Color.Silver;
            this.txt_name.BorderSize = 1;
            this.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_name.FocusedBorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_name.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_name.Location = new System.Drawing.Point(29, 210);
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.Radius = 14;
            this.txt_name.Size = new System.Drawing.Size(184, 30);
            this.txt_name.TabIndex = 0;
            this.txt_name.Tag = "v";
            this.txt_name.TextOffsetX = 10;
            this.txt_name.Click += new System.EventHandler(this.gunaTextBox1_Click);
            // 
            // txt_user
            // 
            this.txt_user.BaseColor = System.Drawing.Color.White;
            this.txt_user.BorderColor = System.Drawing.Color.Silver;
            this.txt_user.BorderSize = 1;
            this.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_user.FocusedBorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_user.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_user.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_user.Location = new System.Drawing.Point(254, 210);
            this.txt_user.Name = "txt_user";
            this.txt_user.PasswordChar = '\0';
            this.txt_user.Radius = 14;
            this.txt_user.Size = new System.Drawing.Size(184, 26);
            this.txt_user.TabIndex = 1;
            this.txt_user.Tag = "v";
            this.txt_user.TextOffsetX = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Username";
            // 
            // txt_pass
            // 
            this.txt_pass.BaseColor = System.Drawing.Color.White;
            this.txt_pass.BorderColor = System.Drawing.Color.Silver;
            this.txt_pass.BorderSize = 1;
            this.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pass.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_pass.FocusedBorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_pass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_pass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_pass.Location = new System.Drawing.Point(32, 325);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '\0';
            this.txt_pass.Radius = 14;
            this.txt_pass.Size = new System.Drawing.Size(184, 30);
            this.txt_pass.TabIndex = 2;
            this.txt_pass.Tag = "v";
            this.txt_pass.TextOffsetX = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // txt_phone
            // 
            this.txt_phone.BaseColor = System.Drawing.Color.White;
            this.txt_phone.BorderColor = System.Drawing.Color.Silver;
            this.txt_phone.BorderSize = 1;
            this.txt_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_phone.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_phone.FocusedBorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_phone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_phone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_phone.Location = new System.Drawing.Point(254, 325);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.PasswordChar = '\0';
            this.txt_phone.Radius = 14;
            this.txt_phone.Size = new System.Drawing.Size(184, 30);
            this.txt_phone.TabIndex = 3;
            this.txt_phone.TextOffsetX = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone";
            // 
            // txt_pic
            // 
            this.txt_pic.BaseColor = System.Drawing.Color.White;
            this.txt_pic.Image = global::Hardware_Management_System.Properties.Resources.pngwing_com__6_;
            this.txt_pic.Location = new System.Drawing.Point(529, 182);
            this.txt_pic.Name = "txt_pic";
            this.txt_pic.Size = new System.Drawing.Size(140, 140);
            this.txt_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txt_pic.TabIndex = 15;
            this.txt_pic.TabStop = false;
            this.txt_pic.UseTransfarantBackground = false;
            // 
            // btn_browse
            // 
            this.btn_browse.AnimationHoverSpeed = 0.07F;
            this.btn_browse.AnimationSpeed = 0.03F;
            this.btn_browse.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_browse.BorderColor = System.Drawing.Color.Black;
            this.btn_browse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse.ForeColor = System.Drawing.Color.White;
            this.btn_browse.Image = null;
            this.btn_browse.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_browse.Location = new System.Drawing.Point(529, 328);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_browse.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_browse.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_browse.OnHoverImage = null;
            this.btn_browse.OnPressedColor = System.Drawing.Color.Black;
            this.btn_browse.Radius = 18;
            this.btn_browse.Size = new System.Drawing.Size(140, 34);
            this.btn_browse.TabIndex = 4;
            this.btn_browse.Text = "Browse";
            this.btn_browse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // FormUserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 506);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.txt_pic);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label2);
            this.Name = "FormUserAdd";
            this.Text = "FormUserAdd";
            this.Load += new System.EventHandler(this.FormUserAdd_Load);
            this.Controls.SetChildIndex(this.gunaPanel1, 0);
            this.Controls.SetChildIndex(this.gunaPanel2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txt_name, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txt_user, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txt_pass, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txt_phone, 0);
            this.Controls.SetChildIndex(this.txt_pic, 0);
            this.Controls.SetChildIndex(this.btn_browse, 0);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public Guna.UI.WinForms.GunaTextBox txt_name;
        public Guna.UI.WinForms.GunaTextBox txt_user;
        private System.Windows.Forms.Label label3;
        public Guna.UI.WinForms.GunaTextBox txt_pass;
        private System.Windows.Forms.Label label4;
        public Guna.UI.WinForms.GunaTextBox txt_phone;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaButton btn_browse;
        public Guna.UI.WinForms.GunaCirclePictureBox txt_pic;
        private System.Messaging.Message message1;
    }
}