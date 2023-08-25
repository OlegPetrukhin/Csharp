/*
28. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
*/
System.Console.Write("Введите число: ");
int usernumber = Convert.ToInt32(Console.ReadLine());
int Mult(int number)
{
    int result = 1;
    for (int i = 1; i <=number; i++)
    {
        result*=i;
    }
    return result;
}
System.Console.WriteLine(Mult(usernumber));