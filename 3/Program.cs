// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76

double[] GenerateArrey(int size, int leftRange, int rightRange)
{
    double[] array = new double[size];
    Random rand = new Random();

    for (int i=0; i < size; i++)
    {
        array[i] = rand.Next(leftRange, rightRange +1);
    }
    return array;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

double Min(double[] array)
{
    double minValue = array[0];

    for (int i=1; i < array.Length; i++)
    {
        if (array[i] < minValue)
        {
            minValue = array[i];
        }
    }
    return minValue;
}
double Max(double[] array)
{
    double maxValue = array[0];

    for (int i=1; i < array.Length; i++)
    {
        if (array[i] > maxValue)
        {
            maxValue = array[i];
        }
    }
    return maxValue;
}

double[] array = GenerateArrey(10, 1, 100);
PrintArray(array);
System.Console.WriteLine(Max(array) - Min(array));
