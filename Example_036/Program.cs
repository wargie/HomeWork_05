// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных и четных чисел.
 
int sizeArray = 20;

int[] FillArray(int sizeArray)
{
    int[] array = new int[sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintResult(int[] array)
{
    int even = 0;
    int uneven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
        if (array[i] % 2 == 0) even++;
        else uneven++;
    }
    Console.WriteLine();
    Console.WriteLine($"Количество нечетных чисел в массиве: {uneven}");
    Console.WriteLine($"Количество четных чисел в массиве: {even}");
    
}

PrintResult(FillArray(sizeArray));