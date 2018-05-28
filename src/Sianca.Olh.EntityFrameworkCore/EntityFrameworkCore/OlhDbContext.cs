using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Sianca.Olh.Authorization.Roles;
using Sianca.Olh.Authorization.Users;
using Sianca.Olh.MultiTenancy;
using Sianca.Olh.Events;

namespace Sianca.Olh.EntityFrameworkCore
{
    public class OlhDbContext : AbpZeroDbContext<Tenant, Role, User, OlhDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Event> Events { get; set; }
        public DbSet<EventRegistration> EventRegistrations { get; set; }


        public OlhDbContext(DbContextOptions<OlhDbContext> options)
            : base(options)
        {
        }
    }
}
