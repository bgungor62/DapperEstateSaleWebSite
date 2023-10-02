using Microsoft.AspNetCore.Mvc;

namespace DapperApi.Ui.ViewComponents.HomePage
{
    public class _DefaultClientComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
