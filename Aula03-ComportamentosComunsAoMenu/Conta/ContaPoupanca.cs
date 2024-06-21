namespace Aula03_ComportamentosComunsAoMenu.Conta;

public class ContaPoupanca : Conta
{
    public int TipoDeConta => 2;

    public override void CalcularSaldo(double saldo)
    {
        Saldo += saldo * (saldo * 0.05); 
    }
}