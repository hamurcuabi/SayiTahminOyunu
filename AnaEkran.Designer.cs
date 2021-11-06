
namespace SayiTahminOyunu
{
    partial class AnaEkran
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
            this.btnKolaySeviye = new System.Windows.Forms.Button();
            this.btnOrtaSeviye = new System.Windows.Forms.Button();
            this.btnZorSeviye = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKolaySeviye
            // 
            this.btnKolaySeviye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnKolaySeviye.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKolaySeviye.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnKolaySeviye.Location = new System.Drawing.Point(123, 44);
            this.btnKolaySeviye.Name = "btnKolaySeviye";
            this.btnKolaySeviye.Size = new System.Drawing.Size(1549, 112);
            this.btnKolaySeviye.TabIndex = 0;
            this.btnKolaySeviye.Text = "KOLAY";
            this.btnKolaySeviye.UseVisualStyleBackColor = false;
            this.btnKolaySeviye.Click += new System.EventHandler(this.btnKolaySeviye_Click);
            // 
            // btnOrtaSeviye
            // 
            this.btnOrtaSeviye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOrtaSeviye.Font = new System.Drawing.Font("Showcard Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnOrtaSeviye.Location = new System.Drawing.Point(123, 209);
            this.btnOrtaSeviye.Name = "btnOrtaSeviye";
            this.btnOrtaSeviye.Size = new System.Drawing.Size(1549, 121);
            this.btnOrtaSeviye.TabIndex = 1;
            this.btnOrtaSeviye.Text = "ORTA";
            this.btnOrtaSeviye.UseVisualStyleBackColor = false;
            this.btnOrtaSeviye.Click += new System.EventHandler(this.btnOrtaSeviye_Click);
            // 
            // btnZorSeviye
            // 
            this.btnZorSeviye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnZorSeviye.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnZorSeviye.FlatAppearance.BorderSize = 2;
            this.btnZorSeviye.Font = new System.Drawing.Font("Showcard Gothic", 14.1F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnZorSeviye.Location = new System.Drawing.Point(123, 363);
            this.btnZorSeviye.Name = "btnZorSeviye";
            this.btnZorSeviye.Size = new System.Drawing.Size(1549, 110);
            this.btnZorSeviye.TabIndex = 2;
            this.btnZorSeviye.Text = "ZOR";
            this.btnZorSeviye.UseVisualStyleBackColor = false;
            this.btnZorSeviye.Click += new System.EventHandler(this.btnZorSeviye_Click);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1721, 526);
            this.Controls.Add(this.btnZorSeviye);
            this.Controls.Add(this.btnOrtaSeviye);
            this.Controls.Add(this.btnKolaySeviye);
            this.Name = "AnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sayı Oyunu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKolaySeviye;
        private System.Windows.Forms.Button btnOrtaSeviye;
        private System.Windows.Forms.Button btnZorSeviye;
    }
}