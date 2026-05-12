
Console.Clear();

int[] categorias = new int[5];
int libros =0;
int mayor=0;
double promedio=0;


for(int i=0; i < categorias.Length; i++)
{
    try
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine($"Ingrese la cantidad de libros en la categoria #{i+1}");
        categorias[i] = int.Parse(Console.ReadLine());
        Console.ResetColor();
        libros += categorias[i];
        
    }
    catch(FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ERROR, Reingrese los datos");
        Console.ResetColor();
        i--;
        continue;
    }

    if(categorias[i] > mayor)
    {
        mayor = categorias[i];
    }

    promedio = (double)libros/categorias.Length;
}

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("=== REPORTE ===");
Console.WriteLine("El total de libros vendidos fue de: "+libros);
Console.WriteLine("La categoria con mayor venta fue: "+mayor);
Console.WriteLine("El promedio de venta fue: "+promedio);
Console.ResetColor();
