int[] GetArray(int size, int minValue, int maxValue)
{

        int[] array = new int[size];

        var random = new Random();

        for (int i = 0; i < array.Length; i++)
        {
                array[i] = random.Next(minValue, maxValue + 1);
        }

        return array;

}

int GetSumPositiveNumbers(int[] array)
{
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
                if (array[i] > 0)
                {
                        sum += array[i];
                }
        }

        return sum;

}

int GetSumNegativeNumbers(int[] array)
{
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
                if (array[i] < 0)
                {
                        sum += array[i];
                }
        }

        return sum;
}

int[] array = GetArray(12, -9, 9);
int sumPositiveNumbers = GetSumPositiveNumbers(array);
int sumNegativeNumbers = GetSumNegativeNumbers(array);
Console.WriteLine($"Сумма положительных чисел: {sumPositiveNumbers}");
Console.WriteLine($"Сумма отрицательных чисел: {sumNegativeNumbers}");

