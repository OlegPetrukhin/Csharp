Console.Write("Введите цифру обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number==6 | number==7)
{
    Console.Write($"{number}-Выходной день!");
}
else if (number>=1 && number<6)
{
   Console.Write($"{number}-Рабочий день:("); 
}
else
{
   Console.Write($"{number}-Нет такого дня недели."); 
}
