using System.Linq;
using System.Web.Mvc;
using eManager.Domain;
using eManager.Web.Models;

namespace eManager.Web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class EmployeeController : Controller
    {
        private readonly IDepartmentDataSource _db;

        public EmployeeController(IDepartmentDataSource db)
        {
            _db = db;
        }
        //
        // GET: /Employee/

        [HttpGet]
        public ActionResult Create(int departmentId)
        {
            var model = new CreateEmployeeViewModel {DepartmentId = departmentId};

            return View();
        }

        [HttpPost]
        public ActionResult Create(CreateEmployeeViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var department = _db.Departments.Single(dep => dep.Id == viewModel.DepartmentId);
                var employee = new Employee() {Name = viewModel.Name};

                department.Employees.Add(employee);

                _db.Save();

                return RedirectToAction("Detail", "Department", new {Id = viewModel.DepartmentId});
            }

            return View(viewModel);
        }
    }
}
