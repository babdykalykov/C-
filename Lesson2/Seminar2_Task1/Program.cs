// Напишите программу, которая принимает на вход трёхзначное число и удаляет вторую цифру этого числа.
// Примеры
// a = 256=> 26
// a = 891=> 81
// 15

Console.WriteLine("Введите трехзначное число:");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999 || num <= -100 && num >= -999)     // || - это ИЛИ
{
    int digit1 = num / 100;
    int digit3 = num % 10;
    int result = digit1 * 10 + digit3;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Некорректный ввод!");
}
