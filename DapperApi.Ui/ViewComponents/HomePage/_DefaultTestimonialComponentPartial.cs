using DapperApi.Ui.ViewModel.TestimonialModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DapperApi.Ui.ViewComponents.HomePage
{
    public class _DefaultTestimonialComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultTestimonialComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client=_httpClientFactory.CreateClient();
            var responseMessage=await client.GetAsync("https://localhost:44317/api/Testimonial");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonDta=await responseMessage.Content.ReadAsStringAsync();
                var values=JsonConvert.DeserializeObject<List<ResultTestimonialModel>>(jsonDta);
                return View(values);
            }
            return View();
        }
    }
}
