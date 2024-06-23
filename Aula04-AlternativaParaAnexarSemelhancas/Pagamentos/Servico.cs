using System.Security.AccessControl;
using Aula04_AlternativaParaAnexarSemelhancas.Pagamentos.Interfaces;

namespace Aula04_AlternativaParaAnexarSemelhancas.Pagamentos;

public class Servico : IPagavel
{
    public string TipoServico { get; set; }
    public int HorasDedicadas { get; set; }
    public double ValorHora { get; set; }
    
    public double CalcularPagamento()
    {
        return ValorHora * HorasDedicadas;
    }
}