using Microsoft.AspNetCore.Mvc;

namespace MyApplicationNet.Controllers
{
    public class EmailSendController : Controller
    {
        private readonly EmailService _emailService;

        public EmailSendController(EmailService emailService)
        {
            _emailService = emailService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SendMail()
        {
            await _emailService.SendEmailAsync(
                "receiver@gmail.com",
                "Test Email",
                "<h2>Hello from ASP.NET Core MVC</h2>");

            return Content("Email Sent");
        }
    }
}
