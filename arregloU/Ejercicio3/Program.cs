int[] puntaje = new int[6];
int alto = 0;
int contador =0;

Console.Clear();

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Ingresa los puntajes de cada partida");
Console.ResetColor();
for (int i = 0; i < puntaje.Length; i++)
{
    try
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Puntaje # {i + 1}");
        puntaje[i] = int.Parse(Console.ReadLine());
        Console.ResetColor();

    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ERROR, Reingrese los datos");
        Console.ResetColor();
        i--;
        continue;
    }

    if (i == 0 || puntaje[i] > alto)
    {
        alto = puntaje[i];
    }
    if (puntaje[i] > 500)
    {
        contador++;
    }
}
    Array.Sort(puntaje);

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("El puntaje mas alto fue de; " + alto);
    Console.WriteLine("La cantidad de puntajes mayores a 500 fue: " + contador);
    Console.WriteLine("=== Puntajes ordenados ===");
    Console.ResetColor();
    for (int i = 0; i < puntaje.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(puntaje[i]);
        Console.ResetColor();
    }


