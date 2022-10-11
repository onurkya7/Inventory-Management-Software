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
    public partial class arama : Form
    {
        public arama()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\StokTakip.accdb");
        DataTable tablo = new DataTable();
        DataTable tablo2 = new DataTable();
        DataTable tablo3 = new DataTable();
        private void aramacs_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text=="Müşteri")
            {
                baglanti.Open();
                tablo.Clear();
                OleDbDataAdapter adap = new OleDbDataAdapter("select * from musteri", baglanti);
                adap.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
            }
            else if (comboBox1.Text=="Ürün")
            {
                baglanti.Open();
                tablo2.Clear();
                OleDbDataAdapter adap2 = new OleDbDataAdapter("select * from urun", baglanti);
                adap2.Fill(tablo2);
                dataGridView1.DataSource = tablo2;
                baglanti.Close();
            }
            else if (comboBox1.Text == "Satış Bilgisi")
            {
                baglanti.Open();
                tablo3.Clear();
                OleDbDataAdapter adap3 = new OleDbDataAdapter("select * from satis", baglanti);
                adap3.Fill(tablo3);
                dataGridView1.DataSource = tablo3;
                baglanti.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Müşteri")
            {
                baglanti.Open();
                tablo.Clear();
                OleDbDataAdapter adap = new OleDbDataAdapter("select * from musteri where tc like '" + textBox1.Text + "'", baglanti);
                adap.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
            }
            else if (comboBox1.Text == "Ürün")
            {
                baglanti.Open();
                tablo2.Clear();
                OleDbDataAdapter adap2 = new OleDbDataAdapter("select * from urun where barkodno like '" + textBox1.Text + "'", baglanti);
                adap2.Fill(tablo2);
                dataGridView1.DataSource = tablo2;
                baglanti.Close();
            }
            else if (comboBox1.Text == "Satış Bilgisi")
            {
                baglanti.Open();
                tablo3.Clear();
                OleDbDataAdapter adap3 = new OleDbDataAdapter("select * from satis where tc like '" + textBox1.Text + "'", baglanti);
                adap3.Fill(tablo3);
                dataGridView1.DataSource = tablo3;
                baglanti.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
