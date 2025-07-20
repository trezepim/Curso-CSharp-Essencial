Console.WriteLine("Argumentos nomeados");

Email email = new();

email.Enviar(titulo: "Urgente", destino: "teste@email.com", assunto: "Reunião de orçamento");

Console.ReadKey();

public class Email
{
    public void Enviar(string destino, string titulo, string assunto)
    {
        Console.WriteLine($"Para {destino} - {titulo} \nAssunto: {assunto}");
    }
}