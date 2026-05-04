using System;
using System.Dynamic;
using System.Formats.Asn1;
Console.WriteLine("=== FIGURAS GEOMETRICA ===");
Console.WriteLine("Que tipo de figura quiere");
Console.WriteLine("1. Figuras planas");
Console.WriteLine("2. Figuras 3D");
int opcion1 = int.Parse(Console.ReadLine());

switch(opcion1)
{
    case 1:
        Console.WriteLine("=== Figuras Planas ===");
        Console.WriteLine("1. Triangulo");
        Console.WriteLine("2. Rectangulo");
        Console.WriteLine("3. Cuadrado");
        Console.WriteLine("4. Rombo");
        Console.WriteLine("5. Romboide");
        Console.WriteLine("6. Trapecio");
        Console.WriteLine("7. Trapezoide");
        Console.WriteLine("8. Circulo");
        Console.WriteLine("9. Poligono Regular");
        Console.WriteLine("10. Poligono Irregular");
        int opcion2 = int.Parse(Console.ReadLine());
        switch(opcion2)
        {
            case 1:
            Console.Write("Area del triangulo: A = b x h /2");
            break;
            case 2:
            Console.Write("Area del rectangulo: A = b x h");
            break;
            case 3:
            Console.Write("Area del cuadrado: A = l x l");
            break;
            case 4:
            Console.Write("Area del rombo: A = B + b /2 * h");
            break;
            case 5: 
            Console.Write("Area del romboide: A = b * h");
            break;
            case 6: 
            Console.Write("Area del trapecio: A = B + b /2 * h");
            break;
            case 7: 
            Console.Write("Area trapezoide: Dividirlo en 2 triangulos y sumar ambas areas (A = b x h /2)");
            break;
            case 8:
            Console.Write("Area del circulo: A = PI * r²");
            break;
            case 9:
            Console.Write("Area del poligono regular: A = P * a /2");
            break;
            case 10:
            Console.Write("Area del poligono irregular: Dividirlo en triangulos y sumar ambas areas (A = b x h /2)");
            break;
        }   
    case 2:
        Console.WriteLine("=== Figuras 3D ===");
        Console.WriteLine("1. Ortoedro");
        Console.WriteLine("2. Cubo");
        Console.WriteLine("3. Piramide");
        Console.WriteLine("4. Cilindro");
        Console.WriteLine("5. Cono");
        Console.WriteLine("6. Esfera");
        int opcion3 = int.Parse(Console.ReadLine());
        switch(opcion3)
        {
            case 1:
            Console.Write("Area total del ortoedro: 2(ab + ac + bc) ");
            Console.Write("Area lateral del ortoedro: 2(ac + bc)");
            Console.Write("Volumen del ortoedro: abc");
            case 2:
            Console.Write("Ares total del cubo: 6a²");
            Console.Write("Volumen del cubo: a³");
            case 3:
            // piramide
            case 4:
            // cilindro
            case 5:
            // cono
            case 6:
            // esfera
        }
    /// Lista de figuras 3D y formulas
}



