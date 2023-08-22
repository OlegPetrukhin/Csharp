/*
Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
в которой находится эта точка.
*/
Console.Write("Введите x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x>0 && y>0)
{
    System.Console.WriteLine("Первая четверть");
}
if (x>0 && y<0)
{
    System.Console.WriteLine("Четвертая четверть");
}
if (x<0 && y>0)
{
    System.Console.WriteLine("Вторая четверть");
}
if (x<0 && y<0)
{
    System.Console.WriteLine("Третья четверть");
}