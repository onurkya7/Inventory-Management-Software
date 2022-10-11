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
    public partial class aylıkgelirgider : Form
    {
        public aylıkgelirgider()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\StokTakip.accdb");
        DataTable tablo = new DataTable();
        DataTable tablo2 = new DataTable();
        DataTable tablo3 = new DataTable();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Personel Maaş")
            {
                baglanti.Open();
                tablo.Clear();
                OleDbDataAdapter adap = new OleDbDataAdapter("select * from kullanıcıbilgi", baglanti);
                adap.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
            }
            if (comboBox1.Text == "Gider Tablosu")
            {
                baglanti.Open();
                tablo2.Clear();
                OleDbDataAdapter adap = new OleDbDataAdapter("select * from gider", baglanti);
                adap.Fill(tablo2);
                dataGridView1.DataSource = tablo2;
                baglanti.Close();
            }
            if (comboBox1.Text == "Gelir Tablosu")
            {
                baglanti.Open();
                tablo3.Clear();
                OleDbDataAdapter adap = new OleDbDataAdapter("select * from satis", baglanti);
                adap.Fill(tablo3);
                dataGridView1.DataSource = tablo3;
                baglanti.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Personel Maaş")
            {
                baglanti.Open();
                tablo.Clear();
                OleDbDataAdapter adap = new OleDbDataAdapter("select * from kullanıcıbilgi where id like '" + textBox1.Text + "'", baglanti);
                adap.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
            }
            if (comboBox1.Text == "Gider Tablosu")
            {
                baglanti.Open();
                tablo2.Clear();
                OleDbDataAdapter adap = new OleDbDataAdapter("select * from gider where ay like '" + textBox1.Text + "'", baglanti);
                adap.Fill(tablo2);
                dataGridView1.DataSource = tablo2;
                baglanti.Close();
            }
            if (comboBox1.Text == "Gelir Tablosu")
            {
                baglanti.Open();
                tablo3.Clear();
                OleDbDataAdapter adap = new OleDbDataAdapter("select * from satis where ay like'" + textBox1.Text + "'", baglanti);
                adap.Fill(tablo3);
                dataGridView1.DataSource = tablo3;
                baglanti.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if("Aylık Gider" == label8.Text)
            {
                if ("Ocak" == textBox3.Text)
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("select sum(gidertutarı ) from gider where ay in ('Ocak')", baglanti);
                    OleDbDataReader oku = komut.ExecuteReader();
                    oku.Read();
                    textBox2.Text = (oku[0].ToString());

                    baglanti.Close();
                }


                else if ("Şubat" == textBox3.Text)
                {
                    baglanti.Open();
                    OleDbCommand komut2 = new OleDbCommand("select sum(gidertutarı ) from gider where ay in ('Şubat')", baglanti);
                    OleDbDataReader oku2 = komut2.ExecuteReader();
                    oku2.Read();
                    textBox2.Text = (oku2[0].ToString());

                    baglanti.Close();
                }
                else if ("Mart" == textBox3.Text)
                {
                    baglanti.Open();
                    OleDbCommand komut2 = new OleDbCommand("select sum(gidertutarı ) from gider where ay in ('Mart')", baglanti);
                    OleDbDataReader oku2 = komut2.ExecuteReader();
                    oku2.Read();
                    textBox2.Text = (oku2[0].ToString());

                    baglanti.Close();
                }
                else if ("Nisan" == textBox3.Text)
                {
                    baglanti.Open();
                    OleDbCommand komut2 = new OleDbCommand("select sum(gidertutarı ) from gider where ay in ('Nisan')", baglanti);
                    OleDbDataReader oku2 = komut2.ExecuteReader();
                    oku2.Read();
                    textBox2.Text = (oku2[0].ToString());

                    baglanti.Close();
                }
                else if ("Mayıs" == textBox3.Text)
                {
                    baglanti.Open();
                    OleDbCommand komut2 = new OleDbCommand("select sum(gidertutarı ) from gider where ay in ('Mayıs')", baglanti);
                    OleDbDataReader oku2 = komut2.ExecuteReader();
                    oku2.Read();
                    textBox2.Text = (oku2[0].ToString());

                    baglanti.Close();
                }
                else if ("Haziran" == textBox3.Text)
                {
                    baglanti.Open();
                    OleDbCommand komut2 = new OleDbCommand("select sum(gidertutarı ) from gider where ay in ('Haziran')", baglanti);
                    OleDbDataReader oku2 = komut2.ExecuteReader();
                    oku2.Read();
                    textBox2.Text = (oku2[0].ToString());

                    baglanti.Close();
                }
                else if ("Temmuz" == textBox3.Text)
                {
                    baglanti.Open();
                    OleDbCommand komut2 = new OleDbCommand("select sum(gidertutarı ) from gider where ay in ('Temmuz')", baglanti);
                    OleDbDataReader oku2 = komut2.ExecuteReader();
                    oku2.Read();
                    textBox2.Text = (oku2[0].ToString());

                    baglanti.Close();
                }
                else if ("Ağustos" == textBox3.Text)
                {
                    baglanti.Open();
                    OleDbCommand komut2 = new OleDbCommand("select sum(gidertutarı ) from gider where ay in ('Ağustos')", baglanti);
                    OleDbDataReader oku2 = komut2.ExecuteReader();
                    oku2.Read();
                    textBox2.Text = (oku2[0].ToString());

                    baglanti.Close();
                }
                else if ("Eylül" == textBox3.Text)
                {
                    baglanti.Open();
                    OleDbCommand komut2 = new OleDbCommand("select sum(gidertutarı ) from gider where ay in ('Eylül')", baglanti);
                    OleDbDataReader oku2 = komut2.ExecuteReader();
                    oku2.Read();
                    textBox2.Text = (oku2[0].ToString());

                    baglanti.Close();
                }
                else if ("Ekim" == textBox3.Text)
                {
                    baglanti.Open();
                    OleDbCommand komut2 = new OleDbCommand("select sum(gidertutarı ) from gider where ay in ('Ekim')", baglanti);
                    OleDbDataReader oku2 = komut2.ExecuteReader();
                    oku2.Read();
                    textBox2.Text = (oku2[0].ToString());

                    baglanti.Close();
                }
                else if ("Kasım" == textBox3.Text)
                {
                    baglanti.Open();
                    OleDbCommand komut2 = new OleDbCommand("select sum(gidertutarı ) from gider where ay in ('Kasım')", baglanti);
                    OleDbDataReader oku2 = komut2.ExecuteReader();
                    oku2.Read();
                    textBox2.Text = (oku2[0].ToString());

                    baglanti.Close();
                }
                else if ("Aralık" == textBox3.Text)
                {
                    baglanti.Open();
                    OleDbCommand komut2 = new OleDbCommand("select sum(gidertutarı ) from gider where ay in ('Aralık')", baglanti);
                    OleDbDataReader oku2 = komut2.ExecuteReader();
                    oku2.Read();
                    textBox2.Text = (oku2[0].ToString());

                    baglanti.Close();
                }


            }
            if ("Aylık Gelir" == label7.Text)
            {
                if ("Ocak" == textBox3.Text)
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("select sum(karmiktari ) from satis where ay in ('Ocak')", baglanti);
                    OleDbDataReader oku = komut.ExecuteReader();
                    oku.Read();
                    textBox10.Text = (oku[0].ToString());

                    baglanti.Close();
                }
                if ("Şubat" == textBox3.Text)
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("select sum(karmiktari ) from satis where ay in ('Şubat')", baglanti);
                    OleDbDataReader oku = komut.ExecuteReader();
                    oku.Read();
                    textBox10.Text = (oku[0].ToString());

                    baglanti.Close();
                }
                if ("Mart" == textBox3.Text)
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("select sum(karmiktari ) from satis where ay in ('Mart')", baglanti);
                    OleDbDataReader oku = komut.ExecuteReader();
                    oku.Read();
                    textBox10.Text = (oku[0].ToString());

                    baglanti.Close();
                }
                if ("Nisan" == textBox3.Text)
                { 
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("select sum(karmiktari ) from satis where ay in ('Nisan')", baglanti);
                    OleDbDataReader oku = komut.ExecuteReader();
                    oku.Read();
                    textBox10.Text = (oku[0].ToString());

                    baglanti.Close();
                }
                if ("Mayıs" == textBox3.Text)
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("select sum(karmiktari ) from satis where ay in ('Mayıs')", baglanti);
                    OleDbDataReader oku = komut.ExecuteReader();
                    oku.Read();
                    textBox10.Text = (oku[0].ToString());

                    baglanti.Close();
                }
                if ("Haziran" == textBox3.Text)
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("select sum(karmiktari ) from satis where ay in ('Haziran')", baglanti);
                    OleDbDataReader oku = komut.ExecuteReader();
                    oku.Read();
                    textBox10.Text = (oku[0].ToString());

                    baglanti.Close();
                }
                if ("Temmuz" == textBox3.Text)
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("select sum(karmiktari ) from satis where ay in ('Temmuz')", baglanti);
                    OleDbDataReader oku = komut.ExecuteReader();
                    oku.Read();
                    textBox10.Text = (oku[0].ToString());

                    baglanti.Close();
                }
                if ("Ağustos" == textBox3.Text)
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("select sum(karmiktari ) from satis where ay in ('Ağustos')", baglanti);
                    OleDbDataReader oku = komut.ExecuteReader();
                    oku.Read();
                    textBox10.Text = (oku[0].ToString());

                    baglanti.Close();
                }
                if ("Eylül" == textBox3.Text)
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("select sum(karmiktari ) from satis where ay in ('Eylül')", baglanti);
                    OleDbDataReader oku = komut.ExecuteReader();
                    oku.Read();
                    textBox10.Text = (oku[0].ToString());

                    baglanti.Close();
                }
                if ("Ekim" == textBox3.Text)
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("select sum(karmiktari ) from satis where ay in ('Ekim')", baglanti);
                    OleDbDataReader oku = komut.ExecuteReader();
                    oku.Read();
                    textBox10.Text = (oku[0].ToString());

                    baglanti.Close();
                }
                if ("Kasım" == textBox3.Text)
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("select sum(karmiktari ) from satis where ay in ('Kasım')", baglanti);
                    OleDbDataReader oku = komut.ExecuteReader();
                    oku.Read();
                    textBox10.Text = (oku[0].ToString());

                    baglanti.Close();
                }
                if ("Aralık" == textBox3.Text)
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("select sum(karmiktari ) from satis where ay in ('Aralık')", baglanti);
                    OleDbDataReader oku = komut.ExecuteReader();
                    oku.Read();
                    textBox10.Text = (oku[0].ToString());

                    baglanti.Close();
                }


            }
            if ("Personel Maaşı" == label6.Text)
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("select sum(aylıkmaas ) from kullanıcıbilgi where id ", baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                oku.Read();
                textBox7.Text = (oku[0].ToString());

                baglanti.Close();
            }

           
            int a, b, c, d;

            a = Convert.ToInt32(textBox10.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = Convert.ToInt32(textBox7.Text);
            d =(b - (a + c));
            (textBox4.Text) = Convert.ToString(d) + " TL";

            if (d < 0)
            {
                d = d * -1;
                MessageBox.Show(d + " TL Zarar edildi");
            }
            else if (d > 0)
            {
                MessageBox.Show(d + " TL Kâr edildi");
            }
            else if (d == 0)
            {
                MessageBox.Show("Bu Ay Kâr Yada Zarar Edilmedi");
            }
            

        }
    }
}
