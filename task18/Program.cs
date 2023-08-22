/*
18. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
*/
Console.Write("Введите четверть: ");
int quarter = Convert.ToInt32(Console.ReadLine());
if (quarter == 1) Console.Write("x и y положительные");
else if (quarter == 2) Console.Write("x отрицательное  y положительное");
else if (quarter == 3) Console.Write("x и y отрицательные");
else if (quarter == 4) Console.Write("x положительное и y отрицательное");
else Console.Write("Такой четверти нет");
