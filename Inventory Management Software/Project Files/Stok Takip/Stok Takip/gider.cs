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
    public partial class gider : Form
    {
        public gider()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\StokTakip.accdb");

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(comboBox1.Text) && !String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text))
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("insert into gider (gidertürü,evrakno,gidertutarı,ödemetutarı,ay,yıl,gtarihi) values ('" + comboBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox1.Text + "','" + textBox5.Text + "','" + dateTimePicker1.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();


                label6.Text = " Gider başarıyla kaydedildi";

                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                comboBox1.Items.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox1.Clear();
                


                baglanti.Close();
                

            }
            else
                MessageBox.Show("Boş Alan Bırakmayın");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text) && !String.IsNullOrEmpty(textBox5.Text) && !String.IsNullOrEmpty(comboBox1.Text))

            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("update gider set evrakno ='" + textBox2.Text + "',gidertürü='" + comboBox1.Text + "',gidertutarı='" + textBox3.Text + "',ödemetutarı='" + textBox4.Text + "',ay='" + textBox1.Text + "',yıl='" + textBox5.Text + "',gtarihi='" + dateTimePicker1.Text + "' where evrakno='" + textBox2.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ödeme Düzenlenmiştir");
            }
            else
                MessageBox.Show("Boş Alan Bırakmayın");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("select * from gider where evrakno='" + textBox2.Text + "'", baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    textBox1.Text = (oku["ay"].ToString());
                    textBox3.Text = (oku["gidertutarı"].ToString());
                    textBox4.Text = (oku["ödemetutarı"].ToString());
                    textBox5.Text = (oku["yıl"].ToString());
                    comboBox1.Text = (oku["gidertürü"].ToString());
                    dateTimePicker1.Text = (oku["gtarihi"].ToString());
                }
                baglanti.Close();
            }
        }
    }
}
