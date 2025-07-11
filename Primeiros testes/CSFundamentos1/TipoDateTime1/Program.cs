Console.WriteLine("Estrutura DateTime");

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

// criar data específica
DateTime dataHoje = new DateTime(2025, 07, 11);
Console.WriteLine(dataHoje);

// definir as horas
DateTime dataComHora = new DateTime(2025, 07, 11, 14, 0, 0);
Console.WriteLine(dataComHora);

Console.WriteLine();

// extrair informações da data atual
Console.WriteLine(dataHoje.Year);
Console.WriteLine(dataHoje.Month);
Console.WriteLine(dataHoje.Day);
Console.WriteLine(dataHoje.Hour);
Console.WriteLine(dataHoje.Minute);
Console.WriteLine(dataHoje.Second);

// adicionando valores
Console.WriteLine(dataHoje.AddYears(5));

Console.ReadKey();