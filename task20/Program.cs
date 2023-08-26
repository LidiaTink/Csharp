/* Напишите программу, которая принимает на вход координаты двух точек 
и находит между ними расстояние в 2D пространстве.
*/

Console.WriteLine("Введите X и Y первой точки: ");
int userX1 = Convert.ToInt32(Console.ReadLine());
int userY1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите X и Y второй точки: ");
int userX2 = Convert.ToInt32(Console.ReadLine());
int userY2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((userX1 - userX2), 2) + Math.Pow((userY1 - userY2), 2));
Console.WriteLine($"Расстояние между точками равно {result}");