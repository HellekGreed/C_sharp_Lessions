int[] GetArray()
{
        int[] array = new int[8];
        for(int i = 0; i < 8; i++)
        {
                array[i] = new Random().Next(0, 2);
        }
        return array;
}

void PrintArray(int[] array)
{
        for(int  i = 0; i < array.Length; i++)
        {
                Console.Write($"{array[i]} ");
        }
}



int[] array = GetArray();
PrintArray(array);



