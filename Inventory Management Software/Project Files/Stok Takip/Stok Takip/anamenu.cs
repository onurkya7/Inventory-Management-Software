using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.OleDb;



namespace Stok_Takip
{
    public partial class anamenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string yazı;
        public anamenu()
        {
            InitializeComponent();
        }


        OleDbConnection baglanti = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\StokTakip.accdb");

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void anamenu_Load(object sender, EventArgs e)
        {
            textBox1.Text = yazı;
        }

        Form Yardım;
        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Yardım == null || Yardım.IsDisposed)
            {
                Yardım = new Yardım();
                Yardım.MdiParent = this;
                Yardım.Show();
            }
        }


        Form kategori1;
        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            if ("Muhasebe" != textBox1.Text)

            {
                if (kategori1 == null || kategori1.IsDisposed)
                {
                    kategori1 = new kategori1();
                    kategori1.MdiParent = this;
                    kategori1.Show();
                }
            }
            else
            {
                MessageBox.Show("Bu sekmeyi görüntülemek için yetkiniz bulunmamaktadır");
            }
        }

        Form marka;
        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            if ("Muhasebe" != textBox1.Text)

            {
                if (marka == null || marka.IsDisposed)
                {
                    marka = new marka();
                    marka.MdiParent = this;
                    marka.Show();
                }
            }
            else
            {
                MessageBox.Show("Bu sekmeyi görüntülemek için yetkiniz bulunmamaktadır");
            }
        }

        Form model;
        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            if ("Muhasebe" != textBox1.Text)

            {
                if (model == null || model.IsDisposed)
                {
                    model = new model();
                    model.MdiParent = this;
                    model.Show();
                }
            }
            else
            {
                MessageBox.Show("Bu sekmeyi görüntülemek için yetkiniz bulunmamaktadır");
            }
        }

        Form kullanıcıekle;
        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            if ("Yönetici" == textBox1.Text)

            {
                if (kullanıcıekle == null || kullanıcıekle.IsDisposed)
                {
                    kullanıcıekle = new kullanıcıekle();
                    kullanıcıekle.MdiParent = this;
                    kullanıcıekle.Show();
                }
            }

            else
            {
                MessageBox.Show("Bu sekmeyi görüntülemek için yetkiniz bulunmamaktadır");
            }
        }

        Form musteri;
        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            if ("Muhasebe" != textBox1.Text)

            {
                if (musteri == null || musteri.IsDisposed)
                {
                    musteri = new musteri();
                    musteri.MdiParent = this;
                    musteri.Show();
                }
            }
            else
            {
                MessageBox.Show("Bu sekmeyi görüntülemek için yetkiniz bulunmamaktadır");
            }
        }

        Form ürünekle;
        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            if ("Muhasebe" != textBox1.Text)

            {
                if (ürünekle == null || ürünekle.IsDisposed)
                {
                    ürünekle = new ürünekle();
                    ürünekle.MdiParent = this;
                    ürünekle.Show();
                }
            }
            else
            {
                MessageBox.Show("Bu sekmeyi görüntülemek için yetkiniz bulunmamaktadır");
            }
        }

        Form urunsil;
        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            if ("Muhasebe" != textBox1.Text)

            {
                if (urunsil == null || urunsil.IsDisposed)
                {
                    urunsil = new urunsil();
                    urunsil.MdiParent = this;
                    urunsil.Show();
                }
            }
            else
            {
                MessageBox.Show("Bu sekmeyi görüntülemek için yetkiniz bulunmamaktadır");
            }
        }

        Form üründüzenle;
        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            if ("Muhasebe" != textBox1.Text)

            {
                if (üründüzenle == null || üründüzenle.IsDisposed)
                {
                    üründüzenle = new üründüzenle();
                    üründüzenle.MdiParent = this;
                    üründüzenle.Show();
                }
            }
            else
            {
                MessageBox.Show("Bu sekmeyi görüntülemek için yetkiniz bulunmamaktadır");
            }
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        Form satısyap;
        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            if ("Muhasebe" != textBox1.Text)

            {
                if (satısyap == null || satısyap.IsDisposed)
                {
                    satısyap = new satısyap();
                    satısyap.MdiParent = this;
                    satısyap.Show();
                }
            }
            else
            {
                MessageBox.Show("Bu sekmeyi görüntülemek için yetkiniz bulunmamaktadır");
            }
        }

        Form arama;

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            if ("Muhasebe" != textBox1.Text)

            {
                if (arama == null || arama.IsDisposed)
                {
                    arama = new arama();
                    arama.MdiParent = this;
                    arama.Show();
                }
            }
            else
            {
                MessageBox.Show("Bu sekmeyi görüntülemek için yetkiniz bulunmamaktadır");
            }
        }


        Form aylıkgelirgider;
        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            if ("Yönetici" == textBox1.Text || "Muhasebe" == textBox1.Text)

            {
                if (aylıkgelirgider == null || aylıkgelirgider.IsDisposed)
                {
                    aylıkgelirgider = new aylıkgelirgider();
                    aylıkgelirgider.MdiParent = this;
                    aylıkgelirgider.Show();
                }
            }

            else
            {
                MessageBox.Show("Bu sekmeyi görüntülemek için yetkiniz bulunmamaktadır");
            }
        }

        Form gider;
        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            if ("Yönetici" == textBox1.Text || "Muhasebe" == textBox1.Text)

            {
                if (gider == null || gider.IsDisposed)
                {
                    gider = new gider();
                    gider.MdiParent = this;
                    gider.Show();
                }
            }
            else
            {
                MessageBox.Show("Bu sekmeyi görüntülemek için yetkiniz bulunmamaktadır");
            }
        }

        Form müsteridüz;
        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
        {
            if ("Muhasebe" != textBox1.Text)

            {
                if (müsteridüz == null || müsteridüz.IsDisposed)
                {
                    müsteridüz = new müsteridüz();
                    müsteridüz.MdiParent = this;
                    müsteridüz.Show();
                }
            }
            else
            {
                MessageBox.Show("Bu sekmeyi görüntülemek için yetkiniz bulunmamaktadır");
            }
        }

        Form kullanıcıdüzcs;
        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {
            if ("Yönetici" == textBox1.Text)

            {
                if (kullanıcıdüzcs == null || kullanıcıdüzcs.IsDisposed)
                {
                    kullanıcıdüzcs = new kullanıcıdüzcs();
                    kullanıcıdüzcs.MdiParent = this;
                    kullanıcıdüzcs.Show();
                }
            }
            else
            {
                MessageBox.Show("Bu sekmeyi görüntülemek için yetkiniz bulunmamaktadır");
            }
        }
        private void barButtonItem24_ItemClick(object sender, ItemClickEventArgs e)
        {

        }


    }
}