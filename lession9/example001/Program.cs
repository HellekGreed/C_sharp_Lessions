int PrintNumAndSum(int n, int m)
{
        int sum = 0;
        if(n == m)
        {
                Console.Write(1);
                return m;
        }
        Console.Write($"{n} ");
        sum = n + PrintNumAndSum(n - 1, m);
        
        return sum;
}

int n = 5;
int m = 1;
int sum = PrintNumAndSum(n, m);
Console.WriteLine();
Console.WriteLine(sum);

