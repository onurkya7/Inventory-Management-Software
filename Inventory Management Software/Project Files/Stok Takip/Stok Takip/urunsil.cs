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
    public partial class urunsil : Form
    {
        public urunsil()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\StokTakip.accdb");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from urun where barkodno='" + textBox1.Text + "'", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                textBox2.Text=(oku["urunadi"].ToString());
                textBox3.Text=(oku["adet"].ToString());
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("delete * from urun where barkodno='" + textBox1.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                label4.Text = textBox1.Text + " nolu ürün sistemden silindi";
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else
                MessageBox.Show("Barkod No Giriniz");
        }

    }
}
