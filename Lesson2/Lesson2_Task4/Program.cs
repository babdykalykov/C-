// Напишите программу, которая выводит третью слева цифру заданного числа или сообщает, что третьей цифры нет.
// 456 => 6
// 7812 => 1
// 91 => Третьей цифры нет

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0)
{
    num = num * -1;
}
if (num > 99)
{
    while (num > 999)

    num /= 10;
    Console.WriteLine($"Третья цифра = {num % 10}");
}
else
{
    Console.WriteLine("Третьей цифры нет!");
}
