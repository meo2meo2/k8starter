var builder = WebApplication.CreateBuilder(args);

// Google Cloud Run sets the PORT environment variable to tell this
// process which port to listen to.
var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
var url = $"http://0.0.0.0:{port}";
var target = Environment.GetEnvironmentVariable("TARGET") ?? "World";

var app = builder.Build();

app.MapGet("/", () => $"Hello {target}!");

app.Run(url);