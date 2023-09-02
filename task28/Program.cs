/*
Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

4 -> 24
5 -> 120
*/

System.Console.WriteLine("Введите число:");
int userNumber = Convert.ToInt32(Console.ReadLine());

int PrOfNumber(int number)
{
    int pr = 1;
    for (int i = 1; i <= userNumber; i++)
    {
        pr = pr * i;
    }
    return pr;
}

Console.WriteLine($"произведение чисел от 1 до {userNumber} равна {PrOfNumber(userNumber)}");