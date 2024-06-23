using Aula04_AlternativaParaAnexarSemelhancas.Spam.Interfaces;

namespace Aula04_AlternativaParaAnexarSemelhancas.Spam;

public class Email : INotificavel
{
    public string? EnderecoEmail { get; set; }
    public string? Provedor { get; set; }
    public string EmailCompleto => $"{EnderecoEmail}@{Provedor}.com";


    public void EnviarNotificacao()
    {
        Console.WriteLine($"Mensagem enviada por {EmailCompleto}");
    }
}