using System.Numerics;

int[] vector1 = new int[5];
int[] vector2 = new int[5];
int[] vectorR = new int[5];

Console.Clear();

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Ingrese los valores del primer vector");
Console.ResetColor();
for (int i = 0; i < vector1.Length; i++)
{
    try
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Valor {i + 1}: ");
        Console.ResetColor();
        vector1[i] = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ERROR. Dato invalido, reingrese los datos");
        Console.ResetColor();
        i--;
    }
}
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Ingrese los valores del segundo vector");
Console.ResetColor();
for (int i = 0; i < vector2.Length; i++)

{
    try
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Valor {i + 1}: ");
        Console.ResetColor();
        vector2[i] = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ERROR. Dato invalido, reingrese los datos");
        Console.ResetColor();
        i--;
    }
}

for (int i = 0; i < vector1.Length; i++)
{
    vectorR[i] = vector1[i] - vector2[i];
}
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("=== RESTA DE VECTORES ===");
Console.ResetColor();
for (int i = 0; i < vectorR.Length; i++)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"La resta de vectores es {i + 1}: {vectorR[i]}");
    Console.ResetColor();
}
