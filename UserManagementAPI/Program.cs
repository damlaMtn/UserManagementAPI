using UserManagementAPI.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();

var app = builder.Build();

// Use custom logging middleware (demonstrates middleware usage)
app.UseMiddleware<RequestLoggingMiddleware>();

app.MapControllers();

app.Run();
