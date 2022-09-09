int Count(int number)
{
        tempNumber = Math.Abs(number);
        int count = 0;
        while(tempNumber > 0)
        {
                count++;
                tempNumber /= 10;
        }
        return count;
}

Console.Write("Введите целое число: ");
int num = int.Parse(Console.ReadLine());

int result = Count(num);
Console.WriteLine(result);


