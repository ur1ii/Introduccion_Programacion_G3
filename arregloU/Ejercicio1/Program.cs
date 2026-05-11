int[] temp = new int[7];
int mayor = int.MinValue, menor = int.MaxValue;
int temps = 0;

Console.Clear();

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Ingresa las temperaturas");
Console.ResetColor();
for (int i = 0; i < temp.Length; i++)
{
    try
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"temperatura #{i + 1}");
        Console.ResetColor();
        temp[i] = int.Parse(Console.ReadLine());
        temps += temp[i];
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ERROR, Dato invalido");
        Console.ResetColor();
        i--;
        continue;
    }
    
    if (temp[i] > mayor)
    {
        mayor = temp[i];
    }
    if (temp[i] < menor)
    {
        menor = temp[i];
    }

}
double promedio = (double)temps / temp.Length;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"El promedio de las temperaturas es: {promedio:F2}");
Console.WriteLine("La temperatura mas alta es: " + mayor);
Console.WriteLine("La temperatura mas baja es: " + menor);
Console.ResetColor();

