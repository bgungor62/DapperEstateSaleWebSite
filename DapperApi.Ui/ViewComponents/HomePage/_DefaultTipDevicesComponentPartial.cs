using Microsoft.AspNetCore.Mvc;

namespace DapperApi.Ui.ViewComponents.HomePage
{
    public class _DefaultTipDevicesComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
