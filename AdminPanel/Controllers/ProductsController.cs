using AdminPanel.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class ProductsController : Controller
    {
        DataContext dal = new DataContext();

        public IActionResult Product()
        {
            var dataselect = dal.pcs.ToList();
            ViewBag.data = dataselect;
            select();
            return View();
        }
        [HttpPost]
        public IActionResult Insert(Add p)
        {
            Add obj = new Add()
            {
                id = p.id,
                name = p.name,
                category = p.category,
                scategory=p.scategory,
                status=p.status,
                Description = p.Description,
                size = p.size,
                price = p.price,
                stock = p.stock,
            };
            dal.pcs.Add(obj);
            dal.SaveChanges();
            TempData["Message"] = "Your product added!";
            return RedirectToAction("Product");

        }
        public IActionResult select()
        {
            var data = dal.pcs.ToList();
            ViewBag.d = data;
            return RedirectToAction("category");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var data = dal.pcs.Find(id);
            dal.pcs.Remove(data);
            dal.SaveChanges();

            return RedirectToAction("Product");
        }

        public IActionResult Update(int id)
        {
            var data = dal.pcs.Find(id);
            ViewBag.d = data;
            return View();

        }
        public IActionResult up(Add a)
        {
            Add oj = new Add() {

                id = a.id,
                name = a.name,
                category = a.category,
                scategory = a.scategory,
                status = a.status,
                Description = a.Description,
                size = a.size,
                price = a.price,
                stock = a.stock,
            };
            dal.pcs.Update(oj);
            dal.SaveChanges();
            return RedirectToAction("Product");
        }
    }
}
