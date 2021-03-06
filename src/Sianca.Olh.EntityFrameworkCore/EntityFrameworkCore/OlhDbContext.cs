﻿using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Sianca.Olh.Authorization.Roles;
using Sianca.Olh.Authorization.Users;
using Sianca.Olh.MultiTenancy;

namespace Sianca.Olh.EntityFrameworkCore
{
    public class OlhDbContext : AbpZeroDbContext<Tenant, Role, User, OlhDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public OlhDbContext(DbContextOptions<OlhDbContext> options)
            : base(options)
        {
        }
    }
}
