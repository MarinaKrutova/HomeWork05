/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

double[] generateRandomArray(int length, double min, double max)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().NextDouble() * (max - min) + min;
    }
    return array;
}

double getMinimumOfElementInArray(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}
double getMaximumOfElementInArray(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}
double getDifferenceOfMaxMinInArray(double max,double min)
{
    double difference= max - min;
    return difference;
}
void PrintArray(double[] array)
{
    Console.Write("массив [ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

double[] array = generateRandomArray(5, -5, 5);
PrintArray(array);
double max=getMaximumOfElementInArray(array);
double min=getMinimumOfElementInArray(array);
double differenceOfMaxMin=getDifferenceOfMaxMinInArray(max,min);
Console.WriteLine($"Разница между максимальным элементом {max} и минимальным элементом {min} равна {differenceOfMaxMin}");

