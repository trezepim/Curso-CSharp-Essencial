Console.WriteLine("Informe o nome do aluno: ");
string? nome = Console.ReadLine();

Console.WriteLine("Informe a primeira nota: ");
int nota1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Informe a segunda nota: ");
int nota2 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Informe a terceira nota: ");
int nota3 = int.Parse(Console.ReadLine() ?? "0");

double media = (nota1 + nota2 + nota3) / 3.0;

Console.WriteLine("A média do aluno " + (nome ?? "Desconhecido") + " é de: " + media);