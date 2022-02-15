// 38.Найти сумму чисел одномерного массива стоящих на нечетной позиции.

//int size = 20;

int sizeArray = new Random().Next(2, 30);

int[] FillArray(int sizeArray)

    {
        int[] array = new int[sizeArray];

        for (int i = 0; i < sizeArray; i++)

            {
                array[i] = new Random().Next(1, 100);
            }

        return array;
    }

void PrintArrayAndSum(int[] arr)
{
    int sum = 0;
    System.Console.WriteLine();
        for (int i = 0; i < sizeArray; i++)

            {
                System.Console.Write(arr[i] + " ");
                if (i % 2 > 0) sum += arr[i];
            }
            
    System.Console.WriteLine();
    System.Console.WriteLine($"Сумма чисел, стоящих на нечетной позиции, соcтаваляет {sum} ");
}

PrintArrayAndSum(FillArray(sizeArray));