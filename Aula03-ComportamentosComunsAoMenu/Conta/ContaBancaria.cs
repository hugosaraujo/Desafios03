namespace Aula03_ComportamentosComunsAoMenu.Conta;

public class ContaBancaria : Conta
{
    public int TipoConta => 1;

    public override void CalcularSaldo(double saldo)
    {
        Saldo += saldo + (saldo * 0.15);
    }
}