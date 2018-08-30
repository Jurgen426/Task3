using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        ProductContext db = new ProductContext();

        public ActionResult Index()
        {
            //IEnumerable<Category> categories = db.Categories;
            var categories = db.Categories;
            ViewBag.Categories = categories;
            return View();
        }

        public ActionResult ShowProducts(int id)
        {
 
            var query = from pr in db.Products
                        where pr.CatId == id
                        select pr;

            ViewBag.Prod = query;
            return View();
        }
        ///////////
        //работа с корзиной
        /////////

            //добавить в корзину
        public ActionResult Basket(int id)
        {
            var query = from pr in db.Products
                        where pr.Id == id
                        select pr;
            
            
            List<Product> listProduct = query.ToList<Product>();

            Basket tmp = new Basket { ProdId = id, ProdName=listProduct[0].Name, Price = listProduct[0].Price };
            db.Baskets.Add(tmp);
            db.SaveChanges();

            var b = db.Baskets;
            ViewBag.ProdInBasket = b;
            return View();
        }

        //удалить
        public ActionResult Delete(int id)
        {
            

            Basket basket = db.Baskets.Where(b => b.ProdId == id).FirstOrDefault();

            db.Baskets.Remove(basket);
            db.SaveChanges();

            var bs = db.Baskets;
            ViewBag.ProdInBasket = bs;

            return View("Basket");

        }




        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}