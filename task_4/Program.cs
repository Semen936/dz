// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число");
string numbersStr1 = Console.ReadLine();
int a = Convert.ToInt32(numbersStr1);

Console.WriteLine("Введите второе число");
string numbersStr2 = Console.ReadLine();
int b = Convert.ToInt32(numbersStr2);

Console.WriteLine("Введите третье число");
string numbersStr3 = Console.ReadLine();
int c = Convert.ToInt32(numbersStr3);
int max = a;

if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;

Console.Write("Максимальное число = ");
Console.WriteLine(max);