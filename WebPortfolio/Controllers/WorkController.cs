using Microsoft.AspNetCore.Mvc;
using WebPortfolio.Data;
using WebPortfolio.Models;

namespace WebPortfolio.Controllers
{

    public class WorkController : Controller
    {
        [Route("/work")]
        public IActionResult Index()
        {
            var workExperiences = WorkExperienceData.Experiences;
            return View(workExperiences);
        }
        [Route("/work/{id}")]
        public IActionResult Details(string id)
        {
            var workExperiences = WorkExperienceData.Experiences;
            var workExperience = workExperiences.FirstOrDefault(w => w.Id == id);
            if (workExperience == null)
            {
                return NotFound();
            }
            return View(workExperience);
        }
    }
}
