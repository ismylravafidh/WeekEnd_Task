using Microsoft.EntityFrameworkCore;
using WebApplication3.DAL;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
options.UseSqlServer("server=ISMAYIL;database=BB205_WeekEndTask;Trusted_connection=true;Integrated security=true;Encrypt=false")
);

var app = builder.Build();

app.UseAuthorization();

app.MapControllerRoute(
    name: "Default",
    pattern: "{controller}/{action=}/{id?}"
    );

app.UseStaticFiles();

app.Run();