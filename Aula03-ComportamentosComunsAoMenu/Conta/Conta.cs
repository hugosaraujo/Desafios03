namespace Aula03_ComportamentosComunsAoMenu.Conta;

public class Conta
{
    public int TipoConta { get; set; }
    public string Titular { get; set; }
    public string NumeroConta { get; set; }
    public int Agencia { get; set; }
    public double Saldo { get; set; }

    public virtual void CalcularSaldo(double saldo)
    {
        Saldo += saldo;
    }
}