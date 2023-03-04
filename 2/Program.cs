// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
    int arraySum = 0;
    for (int i=0; i < array.Length; i=i+2)
    {
        arraySum = arraySum + array[i];
    }
    return arraySum;
}

int[] array = GenerateArrey(10, 1, 12);
PrintArray(array);
System.Console.WriteLine(Sum(array));
