/* Задайте массив вещественных чисел. Найдите разницу между максимальным 
и минимальным элементов массива. */

double[] FillArray(int size)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = Math.Round(new Random().NextDouble(), 2);
    }
    return result;
}
void GetMinMaxNums(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int position = 0; position < arr.Length; position++)
    {
        if (arr[position] > max) max = arr[position];
        if (arr[position] < min) min = arr[position];
    }
    Console.WriteLine("========================");
    Console.WriteLine($"min = {min}");
    Console.WriteLine($"max = {max}");
    Console.WriteLine($"Разность между max и min значением = {Math.Round(max - min, 2)}");
}

void PrintArray(double[] Array)
{
    for (int index = 0; index < Array.Length; index++)
    {
        Console.Write($"{Array[index]} ");
    }
}
double[] array = FillArray(5);
PrintArray(array);
Console.WriteLine();
GetMinMaxNums(array);