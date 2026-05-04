// Codigo cagado que pereza arreglarlo y terminarlo
int numero, opcion;
int numero2, total;
for(int i=1;i<=10; i++);
{
    Console.WriteLine("===CALCULADORA===");
   
    
    Console.WriteLine("====OPCIONES===");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Resta");
    Console.WriteLine("3. Multiplicacion");
    Console.WriteLine("4. Division");
    if(!int.TryParse(Console.ReadLine(), out opcion));
    {
        Console.WriteLine("Error de sintaxis, reingrese datos");
        break;
    }
    switch(opcion)
    {
        case 1:
            Console.WriteLine("Ingrese un numero entero");
            if(!int.TryParse(Console.ReadLine(), out numero))
            {
            Console.WriteLine("ERROR. invalid");
            continue;
            }
            total = numero + numero2; 
            Console.WriteLine($"Suma: {total}");
            continue;
        case 2:
            Console.WriteLine("Ingrese otro numero entero");
            if(!int.TryParse(Console.ReadLine(), out numero2));
            {
            Console.WriteLine("ERROR. invalid");
            break;
            }   
            total = numero - numero2; 
            Console.WriteLine($"Resta: {total}");
            break;
        case 3:
            Console.WriteLine("Ingrese un numero entero");
            if(!int.TryParse(Console.ReadLine(), out numero1));
            {
            Console.WriteLine("ERROR. invalid");
            break;
            }
            total = numero * numero2;
            Console.WriteLine($"Multiplicacion: {total}");
            break;
        case 4:
            total = numero / numero2;
            Console.WriteLine($"Division: {total}");
            break;
    }
}
