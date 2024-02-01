using Location.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.;

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<LocationContext>(x=>x.UseSqlServer(builder.Configuration.GetConnectionString("sql")));
    ;
var app = builder.Build();

// Configure the HTTP request pipeline.
if(app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
   
}
app.UseAuthorization();

app.MapControllers();

app.Run();
