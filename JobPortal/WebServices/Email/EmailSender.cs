using Microsoft.AspNetCore.Identity.UI.Services;

namespace JobPortal.WebServices.Email
{
    public class EmailSender : IEmailSender
    {
        // todo: реалізувати сервіс розсилки ел.листів 
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            await Task.CompletedTask;
        }
    }
}
