
using System.Diagnostics;

/// Almacenar 10 edades sen un arreglo, luego calcular el promedio de edades, el maximo
/// y el minimo.
int[] edades = new int[10]; 

//Pedir edades 
for (int i = 0; i < edades.Length; i++)
{
    try
    {
        Console.WriteLine($"Ingrese la edad {i + 1}: ");
        edades[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {   
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
        i--;
        Console.ResetColor();
    }
int suma = 0, maximo = edades[0], minimo = edades[0];
    foreach (int edad in edades)
    {
        suma += edad;
        if (edad > maximo)
        {
            maximo = edad;
        }
        if (edad < minimo || minimo == 0)
        {
            minimo = edad;
        }
        double promedio = (double)suma / edades.Length;
Console.WriteLine("El promedio de edades es: " + promedio);
Console.WriteLine("La edad máxima es: " + maximo);
Console.WriteLine("La edad mínima es: " + minimo);
    }
}
