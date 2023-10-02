using Microsoft.AspNetCore.Mvc;

namespace DapperApi.Ui.ViewComponents.Layout
{
    public class _ScriptViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
