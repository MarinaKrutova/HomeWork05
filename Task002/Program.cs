/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/
int[] generateRandomArray(int length, int start, int finish)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, finish);
    }
    return array;
}
int getSumOfElementsOnTheOddPositionInArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}
void PrintArray(int[] array)
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
int[] array = generateRandomArray(5, 1, 100);
PrintArray(array);
int sumOfElementsOnTheOddPosition = getSumOfElementsOnTheOddPositionInArray(array);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях массива равна {sumOfElementsOnTheOddPosition}");