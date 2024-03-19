// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

Console.WriteLine("Введите трехзначное число:");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999)
{
    int digit1 = num / 100;
    int digit3 = num % 10;
    int result = digit1 + digit3;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Некорректный ввод!");
}
