int[] vector1 = { 1, 2, 3, 4, 5};
int[] vector2 = { 5, 4, 3, 2, 1};

Console.Clear();

int Pescalar =0;

for(int i=0; i< vector1.Length; i++)
{
    Pescalar += vector1[i] * vector2[i];
}
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("El producto escalar total de los vectores es: " +Pescalar);
Console.ResetColor();