using System.Threading.Tasks;

namespace f1project.webui.EmailServices
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email,string subject,string htmlMessage);
    }
}