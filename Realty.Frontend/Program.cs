

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
var app = builder.Build();
app.UseWebpackDevMiddleware();
app.UseStaticFiles();
app.UseRouting();

//app.MapGet("/", () => "Hello World!");
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
    endpoints.MapControllerRoute(
        name: "api",
        pattern: "api/{controller=Default}/{action=Index}/{id?}"
        );
    endpoints.MapFallbackToController("Index", "Home");
});

app.Run();
