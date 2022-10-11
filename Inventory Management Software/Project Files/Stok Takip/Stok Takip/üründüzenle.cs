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
    public partial class üründüzenle : Form
    {
        public üründüzenle()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\StokTakip.accdb");
        private void üründüzenle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text) && !String.IsNullOrEmpty(textBox5.Text) && !String.IsNullOrEmpty(textBox6.Text))

            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("update urun set barkodno='" + textBox1.Text + "',kategori='" + comboBox1.Text + "',marka='" + comboBox2.Text + "',model='" + comboBox3.Text + "',urunadi='" + textBox2.Text + "',rafno='" + textBox3.Text + "',adet='" + textBox4.Text + "',gtarihi='" + dateTimePicker1.Text + "',birimfiyats='" + textBox5.Text + "',birimfiyatm='" + textBox6.Text + "' where barkodno='" + textBox1.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                label9.Text = textBox1.Text + " nolu ürün düzenlenmiştir";
            }
            else
                MessageBox.Show("Boş Alan Bırakmayın");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from urun where barkodno='" + textBox1.Text + "'", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Text = (oku["kategori"].ToString());
                comboBox2.Text = (oku["marka"].ToString());
                comboBox3.Text = (oku["model"].ToString());
                textBox2.Text = (oku["urunadi"].ToString());
                textBox3.Text = (oku["rafno"].ToString());
                textBox4.Text = (oku["adet"].ToString());
                dateTimePicker1.Text = (oku["gtarihi"].ToString());
                textBox5.Text = (oku["birimfiyats"].ToString());
                textBox6.Text = (oku["birimfiyatm"].ToString());
            }
            baglanti.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
