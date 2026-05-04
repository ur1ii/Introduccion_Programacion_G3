using System;
int num1, num2, total, opcion;
Console.Clear();
for(int i=1;i<=5;i++)
{
    Console.WriteLine("===Seleccione la accion deseada===");
    Console.WriteLine("1.Sumar");
    Console.WriteLine("2.Restar");
    Console.WriteLine("3.Salir");
    opcion = int.Parse(Console.ReadLine());
    switch(opcion)
    {
        case 1:
            Console.WriteLine("Ingrese el primer numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            num2 = int.Parse(Console.ReadLine());
            if(num1>0 && num2 >0)
            {
                total = num1 + num2;
            Console.WriteLine($"El total de su suma es: {total}");
            }
            else
            {
                Console.WriteLine("ERROR. Operacion inválida");
            }
            break;
        
        case 2:
            Console.WriteLine("Ingrese el primer numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            num2 = int.Parse(Console.ReadLine());
            if(num1>0 && num2 >0)
            {
                total = num1 - num2;
            Console.WriteLine($"El total de su resta es: {total}");;
            }
            else
            {
                Console.WriteLine("ERROR. Operacion inválida");
            }
            break;
        
        case 3:
            Console.WriteLine("Fin del programa");
            return;
            break;
        default:
            Console.WriteLine("ERROR. Reingrese los datos");
            break;
    }
}
