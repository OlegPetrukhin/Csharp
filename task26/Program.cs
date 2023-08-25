/*
26. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
System.Console.Write("Введите число: ");
int usernumber = Convert.ToInt32(Console.ReadLine());
int Quantity(int number)
{
    int count = 0;
    while(number>0)
    {
        number/=10;
        count++;
    }
    return count;

}
System.Console.WriteLine(Quantity(usernumber));