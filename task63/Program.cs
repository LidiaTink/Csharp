/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
*/

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
string numbers = string.Empty;

void Enumeration(int a)
{
if (a == 1) numbers = "1 " + numbers;
else
{
numbers = Convert.ToString(a) + " " + numbers;
Enumeration(a - 1);
}
}
Enumeration(n);
Console.WriteLine(numbers);