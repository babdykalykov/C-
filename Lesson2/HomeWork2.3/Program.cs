// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.WriteLine("Ведите целое число:");
int num = Convert.ToInt32(Console.ReadLine());
int digit1 = num / 10;
int digit2 = num % 10;
int max = digit1 > digit2 ? digit1 : digit2;
Console.WriteLine(max);
