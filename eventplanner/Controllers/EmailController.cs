using Microsoft.AspNetCore.Mvc;
using eventplanner.Interfaces;

namespace eventplanner.Controllers
{
    public class EmailController : Controller
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        public IActionResult Send(string Nome, string Espetaculo, string Lugar)
        {
            // Lógica para enviar o e-mail usando o serviço de e-mail
            var body = $"Nome: {Nome}\nEspetáculo: {Espetaculo}\nLugar: {Lugar}";
            _emailService.SendEmail("frango.vitor@me.com", "Detalhes do Bilhete", body);
            return Ok("Email enviado com sucesso.");
        }
    }
}
