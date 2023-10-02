using Microsoft.AspNetCore.Mvc;

namespace DapperApi.Ui.ViewComponents.HomePage
{
    public class _DefaultHomeFooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
