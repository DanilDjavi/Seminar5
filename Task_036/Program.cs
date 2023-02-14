// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


int[] createRandArr(int Length, int min, int max)
{
    int[] arr = new int[Length];
    Random random = new Random();
    for (int i=0; i < Length; i++)
    {
        arr[i] = random.Next(min, max+1);
    }
    return arr;
}

void printArr(int[] array)
{
    string str = "";
    for (int i = 0; i <= array.Length-1; i++)
    {
        if (i != array.Length-1 )
        {
            str = str  + array[i] + ", ";
        }
        else str = str  + array[i] + "]";
    }
    Console.Write("[" + str);
}
    int sum = 0;
    int[] newArr = createRandArr(8, 0, 9);
    printArr(newArr);
    for(int i=1; i < newArr.Length; i++)
    {
        sum = sum + newArr[i];
        i++;
    }
    Console.WriteLine($" -> {sum}");