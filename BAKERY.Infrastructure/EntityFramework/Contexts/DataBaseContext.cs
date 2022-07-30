using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

using BAKERY.Domain.Entites;

namespace BAKERY.Infrastructure.EntityFramework.Contexts
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Bun> Buns { get; set; }

        public DataBaseContext()
        {
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var sqliteConn = new SqliteConnection(@"DataSource = ../bakery.infrastructure/entityframework/database/bakery.db");
            optionsBuilder.UseSqlite(sqliteConn);
        }
    }
}
