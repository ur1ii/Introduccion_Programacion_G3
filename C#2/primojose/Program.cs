using System;
using System.ComponentModel;

class Program
{
    static void Main()
    {     
        while(true ){
            Console.ReadLine();
            Console.Clear();
            int numero = 0;
             int primo = 2;
            Console.WriteLine("Ingrese un numero entero positivo: ");
            if(int.TryParse(Console.ReadLine(), out numero) && numero > 0)
            {
            
            if(numero == 1)
                {
                    Console.WriteLine($"El {numero} no es primo.");
                }

            else if(numero == 2)
                {
                    Console.WriteLine($"El {numero}  es primo.");
                }
                else
                {
                   
                    double sqrt = Math.Pow(numero, 0.5);
                    Console.WriteLine($"Raiz cuadrada de {numero} = {sqrt}");
                     double redondeo = Math.Round(sqrt);
                     Console.WriteLine($"El redondeo es: {redondeo}");
            
            
                for(int n = 2; n <=redondeo+1; n++)
                {
                    double resultado = numero % n;
           
                    if(resultado == 0)
                    {
                        Console.WriteLine($"El {numero} no es primo, es un numero compuesto.");
                        break;
                    }
                    else if(resultado != 0)
                    {
                        primo++;
                    }

                    if(primo == redondeo+1)
                    {
                        Console.WriteLine($"El {numero} es un numero primo");
                        break;
                    }

                }
 
                }
            
            
            }

        }   
        
    }
}