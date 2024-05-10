namespace Hardware_Management_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.log_username = new System.Windows.Forms.TextBox();
            this.log_password = new System.Windows.Forms.TextBox();
            this.log_showpass = new System.Windows.Forms.CheckBox();
            this.log_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.log_signupbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(398, 624);
            this.panel1.TabIndex = 0;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(893, 19);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(22, 24);
            this.exit.TabIndex = 1;
            this.exit.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(434, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login Account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(437, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(437, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // log_username
            // 
            this.log_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.log_username.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_username.Location = new System.Drawing.Point(441, 225);
            this.log_username.Multiline = true;
            this.log_username.Name = "log_username";
            this.log_username.Size = new System.Drawing.Size(448, 50);
            this.log_username.TabIndex = 5;
            this.log_username.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // log_password
            // 
            this.log_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.log_password.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_password.Location = new System.Drawing.Point(441, 340);
            this.log_password.Multiline = true;
            this.log_password.Name = "log_password";
            this.log_password.Size = new System.Drawing.Size(448, 50);
            this.log_password.TabIndex = 6;
            this.log_password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // log_showpass
            // 
            this.log_showpass.AutoSize = true;
            this.log_showpass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_showpass.Location = new System.Drawing.Point(730, 410);
            this.log_showpass.Name = "log_showpass";
            this.log_showpass.Size = new System.Drawing.Size(159, 26);
            this.log_showpass.TabIndex = 7;
            this.log_showpass.Text = "Show Password";
            this.log_showpass.UseVisualStyleBackColor = true;
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
            this.log_btn.Location = new System.Drawing.Point(441, 469);
            this.log_btn.Name = "log_btn";
            this.log_btn.Size = new System.Drawing.Size(165, 67);
            this.log_btn.TabIndex = 8;
            this.log_btn.Text = "LOGIN";
            this.log_btn.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(92, 511);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Register your Account";
            // 
            // log_signupbtn
            // 
            this.log_signupbtn.BackColor = System.Drawing.Color.Maroon;
            this.log_signupbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.log_signupbtn.FlatAppearance.BorderSize = 0;
            this.log_signupbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.log_signupbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.log_signupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_signupbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_signupbtn.ForeColor = System.Drawing.Color.White;
            this.log_signupbtn.Location = new System.Drawing.Point(42, 549);
            this.log_signupbtn.Name = "log_signupbtn";
            this.log_signupbtn.Size = new System.Drawing.Size(306, 50);
            this.log_signupbtn.TabIndex = 9;
            this.log_signupbtn.Text = "SIGNUP";
            this.log_signupbtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(96, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(43, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(305, 34);
            this.label6.TabIndex = 10;
            this.label6.Text = "Inventory Management";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(927, 624);
            this.Controls.Add(this.log_btn);
            this.Controls.Add(this.log_showpass);
            this.Controls.Add(this.log_password);
            this.Controls.Add(this.log_username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exit;
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
    }
}

