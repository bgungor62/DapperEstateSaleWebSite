﻿using Microsoft.AspNetCore.Mvc;

namespace DapperApi.Ui.ViewComponents.Layout
{
    public class _FooterViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
