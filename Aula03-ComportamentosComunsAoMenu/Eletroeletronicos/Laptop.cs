namespace Aula03_ComportamentosComunsAoMenu.Eletroeletronicos;

public class Laptop : Eletronico
{
    public string Ram { get; set; }
    public string Hd { get; set; }

    public override void ExibirEspecificacoes()
    {
        base.ExibirEspecificacoes();
        Console.WriteLine($"Memoria RAM: {Ram}");
        Console.WriteLine($"Espaço Interno: {Hd}");
    }
}