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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\manag\\Documents\\StokTakip.accdb");

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurun");
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Lüften ID yi boş bırakmayın");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Lüften Şifreyi boş bırakmayın");
            }
            else
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("select * from KullanıcıBilgi where id='" + textBox1.Text + "'", baglanti);
                OleDbDataReader okuyucu = komut.ExecuteReader();
                if (okuyucu.Read() == true)
                {
                    if (textBox1.Text == okuyucu["id"].ToString() && textBox2.Text == okuyucu["sifre"].ToString())
                    {
                        MessageBox.Show("Hoşgeldin Sayın " + okuyucu["adsoyad"].ToString());
                        Form frm1 = new anamenu();
                        frm1.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Lütfen giriş bilgilerinizi konttrol ediniz");
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen giriş bilgilerinizi kontrol ediniz");
                }

                baglanti.Close();
            }
        }

    }
}
