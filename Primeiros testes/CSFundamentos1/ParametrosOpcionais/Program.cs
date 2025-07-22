Console.WriteLine("Parâmetros opcionais");

Console.WriteLine("Informe o destino: ");
var destino = Console.ReadLine();

Console.WriteLine("Informe o título: ");
var titulo = Console.ReadLine();

Console.WriteLine("Informe o assunto: ");
var assunto = Console.ReadLine();

Email email = new();

email.Enviar(destino);
email.Enviar("teste@email.com");

Console.ReadKey();

public class Email
{
    public void Enviar(string destino, string titulo = "Sem título", string assunto = "Sem assunto")
    {
        Console.WriteLine($"Para {destino} - {titulo} \nAssunto: {assunto}");
    }
}