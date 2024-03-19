// Внутри класса Answer напишите метод PrintEvenNumbers, которая на вход принимает число (number), а на выходе выводит все чётные числа от 1 до number (включительно), после каждого числа должен быть знак пробела.

// На входе:
// number = 5 

// На выходе:
// 2 4 

// На входе:
// number = 8 

// На выходе:
// 2 4 6 8 

using System;

public class Answer {
    static void PrintEvenNumbers(int number)
    {
      // Введите свое решение ниже
      int i = 1;
      while (i <= number)
      {
        if (i % 2 == 0)
        {
          Console.Write(i);
          Console.Write(' ');
          i = i + 1;
        }
        else
        {
          i = i + 1;
        }
      }


    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 8;
        }

        // Не удаляйте строки ниже
        PrintEvenNumbers(number);
    }
}