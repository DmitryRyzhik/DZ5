// // Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2

int[] GenerateArrey(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i=0; i < size; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }

    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int Sum(int[] array)
{
    int count = 0;
    for (int i=0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
        {
            count=count+1;
        }
    }
    return count;
}

int[] array = GenerateArrey(10, 100, 999);
PrintArray(array);
System.Console.WriteLine(Sum(array));
