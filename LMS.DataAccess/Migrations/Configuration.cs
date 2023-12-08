namespace LMS.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LMS.DataAccess.DataAccessLayer.LibraryManagementSystemContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "LMS.DataAccess.DataAccessLayer.LibraryManagementSystemContext";
        }

        protected override void Seed(DataAccessLayer.LibraryManagementSystemContext context)
        {            

        }
    }
}
