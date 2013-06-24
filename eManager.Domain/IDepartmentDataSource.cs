using System.Collections.Generic;

namespace eManager.Domain
{
    public interface IDepartmentDataSource
    {
        IEnumerable<Employee> Employees { get; }
        IEnumerable<Department> Departments { get; }

        void Save();
    }
}
