namespace Aula02_NovaClasseAvaliacao.Oficina.Modelos;

public class Veiculo
{
    public Veiculo(string modelo, string montadora, int ano)
    {
        Modelo = modelo;
        Montadora = montadora;
        Ano = ano;
    }
    public string Modelo { get; set; }
    public string Montadora { get; set; }
    public int Ano { get; set; }
    public string Placa { get; set; }
}