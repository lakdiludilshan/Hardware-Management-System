namespace Hardware_Management_System
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.log_signupbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.log_username = new System.Windows.Forms.TextBox();
            this.log_password = new System.Windows.Forms.TextBox();
            this.log_showpass = new System.Windows.Forms.CheckBox();
            this.log_btn = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(11)))), ((int)(((byte)(1)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.log_signupbtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(77, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(51, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Inventory Management";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // log_signupbtn
            // 
            this.log_signupbtn.BackColor = System.Drawing.Color.Maroon;
            this.log_signupbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.log_signupbtn.FlatAppearance.BorderSize = 0;
            this.log_signupbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.log_signupbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.log_signupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_signupbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_signupbtn.ForeColor = System.Drawing.Color.White;
            this.log_signupbtn.Location = new System.Drawing.Point(11, 387);
            this.log_signupbtn.Name = "log_signupbtn";
            this.log_signupbtn.Size = new System.Drawing.Size(295, 50);
            this.log_signupbtn.TabIndex = 9;
            this.log_signupbtn.Text = "SIGNUP";
            this.log_signupbtn.UseVisualStyleBackColor = false;
            this.log_signupbtn.Click += new System.EventHandler(this.log_signupbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(74, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Register your Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login Account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(364, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // log_username
            // 
            this.log_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.log_username.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_username.Location = new System.Drawing.Point(367, 168);
            this.log_username.Multiline = true;
            this.log_username.Name = "log_username";
            this.log_username.Size = new System.Drawing.Size(288, 29);
            this.log_username.TabIndex = 5;
            this.log_username.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // log_password
            // 
            this.log_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.log_password.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_password.Location = new System.Drawing.Point(367, 240);
            this.log_password.Multiline = true;
            this.log_password.Name = "log_password";
            this.log_password.PasswordChar = '*';
            this.log_password.Size = new System.Drawing.Size(288, 29);
            this.log_password.TabIndex = 6;
            this.log_password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // log_showpass
            // 
            this.log_showpass.AutoSize = true;
            this.log_showpass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_showpass.Location = new System.Drawing.Point(543, 285);
            this.log_showpass.Name = "log_showpass";
            this.log_showpass.Size = new System.Drawing.Size(112, 18);
            this.log_showpass.TabIndex = 7;
            this.log_showpass.Text = "Show Password";
            this.log_showpass.UseVisualStyleBackColor = true;
            this.log_showpass.CheckedChanged += new System.EventHandler(this.log_showpass_CheckedChanged);
            // 
            // log_btn
            // 
            this.log_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(11)))), ((int)(((byte)(1)))));
            this.log_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.log_btn.FlatAppearance.BorderSize = 0;
            this.log_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.log_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.log_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_btn.ForeColor = System.Drawing.Color.White;
            this.log_btn.Location = new System.Drawing.Point(367, 364);
            this.log_btn.Name = "log_btn";
            this.log_btn.Size = new System.Drawing.Size(117, 47);
            this.log_btn.TabIndex = 8;
            this.log_btn.Text = "LOGIN";
            this.log_btn.UseVisualStyleBackColor = false;
            this.log_btn.Click += new System.EventHandler(this.log_btn_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatAppearance.BorderSize = 5;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btn_exit.Location = new System.Drawing.Point(665, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(23, 23);
            this.btn_exit.TabIndex = 11;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.log_btn);
            this.Controls.Add(this.log_showpass);
            this.Controls.Add(this.log_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.log_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox log_username;
        private System.Windows.Forms.TextBox log_password;
        private System.Windows.Forms.CheckBox log_showpass;
        private System.Windows.Forms.Button log_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button log_signupbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_exit;
    }
}

