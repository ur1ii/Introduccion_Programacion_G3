    using System;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("==== INGRESE UN NUMERO PRIMO ===");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Número: ");
        Console.ResetColor();
        int n = int.Parse(Console.ReadLine());
        bool Primo = true;
        if (n <= 1) 
        {
            Primo = false;
        }
        else 
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    Primo = false;
                    break;
                }
            }
        }
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine(Primo ? "===ES PRIMO===" : "===NO ES PRIMO===");
        Console.ResetColor();
