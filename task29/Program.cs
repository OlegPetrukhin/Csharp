/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
System.Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите start: ");
int start = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите finish: ");
int finish = Convert.ToInt32(Console.ReadLine());
int[] RandomArray(int size,int start,int finish)
{
    int[] array = new int[size];
    for (int i =0;i<array.Length;i++)
    {
        array[i]= new Random().Next(start,finish);


    }
    return array;
}
void PrintArray(int[] arrayforprint)
{
    System.Console.Write("[");
    for (int i=0;i<arrayforprint.Length;i++)
    {
        System.Console.Write(arrayforprint[i]+ " ");
    }
    System.Console.WriteLine("]");
}
int[] array1 =  RandomArray(size,start,finish);
PrintArray(array1);