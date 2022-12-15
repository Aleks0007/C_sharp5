/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
void GetSumElements(int[] Array)
{
    int sum = 0;
    for (int position = 0; position < Array.Length; position++)
    {
        if (position % 2 != 0) sum += Array[position];
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sum}");
}

void PrintArray(int[] arr)
{
    for (int index = 0; index < arr.Length; index++)
    {
        Console.Write($"{arr[index]} ");
    }
}
int[] array = GetArray(7, -10, 15);
PrintArray(array);
Console.WriteLine();
GetSumElements(array);