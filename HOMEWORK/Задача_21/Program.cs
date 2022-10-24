// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


double GetDinst(int xA, int yA, int zA, int xB, int yB, int zB)
{
    double distance=0;
    distance = Math.Sqrt(Math.Pow(xB - xA,2) + Math.Pow(yB - yA,2) + Math.Pow(zB - zA, 2));
return distance;
}

Console.WriteLine( "Введите координаты точки xA (длина): ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine( "Введите координаты точки yA (ширина): ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine( "Введите координаты точки zA (высота): ");
int zA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine( "Введите координаты точки xB (длина): ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine( "Введите координаты точки yB (ширина): ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine( "Введите координаты точки zB (высота): ");
int zB = Convert.ToInt32(Console.ReadLine());

double dist = GetDinst(xA,yA,zA,xB,yB,zB);
Console.WriteLine($"Distance {dist}");