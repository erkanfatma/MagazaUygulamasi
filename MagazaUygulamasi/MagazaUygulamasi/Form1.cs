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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "fatma@erkan.com"
                && txtPassword.Text == "1234")
            {
                //sayfalar arası geçiş yaparken
                this.Hide();
                MainPage main = new MainPage("Fatma");
                main.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bilgilerinizi kontrol ediniz.");
            }
           
        }
    }
}
