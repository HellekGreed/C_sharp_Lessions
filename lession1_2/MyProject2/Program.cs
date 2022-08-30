Console.Write("Введите целое число: ");
int number_1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int number_2 = int.Parse(Console.ReadLine());

if (number_1 == (number_2 * number_2))
{
        Console.WriteLine($"Число {number_1} является квадратом {number_2}");
}
else
{
        Console.WriteLine($"Число {number_1} не является квадратом {number_2}");
}
