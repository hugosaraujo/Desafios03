using Aula04_AlternativaParaAnexarSemelhancas.Spam.Interfaces;

namespace Aula04_AlternativaParaAnexarSemelhancas.Spam;

public class Sms : INotificavel
{
    public string NumeroTelefone { get; set; }

    public void EnviarNotificacao()
    {
        Console.WriteLine($"Mensagem enviada por {NumeroTelefone}");
    }
}