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
    public partial class müsteridüz : Form
    {
        public müsteridüz()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\StokTakip.accdb");
        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text) && !String.IsNullOrEmpty(textBox5.Text) && !String.IsNullOrEmpty(textBox6.Text))

            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("update musteri  set tc='" + textBox6.Text + "',ad='" + textBox1.Text + "',soyad='" + textBox2.Text + "',adres='" + textBox3.Text + "',telefon='" + textBox4.Text + "',eposta='" + textBox5.Text + "' where tc='" + textBox6.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Müşteri Bilgileri Düzenlenmiştir");
            }
            else
                MessageBox.Show("Boş Alan Bırakmayın");          
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("select * from musteri where tc='" + textBox6.Text + "'", baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    textBox1.Text = (oku["ad"].ToString());
                    textBox2.Text = (oku["soyad"].ToString());
                    textBox3.Text = (oku["adres"].ToString());
                    textBox4.Text = (oku["telefon"].ToString());
                    textBox5.Text = (oku["eposta"].ToString());
                }
                baglanti.Close();
            }
        }
    }
}
