using Microsoft.AspNetCore.Mvc;

namespace DapperApi.Ui.ViewComponents.HomePage
{
    public class _DefaultPopularLocationComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
