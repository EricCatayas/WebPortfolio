using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using WebPortfolio.Services.EmailService;

namespace WebPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmailService _emailService;
        private readonly IConfiguration _configuration;
        public HomeController(IEmailService emailService, IConfiguration configuration)
        {
            //TODO Configure email in user secrets
            _emailService = emailService;
            _configuration = configuration;
        }
        [Route("/")]
        public IActionResult Index()
        {
            return View();
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
