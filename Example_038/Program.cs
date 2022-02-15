// 38.Найти сумму чисел одномерного массива стоящих на нечетной позиции.

//int size = 20;

int sizeArray = new Random().Next(2, 50);

int[] FillArray(int sizeArray)

    {
        int[] array = new int[sizeArray];

        for (int i = 0; i < sizeArray; i++)

            {
                array[i] = new Random().Next(1, 100);
            }

        return array;
    }

void PrintArrayOddSum(int[] arr)

{
    int sum = 0;
    
        for (int i = 0; i < sizeArray; i++)

            {
                Console.Write(arr[i] + " ");
                if (i % 2 > 0) sum += arr[i];
            }
    Console.WriteLine();
    Console.WriteLine($"Сумма чисел, стоящих на нечетной позиции, соcтаваляет {sum} ");
}

PrintArrayOddSum(FillArray(sizeArray));