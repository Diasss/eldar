using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ValuesController : Controller
    {
        Model1 db = new Model1();
        // GET: Values
        public IEnumerable<Products> GetProducts()
        {
            return db.Products;
        }
        public Products GetProducts(int id)
        {
            Products pr = db.Products.Find(id);
            return pr;
        }
        public void EditProducts(int id, Products pr)
        {
            if (id == pr.Id)
            {
                db.Entry(pr).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void DeleteProduct(int id)
        {
            Products pr = db.Products.Find(id);
            if (pr != null)
            {
                db.Products.Remove(pr);
                db.SaveChanges();
            }
        }
        public ActionResult Index()
        {
            return View();
        }

    }
}