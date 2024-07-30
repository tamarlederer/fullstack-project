using DataContext;
using Repository.Interfaces;
using Service;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// הוספת שירותים למכולה
builder.Services.AddControllersWithViews();
builder.Services.AddService();
builder.Services.AddDbContext<IContext, Db>();

// הגדרת מדיניות CORS
var policy = "policy";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: policy, policyBuilder =>
    {
        policyBuilder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

// הוספת Swagger לתיעוד API
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// הגדרת ה-HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My Db");
        c.RoutePrefix = string.Empty; // כדי להציג את Swagger UI ב-URL הבסיסי
    });
}

app.UseHttpsRedirection();
app.UseCors(policy);
app.UseAuthorization();
app.MapControllers();
app.Run();
