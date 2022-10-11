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
    public partial class satısyap : Form
    {
        public satısyap()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\StokTakip.accdb");

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from musteri where tc= '" + textBox9.Text + "'", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                textBox8.Text = (oku["ad"].ToString());
                textBox7.Text = (oku["soyad"].ToString());
                textBox6.Text = (oku["adres"].ToString());
                textBox4.Text = (oku["telefon"].ToString());
                textBox5.Text = (oku["eposta"].ToString());
            }
            baglanti.Close();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut2 = new OleDbCommand("select * from urun where barkodno= '" + textBox1.Text + "'", baglanti);
            OleDbDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                comboBox1.Text = (oku2["kategori"].ToString());
                comboBox2.Text = (oku2["marka"].ToString());
                comboBox3.Text = (oku2["model"].ToString());
                textBox2.Text = (oku2["urunadi"].ToString());
                comboBox4.Text = (oku2["birimfiyats"].ToString());
                label21.Text = "TL";



            }
            baglanti.Close();
        }
        int a, b, c, d, f, g, h, s;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox3.Text))

                a = Convert.ToInt32(textBox3.Text);
                d = Convert.ToInt32(comboBox4.Text);

                textBox10.Text = Convert.ToString(a * d);
                label18.Text = "TL";



        }

        private void satısyap_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox9.Text) && !String.IsNullOrEmpty(textBox13.Text))


            {

                baglanti.Open();
                OleDbCommand komut5 = new OleDbCommand("select * from urun where barkodno= '" + textBox1.Text + "'", baglanti);
                OleDbDataReader oku5 = komut5.ExecuteReader();
                while (oku5.Read())
                {
                    f = Convert.ToInt32(oku5["birimfiyatm"].ToString());
                    (textBox12.Text) = Convert.ToString(f);
                    label22.Text = "TL";



                }
                baglanti.Close();

                baglanti.Open();
                OleDbCommand komut6 = new OleDbCommand("select * from urun where barkodno= '" + textBox1.Text + "'", baglanti);
                OleDbDataReader oku6 = komut6.ExecuteReader();
                while (oku6.Read())
                {
                    g = Convert.ToInt32(oku6["birimfiyats"].ToString());

                }
                baglanti.Close();


                a = Convert.ToInt32(textBox3.Text);
                baglanti.Open();
                OleDbCommand komut2 = new OleDbCommand("select * from urun where barkodno= '" + textBox1.Text + "'", baglanti);
                OleDbDataReader oku2 = komut2.ExecuteReader();
                while (oku2.Read())
                {
                    b = Convert.ToInt32(oku2["adet"].ToString());

                }
                baglanti.Close();

                if (b - a < 0)
                {
                    MessageBox.Show("İstenilen Sayıda Ürün Stokta Bulunmamaktadır");
                }
                else
                {
                    baglanti.Open();
                    c = b - a;
                    OleDbCommand komut3 = new OleDbCommand("update urun set adet= '" + c + "' where barkodno= '" + textBox1.Text + "'", baglanti);
                    komut3.ExecuteNonQuery();
                    baglanti.Close();

                    
                    baglanti.Open();
                    s = Convert.ToInt32(textBox10.Text);
                    h = (s - (a * f));
                    OleDbCommand komut7 = new OleDbCommand("update satis set karmiktari= '" + h + "' where satinalmatarihi= '" + textBox1.Text + "'", baglanti);
                    komut7.ExecuteNonQuery();
                    textBox11.Text = Convert.ToString(h);
                    label23.Text = "TL";

                    baglanti.Close();


                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("insert into satis (tc,ad,soyad,adres,telefon,eposta,barkodno,kategori,marka,model,urunadi,adet,birimfiyats,toplamfiyat,karmiktari,satinalmatarihi,ay) values ('" + textBox9.Text + "','" + textBox8.Text + "','" + textBox7.Text + "','" + textBox6.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox1.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox4.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + dateTimePicker1.Text + "','" + textBox13.Text + "')", baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Satış Başarıyla Tamamlanmıştır.");
                    baglanti.Close();
                }
            }
            else
                MessageBox.Show("Boş Alan Bırakmayın.");

        }
    }
}