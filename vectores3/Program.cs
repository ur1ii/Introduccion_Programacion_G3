int[] vector = new int[5];
int[] vectorC = new int[5];
int[] vectorS = new int[5];

Console.WriteLine("Ingrese los valores del vector");
for(int i=0; i<vector.Length; i++)
{
    try
    {
        Console.ReadLine($"Valor {i+1}: ");
        vector[i] = int.Parse(Console.ReadLine());
    }
    catch(FormatException)
    {
        Console.WriteLine("ERROR. dato invalido, Reingrese los datos");
    }
    vectorC[i] = vector[i] * vector[i];
    vectorS[i] = vectorC[i] + vectorC[i];

}