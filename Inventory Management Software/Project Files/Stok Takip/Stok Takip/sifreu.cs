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
    public partial class sifreu : Form
    {
        public sifreu()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\StokTakip.accdb");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from KullanıcıBilgi where id='" + textBox1.Text + "'", baglanti);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            if (okuyucu.Read() == true)
            {
                if (textBox1.Text == okuyucu["id"].ToString() && textBox2.Text == okuyucu["adsoyad"].ToString())

                    MessageBox.Show("Mevcut Şifreniz: " + okuyucu["sifre"].ToString());
                else
                {
                    MessageBox.Show("Lütfen giriş bilgilerinizi konttrol ediniz");
                }

            }
            baglanti.Close();
        }
    }
}
