double[,] GetArray()
{
    Console.Write("Введите количество строк: ");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите количество столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[m, n];
    int digit = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
                digit = new Random().Next(1, 10);
                array[i, j] = digit;
        
        }
    }

    return array;
}

void PrintArray(double[,] array)
{
        for(int i = 0; i < array.GetLength(0); i++)
        {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                        Console.Write($"{array[i, j]}, ");
                }

                Console.WriteLine();
        }
}

double GetSum(double[,] array)
{
        double digit = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                        if ( i == j )
                        {
                                digit += array[i, j];
                        }
                }

        
        }
        return digit;
}

double[,] array = GetArray();

PrintArray(array);

double digit = GetSum(array);

Console.Write(digit);

