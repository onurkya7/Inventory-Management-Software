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
    public partial class kullanıcıekle : Form
    {
        public kullanıcıekle()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\StokTakip.accdb");
        private void button1_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text) && !String.IsNullOrEmpty(textBox5.Text))
            {

                baglanti.Open();
                OleDbCommand komut2 = new OleDbCommand("insert into kullanıcıbilgi (id,sifre,adsoyad,görevi,aylıkmaas) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                label5.Text = " Kullanıcı Başarıyla Kaydedildi";
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();

            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayınız.");
            }
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    {
        //        if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text) && !String.IsNullOrEmpty(textBox5.Text))

        //        {
        //            baglanti.Open();
        //            OleDbCommand komut = new OleDbCommand("update kullanıcıbilgi set id='" + textBox1.Text + "',sifre='" + textBox2.Text + "',adsoyad='" + textBox3.Text + "',görevi='" + textBox4.Text + "',aylıkmaas='" + textBox5.Text + "' where id='" + textBox1.Text + "'", baglanti);
        //            komut.ExecuteNonQuery();
        //            baglanti.Close();
        //            MessageBox.Show("Kullanıcı Düzenlendi");
        //        }
        //        else
        //            MessageBox.Show("Boş Alan Bırakmayın");
        //    }

        //    private void textBox1_TextChanged(object sender, EventArgs e)
        //    {
        //        baglanti.Open();
        //        OleDbCommand komut3 = new OleDbCommand("select * from kullanıcıbilgi where id='" + textBox1.Text + "'", baglanti);
        //        OleDbDataReader oku3 = komut3.ExecuteReader();
        //        while (oku3.Read())
        //        {

        //            textBox2.Text = (oku3["sifre"].ToString());
        //            textBox3.Text = (oku3["adsoyad"].ToString());
        //            textBox4.Text = (oku3["görevi"].ToString());
        //            textBox5.Text = (oku3["aylıkmaas"].ToString());

        //        }
        //        baglanti.Close();
        //    }
        }

    }

