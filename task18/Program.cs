/* Напишите программу, которая по заданному номеру четверти показывает
диапозон возможных координат точек в этой четверти 
*/

Console.WriteLine("Введите номер четверти:");
int numberCH = Convert.ToInt32(Console.ReadLine());
if (numberCH == 1)
{
    Console.WriteLine($"Все X > 0, все Y > 0");
}
else if (numberCH == 2)
{
    Console.WriteLine($"Все X < 0, все Y > 0");
}
    else if (numberCH == 3)
    {
        Console.WriteLine($"Все X < 0, все Y < 0");
    }
        else if (numberCH == 4)
    {
        Console.WriteLine($"Все X > 0, все Y < 0");
    }
        else
        {
            Console.WriteLine($"Такой четверти не существует");
        }