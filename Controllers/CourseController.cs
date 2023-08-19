using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Details(int? id)
        {
            if(id==null)
            {
                //return Redirect("/Course/List");
                return RedirectToAction("List","Course");
            }

            if (Repository.Courses.FirstOrDefault(c => c.Id == id) == null)
            {
                return NotFound();
            }

            Course? kurs = Repository.GetById(id);
            return View(kurs);
        }

        public IActionResult List()
        {
            return View(Repository.Courses);
        }
    }
}
