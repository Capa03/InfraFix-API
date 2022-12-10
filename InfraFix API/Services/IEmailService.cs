using InfraFix_API.Models;

namespace InfraFix_API.Services
{
    public interface IEmailService
    {
        void SendEmail(EmailDTO request);
    }
}
