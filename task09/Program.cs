/*
Напишите программу которая выводит случайное число из отрезка [10,99]
и показывает наибольшую цифру числа.
*/
int number = new Random().Next(10, 100);
Console.WriteLine(number);
int number1 = number / 10;
int number2 = number % 10;
if (number1 > number2)
{
    Console.Write($"наибольшая цифра числа {number} - {number1}");
}
else
{
    Console.Write($"наибольшая цифра числа {number} - {number2}");
}
