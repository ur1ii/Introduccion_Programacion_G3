int[,] matriz = new int[5, 5];

Console.Clear();

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Ingrese los datos de la matriz 5x5");
Console.ResetColor();

for (int f = 0; f < 5; f++)
{
    for (int c = 0; c < 5; c++)
    {
        
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($"Elemento [{f},{c}]: ");
                Console.ResetColor();
                matriz[f, c] = int.Parse(Console.ReadLine());
                
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR, ingrese un número válido.");
                Console.ResetColor();
            }
        }
    }
}

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write("Ingrese el número que desea buscar en la matriz: ");
Console.ResetColor();
int numeroBuscar = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine(" === Resultado de la búsqueda ===");
Console.ResetColor();

for (int f = 0; f < 5; f++)
{
    for (int c = 0; c < 5; c++)
    {
        if (matriz[f, c] == numeroBuscar)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        Console.Write(matriz[f, c] + "\t"); 
    }
    Console.WriteLine(); 
}
Console.ResetColor();
Console.WriteLine("\nPresione cualquier tecla para salir...");
Console.ReadKey();