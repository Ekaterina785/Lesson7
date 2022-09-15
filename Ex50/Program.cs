Console.Write("Введите строку: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int g = Convert.ToInt32(Console.ReadLine()) ;

int[,] array = new int[m,n];

for(int i=0; i<array.GetLength(0); i++)
{
    for(int j=0; j<array.GetLength(1); j++)
    {
        array[i,j]= new Random().Next(1,10);
        Console.Write($"{array[i,j]} ");
        if (array[i,j]!= g)
        {
            Console.WriteLine("Элемент не существует");
            
        }
    }
    Console.WriteLine();
}
