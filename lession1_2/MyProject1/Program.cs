Console.Write("Введите целое число чтобы узнать его квадрат: ");
int number = int.Parse(Console.ReadLine());
int result = number * number;
Console.WriteLine($"Квадрат числа {number} равен {result}");
int result_2 = Convert.ToInt32(Math.Pow(number, 2));

Console.WriteLine($"Квадрат числа {number} равен {result_2}");
