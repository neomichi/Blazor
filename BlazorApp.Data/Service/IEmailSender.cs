using System.Threading.Tasks;

namespace BlazorApp.Data.Service
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string htmlMessage);
    }
}