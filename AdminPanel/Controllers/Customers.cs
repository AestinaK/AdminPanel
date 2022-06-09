using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class Customers : Controller
    {
        public IActionResult customer()
        {
            return View();
        }
    }
}
