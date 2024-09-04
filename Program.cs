var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
var app = builder.Build();
app.UseAuthentication();
app.UseAuthorization();
app.UseStaticFiles();
app.MapControllerRoute(
   name: "Default",
   pattern: "{Controller=CustomerOrders}/{action=Index}");



app.Run();
