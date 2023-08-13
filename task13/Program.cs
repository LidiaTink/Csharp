/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
while (number > 1000)
    {
        int number1 = number / 10;
    }
if (number1 > 99 && number1 < 1000)
{
    int number2 = number1 % 10 % 10;
    Console.WriteLine($"Искомое число {number1}");
}
else
{
    Console.WriteLine($"Третьей цифры нет");
} 