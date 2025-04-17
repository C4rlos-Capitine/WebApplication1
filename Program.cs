using Microsoft.EntityFrameworkCore;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MeuDbContext>(options =>
    options.UseSqlServer("Data Source=FALCAO\\SQLEXPRESS16;Initial Catalog=WEBAPP;Integrated Security=True;Persist Security Info=False;Pooling=False;Encrypt=False;"));//Configuration.GetConnectionString("DefaultConnection")


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
