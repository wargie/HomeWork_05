// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных и четных чисел.
 
int sizeArray = new Random().Next(2, 30);

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
        int evenNum = 0;
        int unevenNum = 0;

        for (int i = 0; i < array.Length; i++)

            {
                Console.Write($"{array[i]} ");
                if (array[i] % 2 == 0) evenNum++;
                else unevenNum++;
            }

        Console.WriteLine();
        Console.WriteLine($"Количество нечетных чисел в массиве из {sizeArray} элементов: {unevenNum}");
        Console.WriteLine($"Количество четных чисел в массиве из {sizeArray} элементов: {evenNum}");
        
    }

PrintResult(FillArray(sizeArray));