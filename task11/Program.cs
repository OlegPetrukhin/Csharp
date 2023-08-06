/*
Напишите программу которая вводит случайное 
трехзначное число и удаляет вторую цифру этого числа
*/
int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int number1 = number / 100;
Console.WriteLine(number1);
int number3 = number % 10;
Console.WriteLine(number3);
int result = number1 * 10 + number3;
Console.Write(result);