int[] notas = new int[8];
int total=0;
int aprobado = 0;
int reprobado=0;

Console.Clear();

for(int i=0; i<notas.Length; i++)
{
    try
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine($"Ingresa la nota #{i+1}");
        notas[i] = int.Parse(Console.ReadLine());
        Console.ResetColor();
        total += notas[i];
    }
    catch(FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ERROR. Reingrese los datos");
        Console.ResetColor();
        i--;
        continue;
    }
    if(notas[i] >= 60)
    {
        aprobado++;
    }
    else if(notas[i] < 60)
    {
        reprobado++;
    }
}

double promedio = (double)total/notas.Length;
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("=== REPORTE ===");
Console.WriteLine("El total de aprobados fue: "+ aprobado);
Console.WriteLine("El total de reprobados fue: "+ reprobado);
Console.WriteLine("El promedio general fue: "+promedio);
Console.WriteLine("=== NOTAS APROBADAS ===");
for(int i =0; i<notas.Length; i++)
{
     if(notas[i] >= 60)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(notas[i]);
            Console.ResetColor();
        }
}
Console.ResetColor();