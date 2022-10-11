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
    public partial class model : Form
    {
        public model()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\StokTakip.accdb");
        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text))
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("insert into model (id,model) values ('" + textBox1.Text + "','" + textBox2.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                label3.Text = textBox2.Text + " modeli oluşturuldu";
                textBox1.Clear();
                textBox2.Clear();

            }
            else
                MessageBox.Show("Boş Alan Bırakmayın.");
        }
    }
}