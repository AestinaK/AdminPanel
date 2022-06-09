using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class Order : Controller
    {
        public IActionResult order()
        {
            return View();
        }
    }
}
