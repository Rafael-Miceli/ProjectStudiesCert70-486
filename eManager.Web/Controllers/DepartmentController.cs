using System.Linq;
using System.Web.Mvc;
using eManager.Domain;

namespace eManager.Web.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentDataSource _db;

        public DepartmentController(IDepartmentDataSource db)
        {
            _db = db;
        }

        //
        // GET: /Department/

        public ActionResult Detail(int id)
        {
            return View(_db.Departments.Single(dep => dep.Id == id));
        }

    }
}
