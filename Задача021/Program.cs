// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите х1");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите у1");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z1");
double z1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите х2");
double x2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите у2");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z2");
double z2 = Convert.ToInt32(Console.ReadLine());

double x3 = Math.Pow(x1 - x2, 2);
double y3 = Math.Pow(y1 - y2, 2);
double z3 = Math.Pow(z1 - z2, 2);

System.Console.WriteLine($"Отрезок {Math.Sqrt(x3 + y3 + z3)}");