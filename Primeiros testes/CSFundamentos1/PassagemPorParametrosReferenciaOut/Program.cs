Console.WriteLine("Argumentos por referência - out");

Console.WriteLine("Informe o raio do círculo");
double raio = Convert.ToDouble(Console.ReadLine());

Circulo circulo = new();

double perimetro = circulo.CalcularPerimetro(raio);
double area = circulo.CalcularArea(raio);

Console.WriteLine($"Perímetro do círculo: {perimetro}");
Console.WriteLine($"Área do círculo: {area}");

Console.ReadKey();

public class Circulo
{
    public double CalcularArea(double raio)
    {
        double area = Math.PI * Math.Pow(raio, 2);
        return area;
    }
    public double CalcularPerimetro(double raio)
    {
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }
}