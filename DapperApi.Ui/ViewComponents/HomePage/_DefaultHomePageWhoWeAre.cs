using DapperApi.Ui.ViewModel.WhoWeAreModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DapperApi.Ui.ViewComponents.HomePage
{
    public class _DefaultHomePageWhoWeAre : ViewComponent

    {
        private readonly IHttpClientFactory _clientFactory;

        public _DefaultHomePageWhoWeAre(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        #region bura da olay şudur viewbag ile iki tane tablodan verileri eş zamanlı oalrak alabiliriz 
        #endregion
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _clientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44317/api/WhoWeAreDetail");
            var responseMessage2 = await client.GetAsync("https://localhost:44317/api/Service/ServiceList");
            if (responseMessage.IsSuccessStatusCode && responseMessage2.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();

                var values = JsonConvert.DeserializeObject<List<ResultWhoWeAreModel>>(jsonData);
                var values2 = JsonConvert.DeserializeObject<List<ResultServiceWhoWeAreModel>>(jsonData2);

                ViewBag.title = values.Select(x=>x.Title).FirstOrDefault();
                ViewBag.subtitle = values.Select(x => x.Subtitle).FirstOrDefault();
                ViewBag.description = values.Select(x => x.Description).FirstOrDefault();
                ViewBag.description2 = values.Select(x => x.Description2).FirstOrDefault();

                

                return View(values2);
            }
            return View();
        }
    }
}
