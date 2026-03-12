namespace Lab1CSharp;

using System;

public class Program
{
    static void Main()
    {
        bool continueRunning = true;

        while (continueRunning)
        {
            Print("--- Виберiть задачу (1-6) або введiть 0 для виходу ---");
            Print("1. Обчислити радiус кола за довжиною");
            Print("2. Порiвняти першу та останню цифру трицифрового числа");
            Print("3. Перевiрка потрапляння точки в область");
            Print("4. Визначення оцiнки");
            Print("5. Квадрат суми двох чисел");
            Print("6. Обчислення виразу (y^2 + 4) / (x^2 + 2x + 5) + 1");
            Print("Ваш вибiр: ", true);

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    double radius = Task1();
                    if (!double.IsNaN(radius)) Print($"Радiус кола: {radius}");
                    else Print("Помилка: довжина має бути додатною.");
                    break;
                case "2":
                    Print(Task2() ?? "Помилка: введiть трицифрове число.");
                    break;
                case "3":
                    Print(Task3() ?? "Помилка: неверний формат координат.");
                    break;
                case "4":
                    Print(Task4() ?? "Помилка: бали мають бути в межах 0-100.");
                    break;
                case "5":
                    Print($"Результат: {Task5()}");
                    break;
                case "6":
                    double res6 = Task6();
                    if (!double.IsNaN(res6)) Print($"Результат виразу: {res6:F4}");
                    else Print("Помилка при обчисленнi.");
                    break;
                case "0":
                    continueRunning = false;
                    break;
                default:
                    Print("Невiрний вибiр.");
                    break;
            }
            Print("");
        }
    }
    static void Print(string message, bool write = false)
    {
        if (write) Console.Write(message);
        else Console.WriteLine(message);
    }

    public static double Task1()
    {
        Print("Введiть довжину кола (n): ", true);
        if (double.TryParse(Console.ReadLine(), out double n) && n > 0)
        {
            return n / (2 * Math.PI);
        }
        return double.NaN;
    }

    public static string Task2()
    {
        Print("Введiть трицифрове число: ", true);
        string input = Console.ReadLine();
        if (input.Length == 3 && int.TryParse(input, out int number))
        {
            int first = number / 100;
            int last = number % 10;
            if (first > last) return "Перша цифра бiльше";
            if (first < last) return "Остання цифра бiльше";
            return "Цифри однаковi";
        }
        return null;
    }

    public static string Task3()
    {
        Print("Введiть x та y через кому (напр. 10,20): ", true);
        string input = Console.ReadLine();
        if (string.IsNullOrEmpty(input)) return null;

        string[] parts = input.Split(',');
        if (parts.Length == 2 && double.TryParse(parts[0], out double x) && double.TryParse(parts[1], out double y))
        {
            if (y > x && x >= 0 && y >= 0 && x <= 70) return "Точка потрапляє в область (Так)";
            if (y == x && x >= 0 && x <= 70) return "Точка знаходиться на межi";
            return "Точка не потрапляє в область (Нi)";
        }
        return null;
    }

    public static string Task4()
    {
        Print("Введiть бали (0-100): ", true);
        if (int.TryParse(Console.ReadLine(), out int s) && s >= 0 && s <= 100)
        {
            if (s >= 90) return "Результат: вiдмiнно";
            if (s >= 70) return "Результат: добре";
            if (s >= 50) return "Результат: задовiльно";
            return "Результат: незадовiльно";
        }
        return null;
    }

    public static double Task5()
    {
        Print("Введiть перше число: ", true);
        double a = Convert.ToDouble(Console.ReadLine());
        Print("Введiть друге число: ", true);
        double b = Convert.ToDouble(Console.ReadLine());
        return Math.Pow(a + b, 2);
    }

    public static double Task6()
    {
        Print("Введiть x: ", true);
        double x = Convert.ToDouble(Console.ReadLine());
        Print("Введiть y: ", true);
        double y = Convert.ToDouble(Console.ReadLine());

        double den = Math.Pow(x, 2) + 2 * x + 5;
        if (den != 0)
        {
            return (Math.Pow(y, 2) + 4) / den + 1;
        }
        return double.NaN;
    }
}