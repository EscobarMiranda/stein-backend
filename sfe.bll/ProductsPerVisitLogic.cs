using sfe.bll.Exceptions;
using sfe.dal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sfe.bll
{
    public class ProductsPerVisitLogic
    {
        private static DataClassesDataContext db = Database.Instance;

        public static List<ProductsPerVisit> Read()
        {
            try
            {
                return (from productsPerVisits in db.ProductsPerVisits
                        select productsPerVisits).ToList();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("sfe", e.StackTrace.ToString(), EventLogEntryType.Error);
                throw new ProductsPerVisitListNotFoundException("Product per visit list not found");
            }
        }

        public static List<ProductsPerVisit> ReadPerVisit(int FK_visit)
        {
            try
            {
                return (from productsPerVisits in db.ProductsPerVisits
                        where productsPerVisits.FK_visit == FK_visit
                        select productsPerVisits).ToList();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("sfe", e.StackTrace.ToString(), EventLogEntryType.Error);
                throw new ProductsPerVisitListNotFoundException("Product per visit list not found");
            }
        }

        public static ProductsPerVisit Read(int id)
        {
            try
            {
                return (from productsPerVisit in db.ProductsPerVisits
                        where productsPerVisit.idProductPerVisit == id
                        select productsPerVisit).Single();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("sfe", e.StackTrace.ToString(), EventLogEntryType.Error);
                throw new ProductsPerVisitNotFoundException("product per visit not found");
            }
        }

        public static ProductsPerVisit Read(int id, int FK_visit)
        {
            try
            {
                return (from productsPerVisit in db.ProductsPerVisits
                        where productsPerVisit.idProductPerVisit == id && productsPerVisit.FK_visit == FK_visit
                        select productsPerVisit).Single();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("sfe", e.StackTrace.ToString(), EventLogEntryType.Error);
                throw new ProductsPerVisitNotFoundException("Products per visit not found");
            }
        }

        public static void Create(ProductsPerVisit productPerVisit)
        {
            try
            {
                db.ProductsPerVisits.InsertOnSubmit(productPerVisit);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("sfe", e.StackTrace.ToString(), EventLogEntryType.Error);
                throw new PostProductsPerVisitException("Error creating product per visit");
            }
        }

        public static void Update(ProductsPerVisit productPerVisit)
        {
            try
            {
                ProductsPerVisit tmpProductPerVisit = Read(productPerVisit.idProductPerVisit);
                tmpProductPerVisit.quantity = productPerVisit.quantity;
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("sfe", e.StackTrace.ToString(), EventLogEntryType.Error);
                throw new UpdateProductsPerVisitException("Error updating products per visit");
            }
        }
    }
}
