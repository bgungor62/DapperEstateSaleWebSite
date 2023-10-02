using DapperApi.Dtos.ServiceDtos;
using DapperApi.Dtos.TestimonialDto;

namespace DapperApi.Repositories.TestimonialRepository
{
    public interface ITestimonialRepository
    {
        Task<List<ResultTestimonialDto>> GetAllTestimonial();
        void CreateTestimonial(CreateTestimonialDto createTestimonialDto);
        void DeleteTestimonial(int id);
        void UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto);
        Task<GetTestimonialDto> GetTestimonial(int id);
    }
}
