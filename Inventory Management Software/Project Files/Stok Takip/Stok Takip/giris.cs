using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Stok_Takip
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\StokTakip.accdb");

        private void alphaBlendTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (alphaBlendTextBox1.Text == "" && alphaBlendTextBox2.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurun");
            }
            else if (alphaBlendTextBox1.Text == "")
            {
                MessageBox.Show("Lüften ID yi boş bırakmayın");
            }
            else if (alphaBlendTextBox2.Text == "")
            {
                MessageBox.Show("Lüften Şifreyi boş bırakmayın");
            }
            else
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("select * from KullanıcıBilgi where id='" + alphaBlendTextBox1.Text + "'", baglanti);
                OleDbDataReader okuyucu = komut.ExecuteReader();
                if (okuyucu.Read() == true)
                {
                    if (alphaBlendTextBox1.Text == okuyucu["id"].ToString() && alphaBlendTextBox2.Text == okuyucu["sifre"].ToString())
                    {
                        MessageBox.Show("Hoşgeldin Sayın " + okuyucu["adsoyad"].ToString());
                        Form frm1 = new anamenu();
                        frm1.Show();
                        this.Hide();

                        OleDbCommand komut2 = new OleDbCommand("select * from KullanıcıBilgi where id='" + alphaBlendTextBox1.Text + "'", baglanti);
                        OleDbDataReader okuyucu2 = komut2.ExecuteReader();
                        while (okuyucu2.Read())
                        {
                            textBox1.Text = (okuyucu["görevi"].ToString());
                            anamenu frm = new anamenu();
                            
                            frm.yazı = textBox1.Text;
                            frm.ShowDialog();
                        }
                    }

                    else
                    {
                        MessageBox.Show("Lütfen giriş bilgilerinizi kontrol ediniz");
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen giriş bilgilerinizi kontrol ediniz");
                }

                baglanti.Close();
            }
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            textBox1.Visible = false;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form frm2 = new sifreu();
            frm2.Show();
            
        }
    }
}
