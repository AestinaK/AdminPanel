using AdminPanel.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class Category : Controller
    {
        DataContext dal = new DataContext();
        public IActionResult category()
        {
            var dataselect = dal.cat.ToList();
            ViewBag.data = dataselect;
            select();
            return View();
           
        }

        //insert
        [HttpPost]
       public IActionResult Add(AddC c)
        {
            AddC ob = new AddC()
            {
                cid = c.cid,
                cname = c.cname,
            };
            
            dal.cat.Add(ob);
            dal.SaveChanges();
            return RedirectToAction("category");
        }

        //select

        public IActionResult select()
        {
            var data=dal.cat.ToList();
            ViewBag.d = data;
            return RedirectToAction("category");
        }
        //delete
        [HttpGet]
        public IActionResult Delete(int cid)
        {
            var data = dal.cat.Find(cid);
            dal.cat.Remove(data);
            dal.SaveChanges();

            return RedirectToAction("category");
        }

        //update
        public IActionResult update(int cid)
        {
            var data = dal.cat.Find(cid);
            ViewBag.d = data;
            return View();

        }

        public IActionResult updater(AddC c)
        {
            AddC ob = new AddC()
            {
                cid = c.cid,
                cname = c.cname,
            };

            dal.cat.Update(ob);
            dal.SaveChanges();
            return RedirectToAction("category");
        }

    }
}
