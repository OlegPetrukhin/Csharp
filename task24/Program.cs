/*
24. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
*/
System.Console.Write("Введите число: ");
int usernumber = Convert.ToInt32(Console.ReadLine());
int SumOfNumber(int number)
{
    int sum=0;
    for (int i = 1; i<=number;i++)
    {   
        sum+=i;
    }
    return sum;

}

System.Console.WriteLine(SumOfNumber(usernumber));