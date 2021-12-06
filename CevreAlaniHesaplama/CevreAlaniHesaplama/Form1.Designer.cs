
namespace CevreAlaniHesaplama
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbSecenekler = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbAlan = new System.Windows.Forms.RadioButton();
            this.rbCevre = new System.Windows.Forms.RadioButton();
            this.cbTur = new System.Windows.Forms.ComboBox();
            this.gbDegerler = new System.Windows.Forms.GroupBox();
            this.lblCap = new System.Windows.Forms.Label();
            this.lblBoy = new System.Windows.Forms.Label();
            this.lblEn = new System.Windows.Forms.Label();
            this.tbCap = new System.Windows.Forms.TextBox();
            this.tbBoy = new System.Windows.Forms.TextBox();
            this.tbEn = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.gbSecenekler.SuspendLayout();
            this.gbDegerler.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSecenekler
            // 
            this.gbSecenekler.Controls.Add(this.label5);
            this.gbSecenekler.Controls.Add(this.rbAlan);
            this.gbSecenekler.Controls.Add(this.rbCevre);
            this.gbSecenekler.Controls.Add(this.cbTur);
            this.gbSecenekler.Location = new System.Drawing.Point(12, 12);
            this.gbSecenekler.Name = "gbSecenekler";
            this.gbSecenekler.Size = new System.Drawing.Size(222, 114);
            this.gbSecenekler.TabIndex = 0;
            this.gbSecenekler.TabStop = false;
            this.gbSecenekler.Text = "Secenekler";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tür:";
            // 
            // rbAlan
            // 
            this.rbAlan.AutoSize = true;
            this.rbAlan.Location = new System.Drawing.Point(144, 76);
            this.rbAlan.Name = "rbAlan";
            this.rbAlan.Size = new System.Drawing.Size(46, 17);
            this.rbAlan.TabIndex = 1;
            this.rbAlan.Text = "Alan";
            this.rbAlan.UseVisualStyleBackColor = true;
            this.rbAlan.CheckedChanged += new System.EventHandler(this.rbAlan_CheckedChanged);
            // 
            // rbCevre
            // 
            this.rbCevre.AutoSize = true;
            this.rbCevre.Checked = true;
            this.rbCevre.Location = new System.Drawing.Point(23, 76);
            this.rbCevre.Name = "rbCevre";
            this.rbCevre.Size = new System.Drawing.Size(53, 17);
            this.rbCevre.TabIndex = 1;
            this.rbCevre.TabStop = true;
            this.rbCevre.Text = "Cevre";
            this.rbCevre.UseVisualStyleBackColor = true;
            this.rbCevre.CheckedChanged += new System.EventHandler(this.rbCevre_CheckedChanged);
            // 
            // cbTur
            // 
            this.cbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTur.FormattingEnabled = true;
            this.cbTur.Items.AddRange(new object[] {
            "Üçgen",
            "Kare",
            "Dikdörtgen",
            "Daire"});
            this.cbTur.Location = new System.Drawing.Point(54, 34);
            this.cbTur.Name = "cbTur";
            this.cbTur.Size = new System.Drawing.Size(143, 21);
            this.cbTur.TabIndex = 0;
            this.cbTur.SelectedIndexChanged += new System.EventHandler(this.cbTur_SelectedIndexChanged);
            // 
            // gbDegerler
            // 
            this.gbDegerler.Controls.Add(this.lblCap);
            this.gbDegerler.Controls.Add(this.lblBoy);
            this.gbDegerler.Controls.Add(this.lblEn);
            this.gbDegerler.Controls.Add(this.tbCap);
            this.gbDegerler.Controls.Add(this.tbBoy);
            this.gbDegerler.Controls.Add(this.tbEn);
            this.gbDegerler.Location = new System.Drawing.Point(12, 147);
            this.gbDegerler.Name = "gbDegerler";
            this.gbDegerler.Size = new System.Drawing.Size(222, 135);
            this.gbDegerler.TabIndex = 1;
            this.gbDegerler.TabStop = false;
            this.gbDegerler.Text = "Değerler";
            // 
            // lblCap
            // 
            this.lblCap.AutoSize = true;
            this.lblCap.Location = new System.Drawing.Point(19, 92);
            this.lblCap.Name = "lblCap";
            this.lblCap.Size = new System.Drawing.Size(26, 13);
            this.lblCap.TabIndex = 1;
            this.lblCap.Text = "Çap";
            // 
            // lblBoy
            // 
            this.lblBoy.AutoSize = true;
            this.lblBoy.Location = new System.Drawing.Point(20, 66);
            this.lblBoy.Name = "lblBoy";
            this.lblBoy.Size = new System.Drawing.Size(25, 13);
            this.lblBoy.TabIndex = 1;
            this.lblBoy.Text = "Boy";
            // 
            // lblEn
            // 
            this.lblEn.AutoSize = true;
            this.lblEn.Location = new System.Drawing.Point(25, 40);
            this.lblEn.Name = "lblEn";
            this.lblEn.Size = new System.Drawing.Size(20, 13);
            this.lblEn.TabIndex = 1;
            this.lblEn.Text = "En";
            // 
            // tbCap
            // 
            this.tbCap.Location = new System.Drawing.Point(84, 88);
            this.tbCap.Name = "tbCap";
            this.tbCap.Size = new System.Drawing.Size(113, 20);
            this.tbCap.TabIndex = 0;
            // 
            // tbBoy
            // 
            this.tbBoy.Location = new System.Drawing.Point(84, 62);
            this.tbBoy.Name = "tbBoy";
            this.tbBoy.Size = new System.Drawing.Size(113, 20);
            this.tbBoy.TabIndex = 0;
            // 
            // tbEn
            // 
            this.tbEn.Location = new System.Drawing.Point(84, 36);
            this.tbEn.Name = "tbEn";
            this.tbEn.Size = new System.Drawing.Size(113, 20);
            this.tbEn.TabIndex = 0;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(13, 298);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(221, 36);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(6, 360);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(30, 31);
            this.lblSonuc.TabIndex = 3;
            this.lblSonuc.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 450);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.gbDegerler);
            this.Controls.Add(this.gbSecenekler);
            this.Name = "Form1";
            this.Text = "Alan / Çevre Hesaplama";
            this.gbSecenekler.ResumeLayout(false);
            this.gbSecenekler.PerformLayout();
            this.gbDegerler.ResumeLayout(false);
            this.gbDegerler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSecenekler;
        private System.Windows.Forms.RadioButton rbAlan;
        private System.Windows.Forms.RadioButton rbCevre;
        private System.Windows.Forms.ComboBox cbTur;
        private System.Windows.Forms.GroupBox gbDegerler;
        private System.Windows.Forms.Label lblCap;
        private System.Windows.Forms.Label lblBoy;
        private System.Windows.Forms.Label lblEn;
        private System.Windows.Forms.TextBox tbCap;
        private System.Windows.Forms.TextBox tbBoy;
        private System.Windows.Forms.TextBox tbEn;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label label5;
    }
}

