//Ejercicio 5: Analizador de Temperaturas Semanal
double temp = 0;
int frio = 0, templado = 0, caluroso = 0;
Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("=== ANALIZADOR DE TEMPERATURA SEMANAL ===");
Console.ResetColor();
for (int i = 1; i <= 7; i++)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write($"\nIngrese la temperatura para el día {i}: ");
    if (!double.TryParse(Console.ReadLine(), out temp))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" Error: Ingrese un valor numérico válido.");
        Console.ResetColor();
        i--; 
        continue;
    }
    if (temp < -20 || temp > 50)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(" [ALERTA] Sensor fuera de rango (debe estar entre -20 y 50)");
        Console.ResetColor();
        i--; 
        continue;
    }
    if (temp < 15)
    {
        frio++;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Estado: Día frío ❄️");
    }
    else if (temp >= 15 && temp <= 28)
    {
        templado++;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Estado: Día templado 🍃");
    }
    else
    {
        caluroso++;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Estado: Día caluroso 🔥");
    }
    Console.ResetColor();
    switch ((int)temp) 
    {
        case 0:
        case 20:
        case 40:
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" >>> PUNTO DE CONTROL ALCANZADO <<< ");
            Console.ResetColor();
            break;
    }
}
Console.WriteLine("\n-------------------------------");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("       RESUMEN SEMANAL");
Console.WriteLine("-------------------------------");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"Días Fríos: {frio}");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Días Templados: {templado}");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Días Calurosos: {caluroso}");
Console.ResetColor();