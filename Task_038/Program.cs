// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double [] createRandArr(int Length, int min, int max)
{
    double[] arr = new double[Length];
    Random random = new Random();
    for (int i=0; i < Length; i++)
    {
        arr[i] = random.Next(min, max+1);
    }
    return arr;
}

void printArr(double[] array)
{
    string str = "";
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length-1 )
        {
            str = str  + array[i] + ", ";
        }
        else str = str  + array[i] + "]";
    }
    Console.Write("[" + str);
}

double maxReturn(double[] array)
{
    double max = array[0];
    for(int i = 1; i <= (array.Length-1); i++)
    {
        if(max < array[i])
            {
                max = array[i];
            }
    }
    return max;
}

double minReturn(double[] array)
{
    double min = array[0];
    for(int i = 1; i <= (array.Length-1); i++)
    {
        if(min > array[i])
            {
                min = array[i];
            }
    }
    return min;
}

double[] myArr = createRandArr(8, 1, 9);
double minNum = minReturn(myArr);
double maxNum = maxReturn(myArr);
Console.WriteLine();
printArr(myArr);
Console.WriteLine($" -> {maxNum-minNum}");
Console.WriteLine();
Console.WriteLine($"Максимальное значение = {maxNum}");
Console.WriteLine($"Минимальное значение = {minNum}");
Console.WriteLine();