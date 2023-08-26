/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Введите X, Y, Z первой точки: ");
int userX1 = Convert.ToInt32(Console.ReadLine());
int userY1 = Convert.ToInt32(Console.ReadLine());
int userZ1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите X, Y, Z второй точки: ");
int userX2 = Convert.ToInt32(Console.ReadLine());
int userY2 = Convert.ToInt32(Console.ReadLine());
int userZ2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((userX1 - userX2), 2) + Math.Pow((userY1 - userY2), 2) + Math.Pow((userZ1 - userZ2), 2));
Console.WriteLine($"Расстояние между точками равно {Math.Round(result, 2)}");