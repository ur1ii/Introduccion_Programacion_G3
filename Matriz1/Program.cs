/// Matriz 3x3

Console.Clear();

int[,] matriz = new int[3, 3];
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Ingrese los elementos de la matriz 3x3");
Console.ResetColor();
for (int f = 0; f < 3; f++)
{
    for (int c = 0; c < 3; c++)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Elemento [{f},{c}]");
        Console.ResetColor();
        matriz[f, c] = int.Parse(Console.ReadLine()!);
        
    }

}
Console.WriteLine("Mostrar matriz");
for (int f = 0; f < 3; f++)
{
    for(int c = 0; c <3; c++)
    {
        if(matriz[f,c] % 2 == 0 && matriz[f, c] >0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(matriz[f, c] + "\t");
            Console.ResetColor();
        }
        else if(matriz[f,c] % 2 != 0 && matriz[f, c] >0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(matriz[f, c] + "\t");
            Console.ResetColor();
        }
        else if(matriz[f,c] <0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(matriz[f, c] + "\t");
            Console.ResetColor();
        }
        
    }
    Console.WriteLine();
}
Console.ResetColor();
Console.WriteLine("\nPresione cualquier tecla para salir...");
Console.ReadKey();