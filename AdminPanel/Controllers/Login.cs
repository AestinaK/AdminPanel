using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class Login : Controller
    {
        public IActionResult login()
        {
            return View();
        }
    }
}
