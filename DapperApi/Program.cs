using DapperApi.Models.DapperContext;
using DapperApi.Repositories.CategoryRepository;
using DapperApi.Repositories.ProductRepository;
using DapperApi.Repositories.ServiceRepository;
using DapperApi.Repositories.WhoWeAreRepository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<Context>();

// Add services to the CategoryRepository.
builder.Services.AddTransient<ICategoryRepository,CategoryRepository>();

//Add services to the ProductRepository 
builder.Services.AddTransient<IProductRepository,ProductRepository>();

//Add services to the WhoWeAreRepository 
builder.Services.AddTransient<IWhoWeAreRepository, WhoWeAreRepository>();

//Add services to the ServiceRepository 

builder.Services.AddTransient<IServiceRepository, ServiceRepository>();
////////////////////

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
