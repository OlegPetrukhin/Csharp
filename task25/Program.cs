/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
System.Console.Write("Введите два значения(число и степень в которую вы хотите возвести число): ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
double Exponentiation(int number1, int number2)
{
    double result=1;
    result = Math.Pow(number1,number2);
    return result;
}

System.Console.WriteLine(Exponentiation(number1,number2));