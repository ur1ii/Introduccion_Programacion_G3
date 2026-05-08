using System.Numerics;

int[] Vector1 = new int[5];
int[] vector2 = new int[5];
int[] vectorsuma = new int[5];

Console.Clear();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Ingrese los valores del primer vector");
Console.ResetColor();
for (int i = 0; i < Vector1.Length; i++)
{
    try
    {
        Console.WriteLine($"Valor {i + 1}: ");
        Vector1[i] = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ERROR. dato invalido, ingrese un numero entero");
        i--;
        Console.ResetColor();
    }
}

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Ingrese los valores del segundo vector");
Console.ResetColor();
for (int i = 0; i < vector2.Length; i++)
{
    try
    {
        Console.WriteLine($"Valor {i + 1}:");
        vector2[i] = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ERROR. dato invalido, ingrese un numero entero");
        i--;
        Console.ResetColor();
    }
}

for(int i=0; i<Vector1.Length; i++)
{
    vectorsuma[i] = Vector1[i] + vector2[i];
}
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"La suma de los vectores es: ");
Console.ResetColor();
for(int i = 0; i<vectorsuma.Length; i++)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Valor {i +1}: {vectorsuma[i]}");
    Console.ResetColor();
}
