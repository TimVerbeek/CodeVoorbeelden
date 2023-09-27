using DeSpaakEntity.Data;
using System.Security.Cryptography.Xml;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionstring = "Data Source=Brrodnodig.db";
builder.Services.AddSqlite<BroodNodigContext>(connectionstring);

builder.Services.AddCors(y =>
{
    y.AddPolicy("NoCors", x =>
    {
        
        x.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod();
    });
});


builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles); ;
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

app.UseAuthorization();

app.UseCors("NoCors");

app.MapControllers();

app.Run();

