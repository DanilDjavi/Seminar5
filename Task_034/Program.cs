// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.

bool EvenOrNot(int num)
{
    bool even = false;
    if (num != 0)
    {
        if ((num % 2) == 0)
        {
        even = true;
        }
        else
        {
            even = false;
        }
    }
    return even;
} 

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
        else str = str  + array[i] + "] -> ";
    }
    Console.Write("[" + str);
}

int counter = 0;
int[] newArr = createRandArr(5, 100, 999);
printArr(newArr);
for(int i=0; i <= (newArr.Length - 1); i++)
{
if(EvenOrNot(newArr[i])) counter++;    
}
Console.Write(counter);