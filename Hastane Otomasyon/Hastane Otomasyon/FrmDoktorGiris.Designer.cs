
namespace Hastane_Otomasyon
{
    partial class FrmDoktorGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorGiris));
            this.BtnGirisYap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.BackColor = System.Drawing.Color.IndianRed;
            this.BtnGirisYap.Location = new System.Drawing.Point(161, 160);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(100, 26);
            this.BtnGirisYap.TabIndex = 13;
            this.BtnGirisYap.Text = "Giriş Yap";
            this.BtnGirisYap.UseVisualStyleBackColor = false;
            this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(57, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(111, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Şifre:";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(161, 119);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(100, 20);
            this.TxtSifre.TabIndex = 9;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(161, 80);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(100, 20);
            this.MskTC.TabIndex = 1;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 53);
            this.label1.TabIndex = 7;
            this.label1.Text = "Doktor Giriş Paneli";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(34, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 26);
            this.button1.TabIndex = 14;
            this.button1.Text = "Ana Menüye Dön";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmDoktorGiris
            // 
            this.AcceptButton = this.BtnGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(407, 202);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmDoktorGiris";
            this.Text = "Doktor Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGirisYap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}