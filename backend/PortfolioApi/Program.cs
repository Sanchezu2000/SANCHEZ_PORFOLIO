using PortfolioApi.Services;

var builder = WebApplication.CreateBuilder(args);

const string AngularDevCors = "AngularDevCors";

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddSingleton<IPortfolioDataService, PortfolioDataService>();
builder.Services.AddSingleton<IContactMessageStore, InMemoryContactMessageStore>();

builder.Services.AddCors(options =>
{
    options.AddPolicy(AngularDevCors, policy =>
    {
        policy.WithOrigins("http://localhost:4200")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseCors(AngularDevCors);

app.UseAuthorization();

app.MapControllers();

app.Run();
