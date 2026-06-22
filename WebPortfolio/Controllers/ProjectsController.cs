using Microsoft.AspNetCore.Mvc;

namespace WebPortfolio.Controllers
{
    public class ProjectsController : Controller
    {
        [Route("/projects")]
        public IActionResult Index()
        {
            var projects = Data.ProjectData.Projects;

            return View(projects);
        }
    }
}
