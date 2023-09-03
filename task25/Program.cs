/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

System.Console.WriteLine("Введите 2 числа:");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
int userNumber2 = Convert.ToInt32(Console.ReadLine());

int DegreeOfNumber(int number)
{
    int degree = 1;
    for (int i = 1; i <= userNumber2; i++)
    {
        degree = degree * userNumber1;
    }
    return degree;
}
Console.WriteLine($"Число {userNumber1} возведённое в степень {userNumber2} равно {DegreeOfNumber(userNumber1)}");