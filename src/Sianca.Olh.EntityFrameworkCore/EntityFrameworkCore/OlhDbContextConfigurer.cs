using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Sianca.Olh.EntityFrameworkCore
{
    public static class OlhDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<OlhDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<OlhDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
