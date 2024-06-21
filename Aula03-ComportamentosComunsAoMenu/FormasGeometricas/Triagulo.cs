using Aula03_ComportamentosComunsAoMenu.FormasGeometricas.Interfaces;

namespace Aula03_ComportamentosComunsAoMenu.FormasGeometricas;

public class Triagulo : ICalculavel
{
    public Triagulo(double valorBase, double altura)
    {
        Base = valorBase;
        Altura = altura; 
    }
    public double Base { get; set; }
    public double Altura { get; set; }
    
    public double CalcularArea()
    {
        double area = Base * Altura;
        return area;
    }
}