using Microsoft.AspNetCore.Mvc;

namespace HexaShop.Controllers
{
    public class HexaShopController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}
