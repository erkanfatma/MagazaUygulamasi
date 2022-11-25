using MagazaUygulamasi.Models;
using MagazaUygulamasi.Operations.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaUygulamasi.Operations.Concrete
{
    public class ProductOperation : IProductOperation
    {
        public static List<Product> ProductList = new List<Product>();

        public void Add(Product model)
        {
            ProductList.Add(model);
        }

        public Product Get(string code)
        {
            foreach (var item in ProductList)
            {
                if (item.Code == code)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Product> GetAll()
        {
            return ProductList;
        }

        public void Update(Product model)
        {
            foreach (var item in ProductList)
            {
                if (item.Code == model.Code)
                {
                    item.Price = model.Price;
                    item.Description = model.Description;
                    item.Stock = model.Stock;
                    item.Name = model.Name;
                    item.Color = model.Color;
                }
            }
        }
    }
}
