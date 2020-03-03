namespace BandoInteractive_CMS.DAL.Migrations
{
    using BandoInteractive_CMS.Entity.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BandoInteractive_CMS.DAL.Database.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BandoInteractive_CMS.DAL.Database.DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            try
            {
                if (!context.Layouts.Any())
                    context.Layouts.Add(
                        new Layout() { Id = 1, Name = "MyLayout1", Path = "~/Views/Shared/MyLayouts/_MyLayout1.cshtml" }
                    );
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                context.SaveChanges();
            }

            try
            {
                if (!context.Pages.Any())
                    context.Pages.Add(
                        new Page() { Name = "Home", Content = "This is Home Page!", URL = "/HomePage", ParentPageId = 1, LayoutId = 1 }
                    );
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                context.SaveChanges();
            }

        }
    }
}
