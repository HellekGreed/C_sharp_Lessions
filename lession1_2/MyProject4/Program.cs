Console.Write("Введите целое число: ");
int a = int.Parse(Console.ReadLine());
int b = -a;

while (b < a + 1)
{
        Console.Write($"{b} ");
        b += 1;
}

