using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class ViewOrder : Controller
    {
        public IActionResult vieworder()
        {
            return View();
        }
    }
}
