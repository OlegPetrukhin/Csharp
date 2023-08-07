Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int FinNumber = number;
if (FinNumber / 100 == 0)
{
    Console.Write("Третьей цифры нет");
}
else
{
    while (FinNumber > 999)
    {
        FinNumber = FinNumber / 10;
    }
    Console.Write(FinNumber % 10);
}