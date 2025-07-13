namespace Hardware_Management_System
{
    partial class SampleAdd
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
            this.btn_save = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_close = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sample Header";
            this.label1.UseCompatibleTextRendering = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_save
            // 
            this.btn_save.AnimationHoverSpeed = 0.07F;
            this.btn_save.AnimationSpeed = 0.03F;
            this.btn_save.BaseColor = System.Drawing.Color.DodgerBlue;
            this.btn_save.BorderColor = System.Drawing.Color.Black;
            this.btn_save.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_save.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_save.CheckedForeColor = System.Drawing.Color.White;
            this.btn_save.CheckedImage = null;
            this.btn_save.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.Image = null;
            this.btn_save.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_save.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_save.Location = new System.Drawing.Point(32, 25);
            this.btn_save.Name = "btn_save";
            this.btn_save.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_save.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_save.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_save.OnHoverImage = null;
            this.btn_save.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_save.OnPressedColor = System.Drawing.Color.Black;
            this.btn_save.Radius = 22;
            this.btn_save.Size = new System.Drawing.Size(145, 45);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click_1);
            // 
            // btn_close
            // 
            this.btn_close.AnimationHoverSpeed = 0.07F;
            this.btn_close.AnimationSpeed = 0.03F;
            this.btn_close.BaseColor = System.Drawing.Color.Firebrick;
            this.btn_close.BorderColor = System.Drawing.Color.Black;
            this.btn_close.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_close.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_close.CheckedForeColor = System.Drawing.Color.White;
            this.btn_close.CheckedImage = null;
            this.btn_close.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Image = null;
            this.btn_close.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_close.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_close.Location = new System.Drawing.Point(206, 25);
            this.btn_close.Name = "btn_close";
            this.btn_close.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_close.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_close.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_close.OnHoverImage = null;
            this.btn_close.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_close.OnPressedColor = System.Drawing.Color.Black;
            this.btn_close.Radius = 22;
            this.btn_close.Size = new System.Drawing.Size(145, 45);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Close";
            this.btn_close.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click_1);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.DarkGray;
            this.gunaPanel1.Controls.Add(this.btn_save);
            this.gunaPanel1.Controls.Add(this.btn_close);
            this.gunaPanel1.Location = new System.Drawing.Point(0, 416);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(730, 90);
            this.gunaPanel1.TabIndex = 5;
            this.gunaPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel1_Paint);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.Black;
            this.gunaPanel2.Controls.Add(this.label1);
            this.gunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(730, 145);
            this.gunaPanel2.TabIndex = 6;
            this.gunaPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel2_Paint);
            // 
            // SampleAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 506);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.Name = "SampleAdd";
            this.Text = "SampleAdd";
            this.Load += new System.EventHandler(this.SampleAdd_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label label1;
        public Guna.UI.WinForms.GunaAdvenceButton btn_save;
        public Guna.UI.WinForms.GunaAdvenceButton btn_close;
        public Guna.UI.WinForms.GunaPanel gunaPanel1;
        public Guna.UI.WinForms.GunaPanel gunaPanel2;
    }
}