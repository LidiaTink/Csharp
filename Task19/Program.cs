/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число:");
int number1 = Convert.ToInt32(Console.ReadLine());
    if (number1 / 10000 == number1 % 10 && number1 / 1000 % 10 == number1 % 100 / 10)
    {
        Console.WriteLine($"Полиндром");
    }
    else
    {
        Console.WriteLine("Не полиндром");
    }