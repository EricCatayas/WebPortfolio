using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using WebPortfolio.Data;
using WebPortfolio.Services.EmailService;
using WebPortfolio.ViewModels;

namespace WebPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmailService _emailService;
        private readonly IConfiguration _configuration;
        public HomeController(IEmailService emailService, IConfiguration configuration)
        {
            _emailService = emailService;
            _configuration = configuration;
        }
        [Route("/")]
        public IActionResult Index()
        {
            var workExperiences = WorkExperienceData.Experiences;
            workExperiences.Reverse();
            string[] styles = { "position: absolute; left: 0%; top: 220.8px;", "position: absolute; left: 50%; top: 0px;", "position: absolute; left: 50%; top: 598.75px;" };
            var projects = ProjectData.Projects.Take(3).Select((project, index) => new ProjectVM(project, styles[index])).ToList();
            var viewModel = new HomeVM
            {
                WorkExperiences = workExperiences,
                Projects = projects
            };
            return View("Index", viewModel);
        }
        [Route("/v1")]
        public IActionResult V1()
        {
            return View("Old");
        }
        [Route("/about")]
        public IActionResult About() {
            return View("About");
        }
        [Route("/contact")]
        public IActionResult Contact()
        {
            return View("Contact");
        }
        [Route("[controller]/[action]")]
        [HttpPost]
        public async Task<IActionResult> SendEmail(string recipientEmail, string name, string body)
        {
            bool success = await _emailService.SendEmail(recipientEmail, name, body);
            return success ? StatusCode(200) : StatusCode(500);
        }
    }

}
