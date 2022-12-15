/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

int[] FillArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int index = 0; index < size; index++)
    {
        result[index] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
int[] array = FillArray(10, 100, 300);
PrintArray(array);
Console.WriteLine();

int count = 0;
foreach (int element in array)
{
    if (element % 2 == 0) count++;
}
Console.Write($"Количество чётных чисел в массиве = {count}");