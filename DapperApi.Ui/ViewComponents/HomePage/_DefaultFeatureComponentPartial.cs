using Microsoft.AspNetCore.Mvc;

namespace DapperApi.Ui.ViewComponents.HomePage
{
    public class _DefaultFeatureComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
