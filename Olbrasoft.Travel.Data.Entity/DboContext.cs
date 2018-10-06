using Olbrasoft.Travel.Data.Entity.Model;
using Olbrasoft.Travel.Data.Entity.Model.Configuration;
using System.Data.Entity;

namespace Olbrasoft.Travel.Data.Entity
{
    public class DboContext : DbContext, IDbo
    {
        public IDbSet<User> Users { get; set; }
        public IDbSet<LogOfImport> LogsOfImports { get; set; }

        public DboContext() : base("name=Travel")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(typeof(CreationInfoConfiguration<>).Assembly);
        }
    }
}