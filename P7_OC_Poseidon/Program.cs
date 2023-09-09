using Microsoft.EntityFrameworkCore;
using P7_OC_Poseidon.Data;
using P7_OC_Poseidon.Models.Services.BidListService;
using P7_OC_Poseidon.Models.Services.CurvePointService;
using P7_OC_Poseidon.Models.Services.RatingService;
using P7_OC_Poseidon.Models.Services.RuleNameService;
using P7_OC_Poseidon.Models.Services.TradeService;
using P7_OC_Poseidon.Models.Services.UserService;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("P7_OC_PoseidonContextConnection") ?? throw new InvalidOperationException("Connection string 'P7_OC_PoseidonContextConnection' not found.");

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddScoped<IBidListService, BidListService>();
builder.Services.AddScoped<ICurvePointService, CurvePointService>();
builder.Services.AddScoped<IRatingService, RatingService>();
builder.Services.AddScoped<IRuleNameService, RuleNameService>();
builder.Services.AddScoped<ITradeService, TradeService>();
builder.Services.AddScoped<IUserService, UserService>();

// Data context
builder.Services.AddDbContext<DataContext>();

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
