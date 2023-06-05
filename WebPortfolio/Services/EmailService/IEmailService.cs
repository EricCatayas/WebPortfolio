namespace WebPortfolio.Services.EmailService
{
    public interface IEmailService
    {
        public Task<bool> SendEmail(string recipientEmail, string subject, string body);
    }
}
