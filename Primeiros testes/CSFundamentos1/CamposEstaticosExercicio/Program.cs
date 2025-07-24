Console.WriteLine("Campos estáticos - exercício\n");

ContaCorrente c1 = new();
c1.Conta = 101;
c1.Nome = "Maria";

ContaCorrente c2 = new();
c2.Conta = 102;
c2.Nome = "João";

ContaCorrente.Juros = 4.10f;

Console.WriteLine($"Cliente: {c1.Nome}\nJuros anual: {c1.JurosAnual()}\n");
Console.WriteLine($"Cliente: {c2.Nome}\nJuros anual: {c2.JurosAnual()}\n");

Console.ReadKey();

public class ContaCorrente
{
    public int Conta;
    public string? Nome;
    public static float Juros;

    public float JurosAnual()
    {
        return Juros * 12;
    }
}