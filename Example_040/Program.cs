// 40.В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

// Вещественные числа - это числа, которые можно записать в виде конечной или бесконечной, периодической или непериодической десятичной дроби.

int sizeArr = new Random().Next(1, 11);

Console.WriteLine($"Количество элементов массива: {sizeArr}");
Console.WriteLine();
double[] FillSourceArray(int sizeArr)

    {
        double[] array = new double[sizeArr];
        for (int i = 0; i < sizeArr; i++)

            {
                array[i] = new Random().NextDouble() * 100;
            }

        return array;
    }

void PrintDiffMinMax(double[] arr)

    {
        for (int i = 0; i < arr.Length; i++)

            {
                
                System.Console.WriteLine(arr[i]);
            }

        double diff = arr.Max() - arr.Min();

        Console.WriteLine();
        Console.WriteLine($"Минимальным значением массива является {arr.Min()}, максимальным значением массива является {arr.Max()}");
        Console.WriteLine();
        Console.WriteLine($"Разница между минимальным и максимальным значениями массива составляет {diff}");
        Console.WriteLine();
    }

PrintDiffMinMax(FillSourceArray(sizeArr));