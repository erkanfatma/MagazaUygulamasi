using MagazaUygulamasi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazaUygulamasi
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Product urun = new Product();
            urun.Name = txtName.Text;
            urun.Color = "Kırmızı";
            urun.Stock = 4;
            Console.WriteLine("Log operation");
        }
    }
}
