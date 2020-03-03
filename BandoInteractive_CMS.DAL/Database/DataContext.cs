using BandoInteractive_CMS.Entity.Entities;
using System;
using System.Data.Entity;

namespace BandoInteractive_CMS.DAL.Database
{
    public class DataContext : DbContext
    {
        public DataContext() : base(nameOrConnectionString: "MSSQL-Link")
        {
            //https://stackoverflow.com/a/29743758/10821635
            var type = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
            if (type == null)
                throw new Exception("Do not remove, ensures static reference to System.Data.Entity.SqlServer");
        }

        public DbSet<Layout> Layouts { get; set; }
        public DbSet<Page> Pages { get; set; }
    }
}
