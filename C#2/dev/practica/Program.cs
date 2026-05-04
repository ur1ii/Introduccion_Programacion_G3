using System;
int num1, num2, total, opcion;
Console.Clear();
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("=== Seleccione la accion deseada ===");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Salir");
    if (!int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.WriteLine("Entrada inválida. Intente nuevamente.\n");
        continue;
    }
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingrese el primer numero");
            if (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Número inválido.\n");
                continue;
            }

            Console.WriteLine("Ingrese el segundo numero");
            if (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Número inválido.\n");
                continue;
            }

            if (num1 > 0 && num2 > 0)
            {
                total = num1 + num2;
                Console.WriteLine($"El total de su suma es: {total}\n");
            }
            else
            {
                Console.WriteLine("ERROR. Ambos números deben ser mayores que 0.\n");
            }
            break;
        case 2:
            Console.WriteLine("Ingrese el primer numero");
            if (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Número inválido.\n");
                continue;
            }
            Console.WriteLine("Ingrese el segundo numero");
            if (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Número inválido.\n");
                continue;
            }
            if (num1 > 0 && num2 > 0)
            {
                total = num1 - num2;
                Console.WriteLine($"El total de su resta es: {total}\n");
            }
            else
            {
                Console.WriteLine("ERROR. Ambos números deben ser mayores que 0.\n");
            }
            break;
        case 3:
            Console.WriteLine("Fin del programa");
            return;
        default:
            Console.WriteLine("Opción inválida. Debe ser 1, 2 o 3.\n");
            break;
    }
}
