Console.Write("Введите целое число: ");
int a = int.Parse(Console.ReadLine());
int b = -a;
if (a > b)
{
    while (b <= a)
    {
            Console.Write($"{b} ");
            b++;
    }
}
else if(b > a)
{
    while (a <= b)
    {
            Console.Write($"{a} ");
            a++;
    }
}
else if (a == 0)
{
        Console.Write(a);
}

