using Aula04_AlternativaParaAnexarSemelhancas.Pagamentos.Interfaces;

namespace Aula04_AlternativaParaAnexarSemelhancas.Pagamentos;

public class Produto : IPagavel
{
    public string Nome { get; set; }
    public int Quantidade { get; set; }
    public double Valor { get; set; }
    
    public double CalcularPagamento()
    {
        return Valor * Quantidade;
    }
}