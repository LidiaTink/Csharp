/*
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

14 -> нет
46 -> нет
161 -> да
*/

Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите числа кратности");
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 % (number2 *number3) == 0 )
{
    Console.WriteLine($"Число {number1} кратно числам {number2} и {number3}");
}
else
{
Console.WriteLine($"Число {number1} не кратно числам {number2} и {number3}");
}