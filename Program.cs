using nutrition_planner.Data;
using Microsoft.EntityFrameworkCore;



//database connection string
var builder = WebApplication.CreateBuilder(args);
string Host = builder.Configuration["Host"];
string Database = builder.Configuration["Database"];
string Username = builder.Configuration["Username"];
string Password = builder.Configuration["Password"];
string ConnectionString = $"Host={Host};Database={Database};Username={Username};Password={Password};";




// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<FoodModelContext>(
    opt => opt.UseNpgsql(ConnectionString));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();



// Configure the HTTP request pipeline.
var app = builder.Build();

//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
app.UseSwaggerUI();
//}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();



app.Run();
