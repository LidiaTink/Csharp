/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

Console.Clear();


double[] userArray = FillArray(5, -20, 20);

double[] FillArray(int length, double minValue, double maxValue)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
    }
    return array;
}

void PrintArray(double[] arrayToPrint)

{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

void PrintSelectionSort(double[] arrayForDiff)
{
    for (int i = 0; i < arrayForDiff.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < arrayForDiff.Length - i - 1; j++)
        {
            if (arrayForDiff[j] < arrayForDiff[j + 1])
            {
                double temporary = arrayForDiff[i];
                arrayForDiff[j] = arrayForDiff[j + 1];
                arrayForDiff[j + 1] = temporary;
            }
        }
    }
    System.Console.WriteLine(Math.Round(arrayForDiff[0] - arrayForDiff[arrayForDiff.Length - 1], 2));
}

PrintArray(userArray);
Console.WriteLine();
PrintSelectionSort(userArray);