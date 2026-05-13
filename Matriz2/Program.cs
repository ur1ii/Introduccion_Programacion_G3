int[,] matriz = new int[5, 5];
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Ingrese los datos de la matriz 5x5");
Console.ResetColor();
for(int f=0; f<5; f++)
{
    for(int c=0; c<5; f++)
    {
        try
        {   
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"Elemento {matriz[f, c]}");
            Console.ResetColor();
            matriz[f, c] = int.Parse(Console.ReadLine());
        }
        catch(FormatException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ERROR, reingrese los datos");
            Console.ResetColor();
        }
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine(" === Mostrar matriz ===");
        Console.ResetColor();
        for(int f=0; f<5; f++)
        {

            for( int c=0; c<5; c++)
            {
                Console.WriteLine("Su numero esta en la matriz");
            }
        }
    }
}
