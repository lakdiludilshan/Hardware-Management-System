namespace Hardware_Management_System
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_max = new System.Windows.Forms.Button();
            this.gunaButton6 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton5 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.btn_user = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaButton7 = new Guna.UI.WinForms.GunaButton();
            this.CenterPanel = new Guna.UI.WinForms.GunaPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(46, 19);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Radius = 50;
            this.gunaPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            this.gunaPictureBox1.UseTransfarantBackground = true;
            this.gunaPictureBox1.Click += new System.EventHandler(this.gunaPictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sachintha Hardware";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panel1.Controls.Add(this.btn_min);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_max);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 24);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            // 
            // btn_min
            // 
            this.btn_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btn_min.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_min.BackgroundImage")));
            this.btn_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_min.FlatAppearance.BorderSize = 5;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btn_min.Location = new System.Drawing.Point(839, 1);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(23, 23);
            this.btn_min.TabIndex = 9;
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click_1);
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
            this.btn_exit.Location = new System.Drawing.Point(897, 1);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(23, 23);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_max
            // 
            this.btn_max.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btn_max.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_max.BackgroundImage")));
            this.btn_max.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_max.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_max.FlatAppearance.BorderSize = 5;
            this.btn_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_max.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btn_max.Location = new System.Drawing.Point(868, 1);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(23, 23);
            this.btn_max.TabIndex = 8;
            this.btn_max.UseVisualStyleBackColor = false;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click_1);
            // 
            // gunaButton6
            // 
            this.gunaButton6.AnimationHoverSpeed = 0.07F;
            this.gunaButton6.AnimationSpeed = 0.03F;
            this.gunaButton6.BaseColor = System.Drawing.Color.Firebrick;
            this.gunaButton6.BorderColor = System.Drawing.Color.Black;
            this.gunaButton6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton6.ForeColor = System.Drawing.Color.Black;
            this.gunaButton6.Image = global::Hardware_Management_System.Properties.Resources.pngwing_com__5_;
            this.gunaButton6.ImageOffsetX = 9;
            this.gunaButton6.ImageSize = new System.Drawing.Size(39, 39);
            this.gunaButton6.Location = new System.Drawing.Point(24, 418);
            this.gunaButton6.Name = "gunaButton6";
            this.gunaButton6.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton6.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton6.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton6.OnHoverImage = null;
            this.gunaButton6.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton6.Radius = 18;
            this.gunaButton6.Size = new System.Drawing.Size(145, 38);
            this.gunaButton6.TabIndex = 12;
            this.gunaButton6.Text = "Sales";
            this.gunaButton6.TextOffsetX = -5;
            // 
            // gunaButton5
            // 
            this.gunaButton5.AnimationHoverSpeed = 0.07F;
            this.gunaButton5.AnimationSpeed = 0.03F;
            this.gunaButton5.BaseColor = System.Drawing.Color.Firebrick;
            this.gunaButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaButton5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton5.ForeColor = System.Drawing.Color.Black;
            this.gunaButton5.Image = global::Hardware_Management_System.Properties.Resources.pngwing_com__4_;
            this.gunaButton5.ImageOffsetX = 15;
            this.gunaButton5.ImageSize = new System.Drawing.Size(24, 24);
            this.gunaButton5.Location = new System.Drawing.Point(24, 374);
            this.gunaButton5.Name = "gunaButton5";
            this.gunaButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton5.OnHoverImage = null;
            this.gunaButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton5.Radius = 18;
            this.gunaButton5.Size = new System.Drawing.Size(145, 38);
            this.gunaButton5.TabIndex = 11;
            this.gunaButton5.Text = "Customers";
            this.gunaButton5.TextOffsetX = 3;
            // 
            // gunaButton4
            // 
            this.gunaButton4.AnimationHoverSpeed = 0.07F;
            this.gunaButton4.AnimationSpeed = 0.03F;
            this.gunaButton4.BaseColor = System.Drawing.Color.Firebrick;
            this.gunaButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaButton4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton4.ForeColor = System.Drawing.Color.Black;
            this.gunaButton4.Image = global::Hardware_Management_System.Properties.Resources.pngwing_com__2_;
            this.gunaButton4.ImageOffsetX = 9;
            this.gunaButton4.ImageSize = new System.Drawing.Size(32, 32);
            this.gunaButton4.Location = new System.Drawing.Point(24, 330);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton4.Radius = 18;
            this.gunaButton4.Size = new System.Drawing.Size(145, 38);
            this.gunaButton4.TabIndex = 10;
            this.gunaButton4.Text = "Purchases";
            // 
            // gunaButton3
            // 
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BaseColor = System.Drawing.Color.Firebrick;
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton3.ForeColor = System.Drawing.Color.Black;
            this.gunaButton3.Image = global::Hardware_Management_System.Properties.Resources.pngwing_com__7_;
            this.gunaButton3.ImageOffsetX = 11;
            this.gunaButton3.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton3.Location = new System.Drawing.Point(24, 242);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Radius = 18;
            this.gunaButton3.Size = new System.Drawing.Size(145, 38);
            this.gunaButton3.TabIndex = 9;
            this.gunaButton3.Text = "Products";
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BaseColor = System.Drawing.Color.Firebrick;
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.Black;
            this.gunaButton2.Image = global::Hardware_Management_System.Properties.Resources.pngwing_com__1_;
            this.gunaButton2.ImageOffsetX = 11;
            this.gunaButton2.ImageSize = new System.Drawing.Size(26, 26);
            this.gunaButton2.Location = new System.Drawing.Point(24, 198);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 18;
            this.gunaButton2.Size = new System.Drawing.Size(145, 38);
            this.gunaButton2.TabIndex = 4;
            this.gunaButton2.Text = "Category";
            this.gunaButton2.TextOffsetX = 5;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.Firebrick;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaButton1.Image = global::Hardware_Management_System.Properties.Resources.pngwing_com;
            this.gunaButton1.ImageOffsetX = 6;
            this.gunaButton1.ImageSize = new System.Drawing.Size(35, 35);
            this.gunaButton1.Location = new System.Drawing.Point(24, 154);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 18;
            this.gunaButton1.Size = new System.Drawing.Size(145, 38);
            this.gunaButton1.TabIndex = 2;
            this.gunaButton1.Text = "Home";
            // 
            // btn_user
            // 
            this.btn_user.AnimationHoverSpeed = 0.07F;
            this.btn_user.AnimationSpeed = 0.03F;
            this.btn_user.BaseColor = System.Drawing.Color.Firebrick;
            this.btn_user.BorderColor = System.Drawing.Color.Black;
            this.btn_user.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_user.ForeColor = System.Drawing.Color.Black;
            this.btn_user.Image = global::Hardware_Management_System.Properties.Resources.pngwing_com__6_;
            this.btn_user.ImageOffsetX = 17;
            this.btn_user.ImageSize = new System.Drawing.Size(24, 24);
            this.btn_user.Location = new System.Drawing.Point(24, 462);
            this.btn_user.Name = "btn_user";
            this.btn_user.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_user.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_user.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_user.OnHoverImage = null;
            this.btn_user.OnPressedColor = System.Drawing.Color.Black;
            this.btn_user.Radius = 18;
            this.btn_user.Size = new System.Drawing.Size(145, 38);
            this.btn_user.TabIndex = 13;
            this.btn_user.Text = "User";
            this.btn_user.TextOffsetX = 3;
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click_1);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.gunaPanel2.Controls.Add(this.btn_user);
            this.gunaPanel2.Controls.Add(this.gunaButton7);
            this.gunaPanel2.Controls.Add(this.gunaButton6);
            this.gunaPanel2.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel2.Controls.Add(this.gunaButton4);
            this.gunaPanel2.Controls.Add(this.gunaButton2);
            this.gunaPanel2.Controls.Add(this.gunaButton3);
            this.gunaPanel2.Controls.Add(this.gunaButton1);
            this.gunaPanel2.Controls.Add(this.gunaButton5);
            this.gunaPanel2.Controls.Add(this.label1);
            this.gunaPanel2.Location = new System.Drawing.Point(0, 24);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(190, 506);
            this.gunaPanel2.TabIndex = 14;
            // 
            // gunaButton7
            // 
            this.gunaButton7.AnimationHoverSpeed = 0.07F;
            this.gunaButton7.AnimationSpeed = 0.03F;
            this.gunaButton7.BaseColor = System.Drawing.Color.Firebrick;
            this.gunaButton7.BorderColor = System.Drawing.Color.Black;
            this.gunaButton7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton7.ForeColor = System.Drawing.Color.Black;
            this.gunaButton7.Image = global::Hardware_Management_System.Properties.Resources.pngwing_com__2_;
            this.gunaButton7.ImageOffsetX = 9;
            this.gunaButton7.ImageSize = new System.Drawing.Size(32, 32);
            this.gunaButton7.Location = new System.Drawing.Point(24, 286);
            this.gunaButton7.Name = "gunaButton7";
            this.gunaButton7.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton7.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton7.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton7.OnHoverImage = null;
            this.gunaButton7.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton7.Radius = 18;
            this.gunaButton7.Size = new System.Drawing.Size(145, 38);
            this.gunaButton7.TabIndex = 14;
            this.gunaButton7.Text = "Purchases";
            // 
            // CenterPanel
            // 
            this.CenterPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CenterPanel.ForeColor = System.Drawing.Color.Red;
            this.CenterPanel.Location = new System.Drawing.Point(190, 24);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(730, 506);
            this.CenterPanel.TabIndex = 6;
            this.CenterPanel.TabStop = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(920, 530);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton gunaButton4;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaButton gunaButton6;
        private Guna.UI.WinForms.GunaButton gunaButton5;
        private Guna.UI.WinForms.GunaButton btn_user;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private System.Windows.Forms.Button btn_max;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_min;
        private Guna.UI.WinForms.GunaPanel CenterPanel;
        private Guna.UI.WinForms.GunaButton gunaButton7;
    }
}