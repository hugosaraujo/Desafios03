namespace Aula02_NovaClasseAvaliacao.Oficina.Modelos;

public class Atendimento
{
    public Atendimento(Mecanico mecanico, Veiculo veiculo)
    {
        Mecanico = mecanico;
        Veiculo = veiculo; 
    }
    public Mecanico Mecanico { get; set; }
    public Veiculo Veiculo { get; set; }
    public string DescricaoServico { get; set; }
    public double Valor { get; set; }
}