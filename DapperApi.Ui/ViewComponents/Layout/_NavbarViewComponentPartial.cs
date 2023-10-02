using Microsoft.AspNetCore.Mvc;

namespace DapperApi.Ui.ViewComponents.Layout
{
    public class _NavbarViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }
    }
}
