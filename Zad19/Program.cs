/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */

Console.WriteLine("Введите число: ");
int numFirst = Convert.ToInt32(Console.ReadLine());
int numA = numFirst;
int numB = 0;
while (numA > 0) 
{
    numB = numB * 10 + numA % 10;
    numA /= 10;
}
Console.WriteLine(numB);

if (numFirst == numB)
{
    Console.WriteLine($"Число {numFirst} является палиндромом");
}
else
{
    Console.WriteLine($"Число {numFirst} не является палиндромом");
}
