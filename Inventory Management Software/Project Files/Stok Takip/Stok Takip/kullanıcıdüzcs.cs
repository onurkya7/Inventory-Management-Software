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
    public partial class kullanıcıdüzcs : Form
    {
        public kullanıcıdüzcs()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\StokTakip.accdb");

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text) && !String.IsNullOrEmpty(textBox5.Text))

                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("update kullanıcıbilgi set id='" + textBox1.Text + "',sifre='" + textBox2.Text + "',adsoyad='" + textBox3.Text + "',görevi='" + textBox4.Text + "',aylıkmaas='" + textBox5.Text + "' where id='" + textBox1.Text + "'", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kullanıcı Bilgileri Düzenlenmiştir");
                }
                else
                    MessageBox.Show("Boş Alan Bırakmayın");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from kullanıcıbilgi where id='" + textBox1.Text + "'", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                textBox2.Text = (oku["sifre"].ToString());
                textBox3.Text = (oku["adsoyad"].ToString());
                textBox4.Text = (oku["görevi"].ToString());
                textBox5.Text = (oku["aylıkmaas"].ToString());
                
            }
            baglanti.Close();
        }
    }
}
