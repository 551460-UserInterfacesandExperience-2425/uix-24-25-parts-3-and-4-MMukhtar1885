var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Enable serving static files from wwwroot
app.UseStaticFiles();

app.MapGet("/", async context =>
{
    context.Response.Redirect("/index.html"); // Redirect to your HTML file
});

app.Run();