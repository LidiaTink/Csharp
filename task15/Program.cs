﻿/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/


Console.WriteLine("Введи число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1 || number == 2 || number == 3 || number == 4 || number == 5)
{
    Console.WriteLine("Этот день недели не является выходным");
}
else if (number == 6 || number == 7)
{
    Console.WriteLine("Этот день недели является выходным");
}
else
{
    Console.WriteLine("Попробуй ещё раз");
}