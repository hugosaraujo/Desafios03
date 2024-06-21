namespace Aula03_ComportamentosComunsAoMenu.Eletroeletronicos;

public class Tablet : Eletronico
{
    public string EspecificacaoChip { get; set; }

    public override void ExibirEspecificacoes()
    {
        base.ExibirEspecificacoes();
        Console.WriteLine($"InfoChip: {EspecificacaoChip}");
    }
}