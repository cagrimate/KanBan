
namespace KanBan
{
    partial class FormNot
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
            this.txtNotGiris = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKalanHarf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNotGiris
            // 
            this.txtNotGiris.Location = new System.Drawing.Point(0, -1);
            this.txtNotGiris.Multiline = true;
            this.txtNotGiris.Name = "txtNotGiris";
            this.txtNotGiris.Size = new System.Drawing.Size(230, 98);
            this.txtNotGiris.TabIndex = 0;
            this.txtNotGiris.TextChanged += new System.EventHandler(this.txtNotGiris_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kalan Harf Sayısı";
            // 
            // lblKalanHarf
            // 
            this.lblKalanHarf.AutoSize = true;
            this.lblKalanHarf.Location = new System.Drawing.Point(116, 100);
            this.lblKalanHarf.Name = "lblKalanHarf";
            this.lblKalanHarf.Size = new System.Drawing.Size(0, 13);
            this.lblKalanHarf.TabIndex = 3;
            // 
            // FormNot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 119);
            this.Controls.Add(this.lblKalanHarf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNotGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormNot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormNot";
            this.Load += new System.EventHandler(this.FormNot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNotGiris;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKalanHarf;
    }
}