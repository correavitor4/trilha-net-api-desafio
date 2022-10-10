using Microsoft.EntityFrameworkCore;
using TrilhaApiDesafio.Context;

namespace TrilhaApiDesafio.Services;

public static class DatabaseManagementService
{
    public static void MigrationInitialization(this IApplicationBuilder app)
    {
        using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
        {
            var context = serviceScope.ServiceProvider.GetRequiredService<OrganizadorContext>();
            context.Database.Migrate();
        }
    }   
}