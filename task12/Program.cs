/*
Напишите программу которая будет принимать на вход два 
числа и выводить является ли второе число кратным первому
Если второе число некратно первому то программа выводит
остаток от деления
*/
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 % number2 == 0)
{
    Console.Write($"Кратно");
}
else
{
    Console.Write($"Некратно, остаток {number1 % number2}");
}