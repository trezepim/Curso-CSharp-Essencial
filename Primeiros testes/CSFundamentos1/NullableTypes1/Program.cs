Console.WriteLine("Nullable Types");

int? i = null;
double? j = null;
bool? k = null;

Console.WriteLine(i);
Console.WriteLine(j);
Console.WriteLine(k);

int? a = null;
int b = a ?? 0;

Console.WriteLine(b);

int? x = 4;
int y = 3;
int? z = x * y;

Console.WriteLine(z);

int? p = 100;

if (p.HasValue)
{
    Console.WriteLine($"p = {p.Value}");
}
else
{
    Console.WriteLine("p é nulo");
}

Console.ReadKey();