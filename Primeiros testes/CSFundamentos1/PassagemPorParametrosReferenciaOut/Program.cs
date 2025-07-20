Console.WriteLine("Argumentos por referência - out");

Console.WriteLine("Informe o raio do círculo");
double raio = Convert.ToDouble(Console.ReadLine());

Circulo circulo = new();

double perimetro = circulo.CalculaAreaPerimetro(raio, out double area);

Console.WriteLine($"Perímetro do círculo: {perimetro}");
Console.WriteLine($"Área do círculo: {area}");

Console.ReadKey();

public class Circulo
{
    public double CalculaAreaPerimetro(double raio, out double area)
    {
        area = Math.PI * Math.Pow(raio, 2);
        double perimetro = 2 * Math.PI * raio;

        return perimetro;
    }
}