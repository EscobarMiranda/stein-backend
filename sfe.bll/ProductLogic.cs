using sfe.dal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sfe.bll
{
    class ProductLogic
    {
        private static DataClassesDataContext db = Database.Instance;
        public static List<Product> Get()
        {
            try
            {
                return (from products in db.Products
                        where products.active == true
                        select products).ToList();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(e.Source, e.Message);
                throw new ProductListNotFoundException("Product list not found");
            }
        }

        public static Product Get(int id)
        {
            try
            {
                return (from product in db.Products
                        where product.idProduct == id
                        select product).Single();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(e.Source, e.Message);
                throw new ProductNotFoundException("Product not found");
            }
        }

        public static void Post(Product product)
        {
            try
            {
                db.Products.InsertOnSubmit(product);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(e.Source, e.Message);
                throw new PostProductException("Error creating product");
            }
        }
    }
}
