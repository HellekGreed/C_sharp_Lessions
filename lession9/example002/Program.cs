int NumberSum(int n)
{
        int sum = 0;

        if (n > 0)
        {

                sum = n % 10 + NumberSum(n/10);

        }

        return sum;
}

int n = Convert.ToInt32(Console.ReadLine());

int res = NumberSum(n);

Console.Write(res);

