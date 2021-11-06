
namespace SayiTahminOyunu
{
    partial class OyunEkrani
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
            this.lblSeviye = new System.Windows.Forms.Label();
            this.lblKalanHak = new System.Windows.Forms.Label();
            this.txtTahminSayisi = new System.Windows.Forms.TextBox();
            this.btnBastanBasla = new System.Windows.Forms.Button();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSeviye
            // 
            this.lblSeviye.AutoSize = true;
            this.lblSeviye.Font = new System.Drawing.Font("Segoe UI Black", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeviye.Location = new System.Drawing.Point(50, 52);
            this.lblSeviye.Name = "lblSeviye";
            this.lblSeviye.Size = new System.Drawing.Size(359, 71);
            this.lblSeviye.TabIndex = 0;
            this.lblSeviye.Text = "Kolay Seviye";
            // 
            // lblKalanHak
            // 
            this.lblKalanHak.AutoSize = true;
            this.lblKalanHak.Font = new System.Drawing.Font("Showcard Gothic", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKalanHak.Location = new System.Drawing.Point(675, 52);
            this.lblKalanHak.Name = "lblKalanHak";
            this.lblKalanHak.Size = new System.Drawing.Size(49, 59);
            this.lblKalanHak.TabIndex = 1;
            this.lblKalanHak.Text = "5";
            // 
            // txtTahminSayisi
            // 
            this.txtTahminSayisi.Location = new System.Drawing.Point(70, 194);
            this.txtTahminSayisi.MaxLength = 3;
            this.txtTahminSayisi.Name = "txtTahminSayisi";
            this.txtTahminSayisi.PlaceholderText = "Tahmini sayınızı giriniz";
            this.txtTahminSayisi.Size = new System.Drawing.Size(654, 47);
            this.txtTahminSayisi.TabIndex = 2;
            // 
            // btnBastanBasla
            // 
            this.btnBastanBasla.Location = new System.Drawing.Point(560, 449);
            this.btnBastanBasla.Name = "btnBastanBasla";
            this.btnBastanBasla.Size = new System.Drawing.Size(188, 123);
            this.btnBastanBasla.TabIndex = 3;
            this.btnBastanBasla.Text = "Yeniden Oyna";
            this.btnBastanBasla.UseVisualStyleBackColor = true;
            this.btnBastanBasla.Click += new System.EventHandler(this.btnBastanBasla_Click);
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(70, 284);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(654, 58);
            this.btnOnayla.TabIndex = 4;
            this.btnOnayla.Text = "Tahmin Et";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // OyunEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 623);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.btnBastanBasla);
            this.Controls.Add(this.txtTahminSayisi);
            this.Controls.Add(this.lblKalanHak);
            this.Controls.Add(this.lblSeviye);
            this.Name = "OyunEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OyunEkrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeviye;
        private System.Windows.Forms.Label lblKalanHak;
        private System.Windows.Forms.TextBox txtTahminSayisi;
        private System.Windows.Forms.Button btnBastanBasla;
        private System.Windows.Forms.Button btnOnayla;
    }
}