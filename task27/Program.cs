/*
 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int SumOfDigit(int number)
{
    int result = 0;
    while (number>0)
    {
        result+= number%10;
        number/=10;
    } 
    return result;

}
System.Console.WriteLine(SumOfDigit(number));
