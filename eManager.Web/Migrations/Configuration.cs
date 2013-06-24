using System.Web.Security;
using eManager.Domain;

namespace eManager.Web.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<infrastructure.DepartmentDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(infrastructure.DepartmentDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Departments.AddOrUpdate(department => department.Name,
                new Department(){Name = "Engeneering"},
                new Department(){Name = "Sales"},
                new Department(){Name = "Shipping"},
                new Department(){Name = "Human Resources"});

            Roles.Enabled = true;

            if (!Roles.RoleExists("Admin"))
            {
                Roles.CreateRole("Admin");
            }

            if (Membership.GetUser("rafael") != null) return;

            Membership.CreateUser("rafael", "fluffybunny");
            Roles.AddUserToRole("rafael", "Admin");
        }
    }
}
