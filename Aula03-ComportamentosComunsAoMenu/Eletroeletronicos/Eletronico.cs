namespace Aula03_ComportamentosComunsAoMenu.Eletroeletronicos;

public class Eletronico
{
    public string TipoProduto { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }

    public virtual void ExibirEspecificacoes()
    {
        Console.WriteLine($"Tipo do Produto: {TipoProduto}");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Preço: {Preco}");
    }
}