﻿/*
Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
В итоге получается вот такой массив:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
*/
int[,] GetRandom2DArray(int rowNumber, int min, int max)
{
int[,] result = new int[rowNumber, rowNumber];
for (int i = 0; i < rowNumber; i++)
{
for (int j = 0; j < rowNumber; j++)
{
result[i, j] = new Random().Next(min, max);
}
}
return result;
}

void Print2DArray(int[,] arrayToPrint)
{
for (int i = 0; i < arrayToPrint.GetLength(0); i++)
{
for (int j = 0; j < arrayToPrint.GetLength(1); j++)
{
System.Console.Write(arrayToPrint[i, j] + "\t");
}
System.Console.WriteLine();
}
}

int[,] ChangeStringsAndColumns(int[,] matrix)
{
int temp = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = i; j < matrix.GetLength(1); j++)
{
temp = matrix[i,j];
matrix[i,j] = matrix[j,i];
matrix[j,i] = temp;
}
}
return matrix;
}

int[,] userMatrix = GetRandom2DArray(5,0,10);
Print2DArray(userMatrix);
Print2DArray(ChangeStringsAndColumns(userMatrix));