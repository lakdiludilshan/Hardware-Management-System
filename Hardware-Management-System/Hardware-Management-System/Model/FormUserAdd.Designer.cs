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
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.ButtonType = Guna.UI.WinForms.AdvenceButtonType.DefaultButton;
            this.btn_save.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_save.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            // 
            // btn_close
            // 
            this.btn_close.ButtonType = Guna.UI.WinForms.AdvenceButtonType.DefaultButton;
            this.btn_close.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_close.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            // 
            // FormUserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 506);
            this.Name = "FormUserAdd";
            this.Text = "FormUserAdd";
            this.Load += new System.EventHandler(this.FormUserAdd_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}