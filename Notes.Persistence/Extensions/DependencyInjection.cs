using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Notes.Application.Interfaces;
using Notes.Persistence.NotesDb;

namespace Notes.Persistence.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<NotesDbContext>(x => x.UseSqlite(configuration["DbConnection"]));
        services.AddScoped<INotesDbContext>(x => x.GetService<NotesDbContext>() ?? throw new NullReferenceException($"{nameof(NotesDbContext)} is null"));
        return services;
    }
}