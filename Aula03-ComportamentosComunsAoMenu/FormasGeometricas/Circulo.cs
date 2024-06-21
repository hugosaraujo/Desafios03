using Aula03_ComportamentosComunsAoMenu.FormasGeometricas.Interfaces;

namespace Aula03_ComportamentosComunsAoMenu.FormasGeometricas;

public class Circulo : ICalculavel
{
    public Circulo(double raio)
    {
        Raio = raio;
    }
    public double Raio { get; set; }

    public double CalcularArea()
    {
        double area = Math.PI * (Raio*Raio);
        return area;
    }
}