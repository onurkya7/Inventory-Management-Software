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
    public partial class ürünekle : Form
    {
        public ürünekle()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\StokTakip.accdb");
        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text) && !String.IsNullOrEmpty(textBox5.Text) && !String.IsNullOrEmpty(textBox6.Text))
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("insert into urun (barkodno,kategori,marka,model,urunadi,rafno,adet,gtarihi,birimfiyatm,birimfiyats) values ('" + textBox1.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + dateTimePicker1.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                label9.Text = " Ürün başarıyla kaydedildi";
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                baglanti.Close();
                ürünekle_Load(sender, e);
            }
            else
                MessageBox.Show("Boş Alan Bırakmayın");
        }
        private void ürünekle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select kategori from kategori ", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                comboBox1.Items.Add(oku["kategori"].ToString());
            }
            baglanti.Close();

            baglanti.Open();
            OleDbCommand komut2 = new OleDbCommand("select marka from marka ", baglanti);
            OleDbDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                comboBox2.Items.Add(oku2["marka"].ToString());
            }
            baglanti.Close();

            baglanti.Open();
            OleDbCommand komut3 = new OleDbCommand("select model from model ", baglanti);
            OleDbDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                comboBox3.Items.Add(oku3["model"].ToString());
            }
            baglanti.Close();
        }
    }
}
