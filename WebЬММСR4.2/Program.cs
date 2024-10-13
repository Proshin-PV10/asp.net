var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
