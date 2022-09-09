int[] arr = {1, 5 ,4, 3, 2 , 6, 7, 8, 1, 1};
void PrintArray(int [] array)
{
        int count = array.Length;

        for(int i = 0; i < count; i ++)
        {
                Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
}


int[] SelectionSort(int[] array)
{
        for(int i = 0; i < array.Length - 1; i++)
        {
            int minPosition = i;

            for(int j = i + 1; j < array.Length; j++)
            {
                if(array[minPosition] < array[j]) minPosition = j;
            }

            int temporary = array[i];
            array[i] = array[minPosition];
            array[minPosition] = temporary;

        }

        return array;
}

PrintArray(arr);
arr = SelectionSort(arr);
PrintArray(arr);
