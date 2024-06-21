using Aula03_ComportamentosComunsAoMenu.FormasGeometricas.Interfaces;

namespace Aula03_ComportamentosComunsAoMenu.FormasGeometricas;

public class Quadrado : ICalculavel
{
    public Quadrado(double lado)
    {
        Lado = lado;
    }
    public double Lado { get; set; }
    
    public double CalcularArea()
    {
        double area = Lado * Lado;
        return area; 
    }
}