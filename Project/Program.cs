using Dal_Repository;
using Bll_Services;
using System.Threading.RateLimiting;
using Dto_Common_Enteties;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(O => O.AddPolicy("AAA", builder =>
{
    builder.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
}));  
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped(typeof(IDalRepository), typeof(ProductDal));
builder.Services.AddScoped(typeof(IProductBll), typeof(ProducrBll));
builder.Services.AddScoped(typeof(ICategory), typeof(CategoryDal));
builder.Services.AddScoped(typeof(ICategoryBll), typeof(CategoryBll));
builder.Services.AddScoped(typeof(ICustomerBll), typeof(CustomerBll));
builder.Services.AddScoped(typeof(ICustomer), typeof(CustomerDal));
builder.Services.AddScoped(typeof(IPurchasesBll), typeof(PurchasesBll));
builder.Services.AddScoped(typeof(IPurchases), typeof(PurchasesDal));
builder.Services.AddScoped(typeof(IPurchaseDetailsBll), typeof(PurchaseDetailsBll));
builder.Services.AddScoped(typeof(IpurchaseDetails), typeof(PurchaseDetailDal));

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

app.UseCors("AAA");
app.Run();

