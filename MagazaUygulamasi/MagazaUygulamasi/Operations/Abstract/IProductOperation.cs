using MagazaUygulamasi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaUygulamasi.Operations.Abstract
{
    public interface IProductOperation
    {
        //ürünleri listele
        List<Product> GetAll();
        //koduna göre ürünü bul
        Product Get(string code);
        //ürün ekle
        void Add(Product model);
        //ürün güncelle
        void Update(Product model);
    }
}
