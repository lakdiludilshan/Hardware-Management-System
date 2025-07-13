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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.text_search = new Guna.UI.WinForms.GunaTextBox();
            this.Search = new System.Windows.Forms.Label();
            this.btn_add = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(45, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sample Header";
            this.label1.UseCompatibleTextRendering = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.text_search);
            this.panel1.Controls.Add(this.Search);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 154);
            this.panel1.TabIndex = 5;
            // 
            // text_search
            // 
            this.text_search.BaseColor = System.Drawing.Color.White;
            this.text_search.BorderColor = System.Drawing.Color.Transparent;
            this.text_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_search.FocusedBaseColor = System.Drawing.Color.White;
            this.text_search.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.text_search.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.text_search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_search.Location = new System.Drawing.Point(379, 80);
            this.text_search.MultiLine = true;
            this.text_search.Name = "text_search";
            this.text_search.PasswordChar = '\0';
            this.text_search.Radius = 14;
            this.text_search.Size = new System.Drawing.Size(306, 34);
            this.text_search.TabIndex = 6;
            this.text_search.Text = "Search Here";
            this.text_search.Click += new System.EventHandler(this.text_search_Click);
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.AutoSize = true;
            this.Search.BackColor = System.Drawing.Color.Transparent;
            this.Search.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.Black;
            this.Search.Location = new System.Drawing.Point(384, 58);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(54, 19);
            this.Search.TabIndex = 5;
            this.Search.Text = "Search";
            // 
            // btn_add
            // 
            this.btn_add.AnimationHoverSpeed = 0.07F;
            this.btn_add.AnimationSpeed = 0.03F;
            this.btn_add.BaseColor = System.Drawing.Color.DodgerBlue;
            this.btn_add.BorderColor = System.Drawing.Color.Black;
            this.btn_add.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_add.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_add.CheckedForeColor = System.Drawing.Color.White;
            this.btn_add.CheckedImage = null;
            this.btn_add.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Image = global::Hardware_Management_System.Properties.Resources.add;
            this.btn_add.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_add.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_add.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_add.Location = new System.Drawing.Point(45, 80);
            this.btn_add.Name = "btn_add";
            this.btn_add.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_add.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_add.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_add.OnHoverImage = null;
            this.btn_add.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_add.OnPressedColor = System.Drawing.Color.Black;
            this.btn_add.Radius = 22;
            this.btn_add.Size = new System.Drawing.Size(145, 45);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Add New";
            this.btn_add.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_add.Click += new System.EventHandler(this.btn_add_click);
            // 
            // SampleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 506);
            this.Controls.Add(this.panel1);
            this.Name = "SampleView";
            this.Text = "SampleView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public Guna.UI.WinForms.GunaTextBox text_search;
        public Guna.UI.WinForms.GunaAdvenceButton btn_add;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label Search;
    }
}