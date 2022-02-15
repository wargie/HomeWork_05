// 34. Написать программу замену элементов массива на противоположные

int size = new Random().Next(1, 20);

int[] CreateArray(int size)
    
    {
        int[] array = new int[size];
        
        for (int i = 0; i < size; i++)
        
        {
            array[i] = new Random().Next(-100, 101);
        }

        return array;
    }

int[] GetOppArray(int[] array)
    
    {
        for (int i = 0; i < array.Length; i++)
        
        {
            array[i] = array[i] * (-1);
        }

        return array;
    }

void PrintArray(int[] arr)
    
    {
        for (int i = 0; i < arr.Length; i++)
        
        {
            System.Console.Write($"{arr[i]} ");
        }

        System.Console.WriteLine();
    }

int[] array = CreateArray(size);

PrintArray(array);
PrintArray(GetOppArray(array));