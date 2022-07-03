/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

/*Console.WriteLine("Введите координату Х точки А: ");
double numXA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y точки А: ");
double numYA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z точки А: ");
double numZA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X точки B: ");
double numXB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y точки B: ");
double numYB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z точки B: ");
double numZB = Convert.ToInt32(Console.ReadLine());*/

double numXA = 3;
double numYA = 6;
double numZA = 8;
double numXB = 2;
double numYB = 1;
double numZB = -7;

double FunKv(double number)
{
    number *= number;
    return number;
}

double KvOne = FunKv(numXB - numXA);
double KvTwo = FunKv(numYB - numYA);
double KvThree = FunKv(numZB - numZA);

double RasstAB = Math.Sqrt(KvOne+KvTwo+KvThree);

Console.WriteLine(Math.Round(RasstAB, 2));