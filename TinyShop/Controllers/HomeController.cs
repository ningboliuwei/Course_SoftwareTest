#region

using Microsoft.AspNetCore.Mvc;

#endregion

namespace TinyShop.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return this.View();
        }
    }
}