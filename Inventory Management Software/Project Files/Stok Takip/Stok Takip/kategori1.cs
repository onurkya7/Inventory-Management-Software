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
    public partial class kategori1 : DevExpress.XtraEditors.XtraForm
    {
        public kategori1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\StokTakip.accdb");


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text))
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("insert into kategori (id,kategori) values ('" + textBox1.Text + "','" + textBox2.Text + "')", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    label3.Text = textBox2.Text + " Kategorisi Oluşturuldu";
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                    MessageBox.Show("Boş Alan Bırakmayın");
            }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
    }
