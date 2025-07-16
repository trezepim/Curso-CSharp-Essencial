Console.WriteLine("Passando argumentos por referência\n");

int x = 20;

Console.WriteLine($"\nValor do argumento x antes de passar por referência: {x}");

Calculo calculo = new Calculo();
calculo.Dobrar(ref x);

Console.WriteLine($"\nValor do argumento x depois de passar por referência: {x}");

Console.ReadKey();

public class Calculo
{
    public void Dobrar(ref int y)
    {
        y = y * 2;
        Console.WriteLine($"\nValor do parâmetro y no método Dobrar: {y}");
    }
}