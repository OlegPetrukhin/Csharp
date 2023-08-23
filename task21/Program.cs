/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
System.Console.WriteLine("Введите координаты первой точки: ");
int userx1 = Convert.ToInt32(Console.ReadLine());
int usery1 = Convert.ToInt32(Console.ReadLine());
int userz1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты второй точки: ");
int userx2 = Convert.ToInt32(Console.ReadLine());
int usery2 = Convert.ToInt32(Console.ReadLine());
int userz2 = Convert.ToInt32(Console.ReadLine());
double s = 0;
s = Math.Sqrt(Math.Pow(userx2-userx1,2)+Math.Pow(usery2-usery1,2)+Math.Pow(userz2-userz1,2));
System.Console.WriteLine(Math.Round(s,2));
