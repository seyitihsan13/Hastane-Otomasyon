
namespace Hastane_Otomasyon
{
    partial class FrmBilgiDüzenleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilgiDüzenleme));
            this.BtnBilgiGuncelle = new System.Windows.Forms.Button();
            this.CmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // BtnBilgiGuncelle
            // 
            this.BtnBilgiGuncelle.BackColor = System.Drawing.Color.Pink;
            this.BtnBilgiGuncelle.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBilgiGuncelle.Location = new System.Drawing.Point(117, 317);
            this.BtnBilgiGuncelle.Name = "BtnBilgiGuncelle";
            this.BtnBilgiGuncelle.Size = new System.Drawing.Size(121, 38);
            this.BtnBilgiGuncelle.TabIndex = 31;
            this.BtnBilgiGuncelle.Text = "Güncelle";
            this.BtnBilgiGuncelle.UseVisualStyleBackColor = false;
            this.BtnBilgiGuncelle.Click += new System.EventHandler(this.BtnBilgiGuncelle_Click);
            // 
            // CmbCinsiyet
            // 
            this.CmbCinsiyet.FormattingEnabled = true;
            this.CmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.CmbCinsiyet.Location = new System.Drawing.Point(117, 220);
            this.CmbCinsiyet.Name = "CmbCinsiyet";
            this.CmbCinsiyet.Size = new System.Drawing.Size(121, 31);
            this.CmbCinsiyet.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(49, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 29;
            this.label6.Text = "Telefon:";
            // 
            // MskTelefon
            // 
            this.MskTelefon.Location = new System.Drawing.Point(117, 173);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(121, 31);
            this.MskTelefon.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(67, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "Şifre:";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(117, 270);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(121, 31);
            this.TxtSifre.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(58, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Soyad:";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(117, 77);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(121, 31);
            this.TxtSoyad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(81, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ad:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(117, 24);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(121, 31);
            this.TxtAd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(46, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cinsiyet:";
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(117, 123);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(121, 31);
            this.MskTC.TabIndex = 3;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // FrmBilgiDüzenleme
            // 
            this.AcceptButton = this.BtnBilgiGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(302, 372);
            this.Controls.Add(this.BtnBilgiGuncelle);
            this.Controls.Add(this.CmbCinsiyet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MskTelefon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MskTC);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmBilgiDüzenleme";
            this.Text = "Bilgi Düzenleme";
            this.Load += new System.EventHandler(this.FrmBilgiDüzenleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBilgiGuncelle;
        private System.Windows.Forms.ComboBox CmbCinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MskTC;
    }
}