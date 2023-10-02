using Dapper;
using DapperApi.Dtos.TestimonialDto;
using DapperApi.Models.DapperContext;

namespace DapperApi.Repositories.TestimonialRepository
{
    public class TestimonialRepository : ITestimonialRepository
    {
        private readonly Context _context;

        public TestimonialRepository(Context context)
        {
            _context = context;
        }

        public void CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteTestimonial(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultTestimonialDto>> GetAllTestimonial()
        {
            string query = "SELECT * FROM Testimonial";
            using(var connection=_context.CreateConnection())
            {
                var values=await connection.QueryAsync<ResultTestimonialDto>(query);
                return values.ToList();
            }
        }

        public Task<GetTestimonialDto> GetTestimonial(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            throw new NotImplementedException();
        }
    }
}
