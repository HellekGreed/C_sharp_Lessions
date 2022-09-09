int GetMult(int number)
{
    int mult = 1;
    if(number > 0)

        for(int i = 1; i <= number; i++)
        {
            mult *= i; // mult = mult * i
        }

    if(number < 0)

    {
        for(int i = -1; i >= number; i--)
        {
            mult *= i; // mult = mult * i
        }

    }


    return mult;
}

Console.Write("Введите целое число: ");
int num = int.Parse(Console.ReadLine());

int result = GetMult(num);
Console.WriteLine(result);

