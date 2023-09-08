/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Console.Clear();

int[] GetRandomArray(int arrayLength1, int start, int end)
{
    int[] array = new int[arrayLength1];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(start, end);
    }
    return array;
}

void PrintArray(int[] arrayToPrint)

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

int QuantityNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 100 && array[i] < 1000)
        {
            if (array[i] % 2 == 0)
            {
                count = count + 1;
            }
        }
    }
    return count;
}

Console.WriteLine("Введите длину массива: ");
int arrayL = Convert.ToInt32(Console.ReadLine());
int min = 100;
int max = 1000;

int[] userArray = GetRandomArray(arrayL, min, max);
PrintArray(userArray);
int kolvo = QuantityNumber(userArray);
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел в массиве = {kolvo}");
