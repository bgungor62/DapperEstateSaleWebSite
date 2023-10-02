using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DapperApi.Ui.ViewComponents.HomePage
{
    public class _DefaultServicesComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultServicesComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client=_httpClientFactory.CreateClient();
            var responseMessage=await client.GetAsync("https://localhost:44317/api/Service/ServiceList");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData=await responseMessage.Content.ReadAsStringAsync();
                var values=JsonConvert.DeserializeObject<List<>>
            }
            return View();
        }
    }
}
