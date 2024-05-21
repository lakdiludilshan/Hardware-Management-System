namespace Hardware_Management_System
{
    partial class SampleView
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.search_text = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.guna2Panel1.Controls.Add(this.search_text);
            this.guna2Panel1.Controls.Add(this.btn_add);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1020, 170);
            this.guna2Panel1.TabIndex = 0;
            // 
            // search_text
            // 
            this.search_text.AutoRoundedCorners = true;
            this.search_text.BorderRadius = 29;
            this.search_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search_text.DefaultText = "";
            this.search_text.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search_text.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search_text.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_text.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_text.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_text.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.search_text.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_text.Location = new System.Drawing.Point(577, 85);
            this.search_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.search_text.Name = "search_text";
            this.search_text.PasswordChar = '\0';
            this.search_text.PlaceholderText = "Search Here";
            this.search_text.SelectedText = "";
            this.search_text.Size = new System.Drawing.Size(380, 60);
            this.search_text.TabIndex = 3;
            this.search_text.TextOffset = new System.Drawing.Point(10, 0);
            this.search_text.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(606, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sample Header";
            // 
            // btn_add
            // 
            this.btn_add.Animated = true;
            this.btn_add.AutoRoundedCorners = true;
            this.btn_add.BorderRadius = 29;
            this.btn_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add.FillColor = System.Drawing.Color.Firebrick;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Image = global::Hardware_Management_System.Properties.Resources.add;
            this.btn_add.ImageSize = new System.Drawing.Size(22, 22);
            this.btn_add.Location = new System.Drawing.Point(54, 85);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(205, 60);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add New";
            this.btn_add.Click += new System.EventHandler(this.btn_add_click);
            // 
            // SampleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 600);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SampleView";
            this.Text = "SampleView";
            this.Load += new System.EventHandler(this.SampleView_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2TextBox search_text;
        public Guna.UI2.WinForms.Guna2Button btn_add;
    }
}