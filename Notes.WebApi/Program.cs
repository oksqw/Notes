using Notes.Application.Extensions;
using Notes.Persistence.Extensions;
using Notes.Persistence.NotesDb;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;
var environment = builder.Environment;

services.AddApplication();
services.AddPersistence(configuration);
services.AddControllers();

var app = builder.Build();
using var scope = app.Services.CreateScope();

try
{
    var context = scope.ServiceProvider.GetRequiredService<NotesDbContext>();
    NotesDbInitialized.Initialize(context);
}
catch (Exception e)
{
    Console.WriteLine(e);
}

if (environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();
app.UseHttpsRedirection();
app.MapControllers();

app.Run();