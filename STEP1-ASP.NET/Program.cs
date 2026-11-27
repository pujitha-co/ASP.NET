using EmployeeManagementAPI.Services;
using STEP1_ASP.NET.Interface;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

//builder.Services.AddSingleton<EmployeeService>();

// Dependency Injection Registration
builder.Services.AddScoped<IEmployeeService, EmployeeService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
     
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Employee API v1");
    });
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();