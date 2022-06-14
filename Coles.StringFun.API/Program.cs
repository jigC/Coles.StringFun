using Coles.StringFun.Application;
using Coles.StringFun.Definitions;
using Coles.StringFun.Domain;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IArrayFunctions<string>, ArrayFunctions<string>>()
	.AddTransient<IStringFunctions, StringFunctions>()
	.AddTransient<IStringRequestHandler, StringRequestHandler>()
	.AddTransient<IArrayRequestHandler<string>, ArrayRequestHandler<string>>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
