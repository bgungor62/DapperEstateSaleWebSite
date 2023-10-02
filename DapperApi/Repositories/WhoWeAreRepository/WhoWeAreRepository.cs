using Dapper;
using DapperApi.Dtos.CategoryDtos;
using DapperApi.Dtos.WhoWeAreDtos;
using DapperApi.Models.DapperContext;

namespace DapperApi.Repositories.WhoWeAreRepository
{
    public class WhoWeAreRepository : IWhoWeAreRepository
    {
      private readonly  Context _context;

        public WhoWeAreRepository(Context context)
        {
            _context = context;
        }

        public async void CreateWhoWeAre(CreateWhoAreDetailDto whoAreDetailDto)
        {
            string query = @"INSERT INTO [dbo].[WhoAreDetail]
                                              (Title
                                              ,Subtitle
                                              ,Description
                                              ,Description2
                                              )
                                        VALUES
                                              (@title
                                              ,@subtitle
                                              ,@description
                                              ,@description2
                                              )";
            var parameters = new DynamicParameters();
            parameters.Add("@title", whoAreDetailDto.Title);
            parameters.Add("@subtitle", whoAreDetailDto.Subtitle);
            parameters.Add("@description", whoAreDetailDto.Description);
            parameters.Add("@description2", whoAreDetailDto.Description2);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteWhoWeAre(int id)
        {
            string query = "Update WhoAreDetail set Status=0 where ID=@id";
            var parameters = new DynamicParameters();
            parameters.Add("@id", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultWhoWeAreDetailDto>> GetResultWhoWeAreDetail()
        {
            string query = "select * from WhoAreDetail where Status=1";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultWhoWeAreDetailDto>(query);
                return values.ToList();

            }
        }

        public async Task<GetByWhoWeAreIdDto> GetWhoWeAreId(int id)
        {
            string query = "select * from WhoAreDetail where ID=@id";
            var parameters= new DynamicParameters();
            parameters.Add("@id", id);
            using(var connection = _context.CreateConnection())
            {
                var values=await connection.QueryFirstOrDefaultAsync<GetByWhoWeAreIdDto>(query,parameters);
                return values;
            }


        }

        public async void UpdateWhoWeAre(UpdateWhoWeAreDto updateWhoWeAre)
        {
            string query = "UPDATE WhoAreDetail set  Title=@title,Subtitle=@subtitle,Description=@description,Description2=@description2 where ID=@Id";
            var parameters = new DynamicParameters();
            parameters.Add("@title", updateWhoWeAre.Title);
            parameters.Add("@subtitle", updateWhoWeAre.Subtitle);
            parameters.Add("@description", updateWhoWeAre.Description);
            parameters.Add("@description2", updateWhoWeAre.Description2);
            parameters.Add("@Id", updateWhoWeAre.ID);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
