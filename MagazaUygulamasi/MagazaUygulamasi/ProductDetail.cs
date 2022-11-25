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
    public partial class ProductDetail : Form
    {
        ProductOperation productOperation = new ProductOperation();
        Product product;
        public ProductDetail(Product detail)
        {
            product = detail;
            InitializeComponent();
        }

        private void ProductDetail_Load(object sender, EventArgs e)
        {
            lblName.Text = product.Name; 
        }

        private void btnFindProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage main = new MainPage();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product model = new Product();
            model.Name = "Elbise";
            model.Stock = 4;

            productOperation.Add(model);
        }
    }
}
