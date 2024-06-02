using eventplanner.Interfaces;

namespace eventplanner.Models
{
    public class EmailService : IEmailService
    {
        public void SendEmail(string to, string subject, string body)
        {
            // Lógica para enviar e-mail
                        Console.WriteLine($"Email enviado para {to} com o assunto: {subject}");
        }
    }
}