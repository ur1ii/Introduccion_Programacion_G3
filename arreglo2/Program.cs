// Crea un arreglo de notas de 15 estudiantes, luego calcula el promedio de notas
// y los 3 primeros luagres. no se puede ingresar notas menores a 0 ni mayores a 100
int[] notas = new int[15];
int suma = 0, contErrores = 0;
double promedio = 0;
Console.Clear();
for (int i = 0; i < notas.Length; i++)
{
    if(contErrores >=3)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Demasiados errores, el programa se cerrará");
        Console.ResetColor();
        contErrores = 0;
    }
    try
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Ingrese la notra del estudiante: " + (i + 1));
        Console.ResetColor();
        int nota = int.Parse(Console.ReadLine());
        if(nota < 0 || nota > 100)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            throw new Exception("La nota debe ser entre 0 y 100");
            Console.ResetColor();
        }   
        notas[i] = nota;
        suma += nota;

    }
    catch(ArgumentOutOfRangeException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error: La nota debe ser entre 0 y 100");
        i--; 
        Console.ResetColor();
        contErrores++;
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error: Debe ingresar un número válido");
        i--; 
        Console.ResetColor();
        contErrores++;
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error: " + ex.Message);
        Console.ResetColor();
        i--;
        contErrores++;
    }
}
foreach(int nota in notas)
{
  
}
Console.WriteLine("La suma de las notas es: " + suma);
promedio = suma / notas.Length;
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("El promedio de notas es: " + promedio);
Console.ResetColor();

Array.Sort(notas);
Array.Reverse(notas);
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("=== CUADRO DE HONOR ===");
for(int i=0; i<3; i++)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("El lugar " + (i + 1) + " es: " + notas[i]);
    Console.ResetColor();
}