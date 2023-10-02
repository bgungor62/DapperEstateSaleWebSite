using Microsoft.AspNetCore.Mvc;

namespace DapperApi.Ui.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
