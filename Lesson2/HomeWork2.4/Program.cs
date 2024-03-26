//Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

string result = "";
while (num > 0)
{
    // Добавление последней цифры к результату
    result = num % 10 + "," + result;
    num /= 10;
}

// Вывод результата
Console.WriteLine(result.TrimEnd(','));


