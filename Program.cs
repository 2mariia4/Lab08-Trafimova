using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Задание 1");
        Task1();
        Console.WriteLine();

        Console.WriteLine("Задание 2");
        Task2();
        Console.WriteLine();

        Console.WriteLine("Задание 3");
        Task3();
        Console.WriteLine();

        Console.WriteLine("Задание 4");
        Task4();
        Console.WriteLine();

        Console.WriteLine("Задание 5");
        Task5();
        Console.WriteLine();

        Console.WriteLine("Задание 6");
        Task6();
        Console.WriteLine();
        
        Console.WriteLine("Меню-калькулятор");
        MenuCalculator();
    }

    // Задание 1
    static void Task1()
    {
        PrintHeader("Отчёт");
        PrintHeader("Журнал");
    }
    static void PrintLine()
    {
        Console.WriteLine("^_^");
    }
    static void PrintHeader(string title)
    {
        PrintLine();
        Console.WriteLine(title);
        PrintLine();
    }

    // Задание 2
    static void Task2()
    {
        Console.WriteLine("--- 2.1 Max ---");
        Console.WriteLine($"Max(3, 5)   = {Max(3, 5)}");
        Console.WriteLine($"Max(10, 2)  = {Max(10, 2)}");
        Console.WriteLine($"Max(-7, -3) = {Max(-7, -3)}");

        Console.WriteLine("--- 2.2 IsEven ---");
        Console.WriteLine($"IsEven(4) = {IsEven(4)}");
        Console.WriteLine($"IsEven(7) = {IsEven(7)}");
        Console.WriteLine($"IsEven(0) = {IsEven(0)}");
    }
    static int Max(int a, int b)
    {
        return a > b ? a : b;
    }

    static bool IsEven(int n)
    {
        return n % 2 == 0;
    }

    // Задание 3
    static void Task3()
    {
        int[] arr = { 120, 45, 300, 80, 15, 210 };
        Console.WriteLine($"Average = {Average(arr)}");
        Console.WriteLine($"CountGreater(arr, 100) = {CountGreater(arr, 100)}");
    }
    static double Average(int[] arr)
    {
        int sum = 0;
        foreach (int x in arr)
            sum += x;
        return (double)sum / arr.Length;
    }
    static int CountGreater(int[] arr, int limit)
    {
        int count = 0;
        foreach (int x in arr)
            if (x > limit) count++;
        return count;
    }

    // Задание 4
    static void Task4()
    {
        double[] temps = { 0, 100, 37 };
        foreach (double c in temps)
            Console.WriteLine($"{c} °C = {ToFahrenheit(c)} °F");
    }

    static double ToFahrenheit(double celsius)
    {
        return celsius * 9 / 5 + 32;
    }

    // Задание 5
    static void Task5()
    {
        Console.WriteLine($"Factorial(5) = {Factorial(5)}");
        Console.WriteLine($"Factorial(0) = {Factorial(0)}");

        Console.Write("Простые числа от 2 до 50: ");
        for (int i = 2; i <= 50; i++)
            if (IsPrime(i))
                Console.Write(i + " ");
        Console.WriteLine();
    }
    static long Factorial(int n)
    {
        long result = 1;
        for (int i = 2; i <= n; i++)
            result *= i;
        return result;
    }
    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i * i <= n; i++)
            if (n % i == 0) return false;
        return true;
    }

    // Задание 6
    static void Task6()
    {
        int a = ReadPositive("Введите первое положительное число: ");
        int b = ReadPositive("Введите второе положительное число: ");
        Console.WriteLine($"Сумма = {a + b}");
    }
    static int ReadPositive(string message)
    {
        int value;
        do
        {
            Console.Write(message);
        } while (!int.TryParse(Console.ReadLine(), out value) || value <= 0);
        return value;
    }

    // Итоговое задание
    static void MenuCalculator()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("=== МЕНЮ-КАЛЬКУЛЯТОР ===");
            Console.WriteLine("1 - Сумма двух чисел");
            Console.WriteLine("2 - Максимум из двух чисел");
            Console.WriteLine("3 - Факториал числа");
            Console.WriteLine("4 - Проверка на чётность");
            Console.WriteLine("0 - Выход");
            Console.Write("Выберите пункт: ");
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Нет такого пункта");
                continue;
            }
            if (choice == 0)
            {
                Console.WriteLine("До свидания!");
                break;
            }
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Сумма = {Sum(ReadPositive("Первое: "), ReadPositive("Второе: "))}");
                    break;

                case 2:
                    Console.WriteLine($"Максимум = {Max(ReadPositive("Первое: "), ReadPositive("Второе: "))}");
                    break;

                case 3:
                    int n = ReadPositive("Число для факториала: ");
                    Console.WriteLine($"{n}! = {Factorial(n)}");
                    break;

                case 4:
                    int num = ReadPositive("Введите число: ");
                    Console.WriteLine(IsEven(num) ? "Чётное" : "Нечётное");
                    break;

                default:
                    Console.WriteLine("Нет такого пункта");
                    break;
            }
        }
    }
    static int Sum(int a, int b)
    {
        return a + b;
    }
}