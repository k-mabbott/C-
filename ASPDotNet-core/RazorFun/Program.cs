var builder = WebApplication.CreateBuilder(args);
// Services must be brought in before you build.
builder.Services.AddControllersWithViews();

var app = builder.Build(); // Build

// Builder code for specific features
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Tells app to listen to this controller
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

// Always at the bottom!
app.Run(); 
