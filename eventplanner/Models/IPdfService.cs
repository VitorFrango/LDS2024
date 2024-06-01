using System.IO;
using eventplanner.Models;

/*Esta interface permite que o controller nao chamasse o model diretamente para gerar o PDF. 
A dependencia que o controller tinha do model deixa de existir,ou seja, torna o progama mais modular e facil de manter.
*/

namespace eventplanner.Interfaces
{
    public interface IPdfService
    {
        string? Nome { get; set; }
        string? Espetaculo { get; set; }
        string? Lugar { get; set; }
        string FontName { get; set; }

        // Eventos
        event PdfGeneratedHandler PdfGenerated;
        void GerarPdf(IPdfService model);
        void OnPdfGenerated(PdfGeneratedEventArgs e);
    }
}
