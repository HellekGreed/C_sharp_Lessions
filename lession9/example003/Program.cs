int Mult(int a, int b)
{
        int mul = 1;
        if(b == 1)
        {
                return a;
        }
        return a * Mult(a, b -1);
}

int a = 2;
int b = 3;

int res = Mult(a, b);

Console.Write(res);
