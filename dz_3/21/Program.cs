// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


System.Console.WriteLine("Введите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

int deltaX = x1 - x2;
int deltaY = y1 - y2;
int deltaZ = z1 - z2;
double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
System.Console.WriteLine(string.Format("{0:0.00}", distance));
