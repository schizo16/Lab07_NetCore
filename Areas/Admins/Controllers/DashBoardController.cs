using Microsoft.AspNetCore.Mvc;

namespace Lab07_NetCore.Areas.Admins.Controllers
{
    [Area("Admin")]
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
