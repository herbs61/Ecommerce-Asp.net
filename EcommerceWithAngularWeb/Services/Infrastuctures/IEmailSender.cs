namespace EcommerceWithAngularWeb.Services.Infrastuctures
{
    public class IEmailSender
    {
        Task SendEmailAsync(string email, String subject, string msg);
    }
}
