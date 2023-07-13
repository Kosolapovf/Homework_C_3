/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/


/* Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int ReverseNumber = 0;
// переменная SaveNumber создана для того, чтобы сохранить значение вводимого числа
// т.к. number претерпевает изменения
int SaveNumber = 0;
SaveNumber = number;
while (number > 0)
{
    ReverseNumber = (ReverseNumber * 10) + (number % 10);
    number = number / 10;
}
Console.WriteLine($"Обратное число: {ReverseNumber}");
if (ReverseNumber == SaveNumber)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No"); */



/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

/* Console.Clear();
Console.Write("x1 = ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1 = ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1 = ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("x2 = ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2 = ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2 = ");
int z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2)); */



/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

/* Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
    Console.WriteLine($"{Math.Pow(i, 3)}");
 */