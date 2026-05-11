//Ventas de una tienda

int[] ventas = new int[7];
int total=0;
int menor =int.MaxValue;
int diaS=0;

Console.Clear();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Ingresa las ventas del dia");
Console.ResetColor();
for(int i=0; i < ventas.Length; i++)
{
   try
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Venta #{i+1}");
        ventas[i] = int.Parse(Console.ReadLine());
        Console.ResetColor();
        total += ventas[i];
    }
    catch(FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ERROR. Reingrese los datos");
        Console.ResetColor();
        i--;
    }

    if(ventas[i] > 150)
    {
        diaS++;
    }
    if(ventas[i] < menor)
    {
        menor = ventas[i];
    }
    
}
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("EL total vendido fue: "+total);
    Console.WriteLine("Dias en los que las ventas superaron 150: "+diaS);
    Console.WriteLine("La venta mas baja registrada fue: "+menor);
    Console.ResetColor();