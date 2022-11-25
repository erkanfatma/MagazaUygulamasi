using MagazaUygulamasi.Models;
using MagazaUygulamasi.Operations.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazaUygulamasi
{
    public partial class MainPage : Form
    {
        ProductOperation productOperation = new ProductOperation();
        string username;
        public MainPage(string userinfo)
        {
            username = userinfo;
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void btnFindProduct_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "" || txtCode.Text == null)
            {
                MessageBox.Show("Lütfen kod giriniz.");
            }
            else
            {
                Product urunumuz = productOperation.Get(txtCode.Text);

                if (urunumuz == null) {
                    MessageBox.Show("Ürün bulunamadı");
                }
                else
                {
                    this.Hide();
                    ProductDetail detail = new ProductDetail(urunumuz);
                    detail.Show();
                }
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            lblUsername.Text = username;
        }
    }
}
