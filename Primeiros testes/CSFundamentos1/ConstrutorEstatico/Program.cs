Console.WriteLine("Construtor estático");

Pessoa p1 = new(19, "Rafael");

Console.WriteLine(p1.Nome + " - " + p1.Idade);
Console.WriteLine("Idade mínima: " + Pessoa.idadeMinima);

Console.ReadKey();

public class Pessoa
{
    public static int idadeMinima;

    public int Idade { get; set; }
    public String Nome { get; set; } = string.Empty;

    public Pessoa(int idade, string nome)
    {
        Console.WriteLine("\nExecutando o construtor parametrizado");
        Idade = idade;
        Nome = nome;
    }
    public Pessoa()
    {}

    static Pessoa()
    {
        Console.WriteLine("\nExecutando o construtor estático");
        Console.WriteLine("\nInicializando o campo idadeMinima");
        idadeMinima = 18;

    }
}