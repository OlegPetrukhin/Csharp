/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

System.Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number0 = number;
int mirrow = 0;
int number1 = 10000;
if (number > 9999 && number < 100000)
{
    for (int i=0;i<=5;i++)
    {
        mirrow += (number%10)*number1;
        number = number/10;
        number1 = number1/10;
    }
    if (number0 == mirrow)
    {
        System.Console.WriteLine("ДА");
    }
    else System.Console.WriteLine("НЕТ");
}
else System.Console.WriteLine("Число не пятизначное");
