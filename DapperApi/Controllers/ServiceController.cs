using DapperApi.Dtos.CategoryDtos;
using DapperApi.Dtos.ServiceDtos;
using DapperApi.Repositories.ServiceRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DapperApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceRepository _serviceRepository;

        public ServiceController(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }
        [HttpGet("ServiceList")]
        public async Task<IActionResult> ServiceLİst()
        {
            var values = await _serviceRepository.GetAllService();
            return Ok(values);
        }
        [HttpPost("InsertService")]
        public async Task<IActionResult> CreateCategory(CreateServiceDto createServiceDto)
        {

            _serviceRepository.CreateService(createServiceDto);
            return Ok("Servis Eklendi");
        }

        [HttpPut("ServiceStatus{id}")]
        public async Task<IActionResult> ServiceStatusChange(int id)
        {
            _serviceRepository.DeleteService(id);
            return Ok();
        }
        [HttpPut("ServiceUpdate")]
        public async Task<IActionResult> ServiceUpdate(UpdateServiceDto updateServiceDto)
        {
            _serviceRepository.UpdateService(updateServiceDto);
            return Ok();
        }
        [HttpGet("ServiceFilterList{id}")]
        public async Task<IActionResult> ServiceFilter(int id)
        {         
            var values = await _serviceRepository.GetServiceId(id);
            if (values == null)
            {
                return StatusCode(400, "Girdiğiniz değer ile ilgili bir kayıt bulunamadı..");
            }
            return Ok(values);
        }
    }
}
