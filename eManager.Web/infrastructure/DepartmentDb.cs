using System.Collections.Generic;
using System.Data.Entity;
using eManager.Domain;

namespace eManager.Web.infrastructure
{
    public class DepartmentDb: DbContext, IDepartmentDataSource
    {
        public DepartmentDb()
            : base("DefaultConnection")
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }



        IEnumerable<Employee> IDepartmentDataSource.Employees
        {
            get { return Employees; }
        }

        IEnumerable<Department> IDepartmentDataSource.Departments
        {
            get { return Departments; }
        }


        void IDepartmentDataSource.Save()
        {
            SaveChanges();
        }
    }
}