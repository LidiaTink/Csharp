﻿/*
Задайте двумерный массив из целых чисел. Напишите программу,
которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 25 9 2 38 4 2 45 2 6 7
Наименьший элемент - 1, на выходе получим следующий массив:9 4 22 2 63 4 7
*/

Console.Clear();

int[,] Get2DArray(int row, int col, int min, int max)
{
int[,] array = new int[row, col];
for (int i = 0; i < row; i++)
{
for (int j = 0; j < col; j++)
{
array[i, j] = new Random().Next(min, max);
}
}
return array;
}

void Print2DArray(int[,] arrayToPrint)
{
System.Console.Write($"[ ]\t");
for (int i = 0; i < arrayToPrint.GetLength(1); i++)
{
Console.Write($"[{i}]\t");
}
System.Console.WriteLine();
for (int i = 0; i < arrayToPrint.GetLength(0); i++)
{
Console.Write($"[{i}]\t");
for (int j = 0; j < arrayToPrint.GetLength(1); j++)
{
System.Console.Write(arrayToPrint[i, j] + "\t");
}
System.Console.WriteLine();
}
}

int[] CoordMinValue(int[,] array)
{
int[] result = new int[2];
int min = array[0, 0];
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
if (array[i, j] < min)
{
min = array[i, j];
result[0] = i;
result[1] = j;
}
}
}
return result;
}

int[,] FillZero(int[,] array)
{
int[] coords = CoordMinValue(array);
for (int i = 0; i < array.GetLength(0); i++)
{
array[coords[0], i] = 0;
}
for (int i = 0; i < array.GetLength(1); i++)
{
array[i, coords[1]] = 0;
}
return array;
}

int[,] DeleteCross(int[,] array)
{
int rows = array.GetLength(0) - 1;
int cols = array.GetLength(1) - 1;
int[,] result = new int[rows, cols];
for (int row = 0; row < rows + 1; row++)
{
for (int col = 0; col < cols + 1; col++)
{
if (array[row, col] != 0)
{
result[row, col] = array[row, col];
}

}
}
return result;
}

int[,] arr = Get2DArray(7, 7, 1, 10);
Print2DArray(arr);

System.Console.WriteLine();

int[,] arr2 = FillZero(arr);
Print2DArray(arr2);

System.Console.WriteLine();

int[,] arr3 = DeleteCross(arr2);
Print2DArray(arr3);