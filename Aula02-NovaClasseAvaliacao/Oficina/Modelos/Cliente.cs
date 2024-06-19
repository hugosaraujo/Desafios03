namespace Aula02_NovaClasseAvaliacao.Oficina.Modelos;

public class Cliente
{
    public Cliente(string nome, Veiculo carro)
    {
        Nome = nome;
        Carro = carro; 
    }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Telefone { get; set; }
    public string Endereco { get; set; }
    public Veiculo Carro { get; set; }
}