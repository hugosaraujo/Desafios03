namespace Aula03_ComportamentosComunsAoMenu.Eletroeletronicos;

public class Smartphone : Eletronico
{
    public string Camera { get; set; }

    public override void ExibirEspecificacoes()
    {
        base.ExibirEspecificacoes();
        Console.WriteLine($"Especificacoes de Camera: {Camera}");
    }
}