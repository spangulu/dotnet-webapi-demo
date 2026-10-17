var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/health", () => Results.Ok(new { status = "ok" }));
app.MapGet("/greet/{name}", (string name) => Results.Ok(new { message = $"Hello, {name}!" }));
app.Run();
