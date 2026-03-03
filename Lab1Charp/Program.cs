using System;

class Program
{
    static void Main()
    {
        bool continueRunning = true;

        while (continueRunning) {
         Console.WriteLine("Виберiть задачу (1-6) або введiть 0 для виходу:");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    task1();
                    break;
                case "2":
                    task2();
                    break;
                case "3":
                    task3();
                    break;
                case "4":
                    task4();
                    break;
                case "5":
                    double result5 = task5();
                    Console.WriteLine($"Результат: {result5}");
                    break;
                case "6":
                    double result6 = task6();
                    Console.WriteLine($"Значення виразу: {result6}");
                    break;
                case "0":
                    continueRunning = false;
                    Console.WriteLine("Вихiд з програми.");
                    break;
                default:
                    Console.WriteLine("Невiрний вибiр. Спробуйте ще раз.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void task1()
    {
        Console.Write("Введiть довжину кола (n): ");
        string input = Console.ReadLine()!;

        if (double.TryParse(input, out double n) && n > 0)
        {
            Console.WriteLine("Радiус кола: " + n / (2 * Math.PI));
            
        }
        else
        {
            Console.WriteLine("Будь ласка, введiть дiйсне позитивне число.");
        }
    }
    static void task2()
    {
        Console.Write("Введiть тризначне число: ");
        string input = Console.ReadLine()!;

        if (input.Length == 3 && int.TryParse(input, out int number))
        {
            int firstDigit = number / 100;
            int lastDigit = number % 10;   

            Console.WriteLine($"Перша цифра: {firstDigit}, Остання цифра: {lastDigit}");

            if (firstDigit > lastDigit)
            {
                Console.WriteLine("Перша цифра бiльше за останню.");
            }
            else if (firstDigit < lastDigit)
            {
                Console.WriteLine("Остання цифра бiльше за першу.");
            }
            else
            {
                Console.WriteLine("Перша та остання цифри однаковi.");
            }
        }
        else
        {
            Console.WriteLine("Будь ласка, введiть дiйсне тризначне число.");
        }
    }
    static void task3()
    {
        Console.Write("Введiть координати точки (x, y): ");
        string input = Console.ReadLine()!;
        string[] coordinates = input.Split(',');

        if (coordinates.Length == 2 &&
            double.TryParse(coordinates[0].Trim(), out double x) &&
            double.TryParse(coordinates[1].Trim(), out double y))
        {
            if (y > x && x >= 0 && y >= 0 && x <= 70)
            {
                Console.WriteLine("Так");
            }
            else if (y == x && x >= 0 && x <= 70)
            {
                Console.WriteLine("На межi");
            }
            else
            {
                Console.WriteLine("Нi");
            }
        }
        else
        {
            Console.WriteLine("Будь ласка, введiть коректнi координати у форматi x,y.");
        }
    }
    static void task4()
    {
        Console.Write("Введiть кiлькiсть балiв (0-100): ");
        string input = Console.ReadLine()!;

        // Перевiрка, чи ввели дiйсне число
        if (int.TryParse(input, out int score) && score >= 0 && score <= 100)
        {
            // Визначення оцiнки
            if (score >= 90)
            {
                Console.WriteLine("Оцiнка: вiдмiнно");
            }
            else if (score >= 70)
            {
                Console.WriteLine("Оцiнка: добре");
            }
            else if (score >= 50)
            {
                Console.WriteLine("Оцiнка: задовiльно");
            }
            else
            {
                Console.WriteLine("Оцiнка: незадовiльно");
            }
        }
        else
        {
            Console.WriteLine("Будь ласка, введiть коректну кiлькiсть балiв вiд 0 до 100.");
        }
    }
    static double task5()
    {
        Console.Write("Введiть перше число: ");
        double firstNumber = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введiть друге число: ");
        double secondNumber = Convert.ToDouble(Console.ReadLine());

        double sum = firstNumber + secondNumber;
        double squareOfSum = Math.Pow(sum, 2);

        return squareOfSum;
    }
    static double task6()
    {
        Console.Write("Введiть значення x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введiть значення y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        double numerator = Math.Pow(y, 2) + 4; // y^2 + 4
        double denominator = Math.Pow(x, 2) + 2 * x + 5;    // x + 2x + 5
        double result;

        if (denominator != 0)
        {
            result = (numerator / denominator) + 1;
        }
        else
        {
            Console.WriteLine("Дiлення на нуль!");
            return double.NaN;
        }

        return result;
    }
}
