int[] Fib(int n)
{
        int[] array = new int[n];
        int digit = 0;
        array[0] = 0;
        int a = 0;
        int b = 1;
        for(int i = 1; i < n; i++)
        {
                a = b;
                array[i] = digit + a;
                b = digit;
                digit += a;
        }
        return array;
}
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = Fib(n);

for(int i = 0; i < array.Length; i++)
{
        Console.Write($"{array[i]} ");
}

