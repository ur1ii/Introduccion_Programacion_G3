double[] vector = { 3, 4, 5, 6 ,7};
double sumaC =0;

Console.Clear();

for(int i=0; i<vector.Length; i++)
{
    sumaC += Math.Pow(vector[i], 2);

}
   double magnitud = Math.Sqrt(sumaC);
   Console.ForegroundColor = ConsoleColor.Green;
   Console.WriteLine("La magnitud total del vector de movimiento es: " +magnitud);
   Console.ResetColor();
