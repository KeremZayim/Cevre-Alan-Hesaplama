using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CevreAlaniHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            tbEn.Enabled = false;
            tbBoy.Enabled = false;
            tbCap.Enabled = false;
        }

        public void yazidegistir()
        {
            if (rbAlan.Checked)
            {
                if (cbTur.Text == "Üçgen")
                {
                    tbEn.Enabled = true;
                    tbBoy.Enabled = true;
                    tbCap.Enabled = false;

                    tbBoy.Text = "";
                    tbEn.Text = "";
                    tbCap.Text = "";

                    lblEn.Text = "Yükseklik";
                    lblBoy.Text = "Taban";
                    lblCap.Text = "";
                }
                else if (cbTur.Text == "Daire")

                {
                    tbCap.Enabled = true;
                    tbEn.Enabled = false;
                    tbBoy.Enabled = false;

                    tbBoy.Text = "";
                    tbEn.Text = "";
                    tbCap.Text = "";

                    lblEn.Text = "";
                    lblBoy.Text = "";
                    lblCap.Text = "Yarıçap";
                }

                else if (cbTur.Text == "Kare")
                {
                    tbEn.Enabled = true;
                    tbBoy.Enabled = false;
                    tbCap.Enabled = false;

                    tbBoy.Text = "";
                    tbEn.Text = "";
                    tbCap.Text = "";

                    lblEn.Text = "Kenar";
                    lblBoy.Text = "";
                    lblCap.Text = "";
                }

                else if (cbTur.Text == "Dikdörtgen")
                {
                    tbEn.Enabled = true;
                    tbBoy.Enabled = true;
                    tbCap.Enabled = false;

                    tbBoy.Text = "";
                    tbEn.Text = "";
                    tbCap.Text = "";

                    lblEn.Text = "En";
                    lblBoy.Text = "Boy";
                    lblCap.Text = "";
                }
            }
            else
            {
                if (cbTur.Text == "Üçgen")
                {
                    tbEn.Enabled = true;
                    tbBoy.Enabled = true;
                    tbCap.Enabled = true;

                    lblEn.Text = "1.Kenar";
                    lblBoy.Text = "2.Kenar";
                    lblCap.Text = "3.Kenar";
                }
                else if (cbTur.Text == "Daire")
                {
                    tbCap.Enabled = true;
                    tbEn.Enabled = false;
                    tbBoy.Enabled = false;

                    lblEn.Text = "";
                    lblBoy.Text = "";
                    lblCap.Text = "Yarıçap";
                }
                else if (cbTur.Text == "Kare")
                {
                    tbEn.Enabled = true;
                    tbBoy.Enabled = false;
                    tbCap.Enabled = false;

                    lblEn.Text = "Kenar";
                    lblBoy.Text = "";
                    lblCap.Text = "";
                }
                else if (cbTur.Text == "Dikdörtgen")
                {
                    tbEn.Enabled = true;
                    tbBoy.Enabled = true;
                    tbCap.Enabled = false;

                    lblEn.Text = "En";
                    lblBoy.Text = "Boy";
                    lblCap.Text = "";
                }
            }
        }
        private void cbTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            yazidegistir();
        }
        private void rbCevre_CheckedChanged(object sender, EventArgs e)
        {
            yazidegistir();
        }

        private void rbAlan_CheckedChanged(object sender, EventArgs e)
        {
            yazidegistir();
        }
        double alanHesapla(string tur, double en, double boy, double cap)
        {
            double alan = 0;

            if (cbTur.Text == "Üçgen")
            {
                alan = (en * boy / 2);
            }
            else if (cbTur.Text == "Kare")
            {
                alan = (en * en);
            }
            else if (cbTur.Text == "Dikdörtgen")
            {
                alan = ((en * boy));
            }
            else if (cbTur.Text == "Daire")
            {
                alan = (Math.PI * cap * cap);
            }
            return alan;
        }
        double cevreHesapla(string tur, double en, double boy, double cap)
        {
            double cevre = 0;

            if (cbTur.Text == "Üçgen")
            {
                cevre = (en + boy + cap);
            }
            else if (cbTur.Text == "Kare")
            {
                cevre = (en * 4);
            }
            else if (cbTur.Text == "Dikdörtgen")
            {
                cevre = ((en + boy) * 2);
            }
            else if (cbTur.Text == "Daire")
            {
                cevre = (2 * Math.PI * cap);
            }
            return cevre;
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbCevre.Checked)
                {
                    if (cbTur.Text == "Daire")
                    {
                        if (tbCap.Text == "")
                        {
                            MessageBox.Show("Lütfen Bir Değer Giriniz!");
                        }
                        else
                        {
                            double en = 1;
                            double boy = 1;
                            double cap = Convert.ToDouble(tbCap.Text);

                            lblSonuc.Text = Convert.ToString(cevreHesapla(cbTur.Text, en, boy, cap));
                        }

                    }
                    else if (cbTur.Text == "Kare")
                    {
                        if (tbEn.Text == "")
                        {
                            MessageBox.Show("Lütfen Bir Değer Giriniz!");
                        }
                        else
                        {
                        double en = Convert.ToDouble(tbEn.Text);
                        double boy = 1;
                        double cap = 1;

                        lblSonuc.Text = Convert.ToString(cevreHesapla(cbTur.Text, en, boy, cap));
                        }
                    }
                    else if (cbTur.Text == "Dikdörtgen")
                    {
                        if (tbEn.Text == "" || tbBoy.Text == "")
                        {
                            MessageBox.Show("Lütfen Bir Değer Giriniz!");
                        }
                        else
                        {
                            double en = Convert.ToDouble(tbEn.Text);
                            double boy = Convert.ToDouble(tbBoy.Text);
                            double cap = 1;

                            lblSonuc.Text = Convert.ToString(cevreHesapla(cbTur.Text, en, boy, cap));
                        }
                    }
                    else if (cbTur.Text == "Üçgen")
                    {
                        if (tbEn.Text == "" || tbBoy.Text == "" || tbCap.Text == "")
                        {
                            MessageBox.Show("Lütfen Bir Değer Giriniz!");
                        }
                        else
                        {
                            double en = Convert.ToDouble(tbEn.Text);
                            double boy = Convert.ToDouble(tbBoy.Text);
                            double cap = Convert.ToDouble(tbCap.Text);

                            lblSonuc.Text = Convert.ToString(cevreHesapla(cbTur.Text, en, boy, cap));
                        }
                    }
                }
                else
                {
                    if (cbTur.Text == "Daire")
                    {
                        if (tbCap.Text == "")
                        {
                            MessageBox.Show("Lütfen Bir Değer Giriniz!");
                        }
                        else
                        {
                            double en = 1;
                            double boy = 1;
                            double cap = Convert.ToDouble(tbCap.Text);

                            lblSonuc.Text = Convert.ToString(alanHesapla(cbTur.Text, en, boy, cap));
                        }
                    }
                    else if (cbTur.Text == "Kare")
                    {
                        if (tbEn.Text == "")
                        {
                            MessageBox.Show("Lütfen Bir Değer Giriniz!");
                        }
                        else
                        {
                            double en = Convert.ToDouble(tbEn.Text);
                            double boy = 1;
                            double cap = 1;

                            lblSonuc.Text = Convert.ToString(alanHesapla(cbTur.Text, en, boy, cap));
                        }
                    }
                    else if (cbTur.Text == "Dikdörtgen")
                    {
                        if (tbEn.Text == "" || tbBoy.Text == "")
                        {
                            MessageBox.Show("Lütfen Bir Değer Giriniz!");
                        }
                        else
                        {
                            double en = Convert.ToDouble(tbEn.Text);
                            double boy = Convert.ToDouble(tbBoy.Text);
                            double cap = 1;

                            lblSonuc.Text = Convert.ToString(alanHesapla(cbTur.Text, en, boy, cap));
                        }
                    }
                    else if (cbTur.Text == "Üçgen")
                    {
                        if (tbEn.Text == "" || tbBoy.Text == "")
                        {
                            MessageBox.Show("Lütfen Bir Değer Giriniz!");
                        }
                        else
                        {
                            double en = Convert.ToDouble(tbEn.Text);
                            double boy = Convert.ToDouble(tbBoy.Text);
                            double cap = 1;

                            lblSonuc.Text = Convert.ToString(alanHesapla(cbTur.Text, en, boy, cap));
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen Sadece Sayı Girişi Yapınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
