int[,] array= new int[4,3];

for(int i=0; i<array.GetLength(0); i++)
{
    for(int j =0; j<array.GetLength(1);j++)
    {
        array[i,j] = new Random().Next(10);
        Console.Write($"{array[i,j]} ");
        
    }
Console.WriteLine();
}
Console.WriteLine(" ");
for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    Console.Write($"{ sum / array.GetLength(0)} ");
}
