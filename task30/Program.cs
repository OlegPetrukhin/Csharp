/*
30. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
*/
int[] GetRandomArray()
{
    int[] array = new int[8];
    for (int i=0; i<array.Length;i++)
    {
        array[0] = new Random().Next(0,2); 


    }
    return array;

}
void PrintArray(int[] arraytoprint)
{
    System.Console.Write("[");
    for (int i = 0; i < arraytoprint.Length; i++)
    {
        System.Console.Write(arraytoprint[i]+" ");
    }
    System.Console.WriteLine("]");
}
int[] array1 = GetRandomArray();
System.Console.WriteLine(array1);
PrintArray(array1);