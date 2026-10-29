    // {
    //     // Задание 1
    //     PrintHeader("Отчёт");
    //     PrintHeader("Финал");
    // }
    // static void PrintLine()
    // {
    //     Console.WriteLine("^_^");
    // }
    // static void PrintHeader(string t)
    // {
    //     PrintLine();
    //     Console.WriteLine(t);
    //     PrintLine();
    // }
    // {
    //     //задание 2.1 и 2.2
    //     Console.WriteLine("Макс из 5 и 9: " + Max(5, 9));
    //     Console.WriteLine("Макс из 20 и 3: " + Max(20, 3));
    //     Console.WriteLine("4 чётное? " + IsEven(4));
    //     Console.WriteLine("7 чётное? " + IsEven(7));
    //     Console.WriteLine("0 чётное? " + IsEven(0));
    // }
    // static int Max(int a, int b)
    // {
    //     if (a > b) return a;
    //     else return b;
    // }
    // static bool IsEven(int n)
    // {
    //     return n % 2 == 0; }
// {
//         // Задание 3
//         int[] m = { 120, 45, 300, 80, 15, 210 };
//         Console.WriteLine("Среднее: " + Average(m));
//         Console.WriteLine("Больше 100: " + CountGreater(m, 100));
//     }
//     static double Average(int[] a)
//     {
//         int s = 0;
//         foreach (int x in a) s = s + x;
//         return (double)s / a.Length;
//     }
//     static int CountGreater(int[] a, int limit)
//     {
//         int k = 0;
//         foreach (int x in a) if (x > limit) k = k + 1;
//         return k;
    // }
    //   {
    //     // Задание 4
    //     Console.WriteLine("0 °C = " + ToFahrenheit(0) + " °F");
    //     Console.WriteLine("100 °C = " + ToFahrenheit(100) + " °F");
    //     Console.WriteLine("37 °C = " + ToFahrenheit(37) + " °F");
    // }

    // static double ToFahrenheit(double c)
    // {
    //     return c * 9 / 5 + 32;
    // }
    // {
    //     // Задание 5
    //     Console.WriteLine("Факториал 5: " + Factorial(5));
        
    //     Console.Write("Простые числа от 2 до 50: ");
    //     for (int i = 2; i <= 50; i++)
    //     {
    //         if (IsPrime(i)) Console.Write(i + " ");
    //     }
    //     Console.WriteLine();
    // }

    // static long Factorial(int n)
    // {
    //     long f = 1;
    //     for (int i = 1; i <= n; i++) f = f * i;
    //     return f;
    // }

    // static bool IsPrime(int n)
    // {
    //     for (int i = 2; i < n; i++)
    //     {
    //         if (n % i == 0) return false;
    //     }
    //     return true;
    // }
//    {
//         // Задание 6
//         int a = ReadPositive("Введите первое число: ");
//         int b = ReadPositive("Введите второе число: ");
//         Console.WriteLine("Сумма: " + (a + b));
//     }

//     static int ReadPositive(string m)
//     {
//         while (true)
//         {
//             Console.Write(m);
//             int x = int.Parse(Console.ReadLine());
//             if (x > 0) return x;}
//     }
    {
        int p;
        do
        {
            Console.WriteLine("\n1 - сумма двух чисел");
            Console.WriteLine("2 - большее из двух чисел");
            Console.WriteLine("3 - факториал");
            Console.WriteLine("0 - выход");
            Console.Write("Выбор пункта: ");
            p = int.Parse(Console.ReadLine());

            switch (p)
            {
                case 1:
                    int a1 = ReadPositive("Введи первое число: ");
                    int b1 = ReadPositive("Введи второе число: ");
                    Console.WriteLine("Сумма: " + (a1 + b1));
                    break;
                case 2:
                    int a2 = ReadPositive("Введи первое число: ");
                    int b2 = ReadPositive("Введи второе число: ");
                    Console.WriteLine("Большее: " + Max(a2, b2));
                    break;
                case 3:
                    int n = ReadPositive("Введи число: ");
                    Console.WriteLine("Факториал: " + Factorial(n));
                    break;
                case 0: break;
                default: Console.WriteLine("Нет такого пункта"); break;
            }
        } 
        while (p != 0);
    }

    static int ReadPositive(string m)
    {
        int x;
        do
        {
            Console.Write(m);
            x = int.Parse(Console.ReadLine());
        } 
        while (x <= 0);
        return x;
    }

    static int Max(int a, int b)
    {
        if (a > b) return a;
        else return b;
    }

    static long Factorial(int n)
    {
        long f = 1;
        for (int i = 1; i <= n; i++) f = f * i;
        return f;
    }