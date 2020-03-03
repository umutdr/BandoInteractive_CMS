using BandoInteractive_CMS.Entity.Entities;
using System.Data.Entity;

namespace BandoInteractive_CMS.DAL.Database
{
    public class DataContext : DbContext
    {
        public DataContext() : base(nameOrConnectionString: "MSSQL-Link")
        {

        }

        public DbSet<Layout> Layouts { get; set; }
        public DbSet<Page> Pages { get; set; }
    }
}
