/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int[] generateRandomArray(int length, int start, int finish)
{
    int[] Array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Array[i] = new Random().Next(start, finish);
    }
    return Array;
}
int getTheNumberOfEvenNumbersInArray(int[] array)
{
    int NumberOfEvenNumbers = 0;
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                NumberOfEvenNumbers += 1;
            }
        }
        return NumberOfEvenNumbers;
    }
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
int[] array = generateRandomArray(10, 100, 1000);
PrintArray(array);
int NumberOfEvenNumbers = getTheNumberOfEvenNumbersInArray(array);
Console.WriteLine($"Количество четных чисел в массиве: {NumberOfEvenNumbers}");
