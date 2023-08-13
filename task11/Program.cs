/* 
Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цыфру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/
int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int number1 = number / 100;
Console.WriteLine(number1);

int number2 = number / 10 % 10;
Console.WriteLine(number2);

int number3 = number % 10;
Console.WriteLine(number3);

Console.WriteLine($"Итоговое число {number1}{number3}");