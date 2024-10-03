using System;

class Program
{
    static void Main()
    {
        //task 2
        int n, m;

        while (true)
        {
            Console.Write("Введіть число n: ");
            if (int.TryParse(Console.ReadLine(), out n))
            {
                break; 
            }
            else
            {
                Console.WriteLine("Помилка: введіть ціле число.");
            }
        }

        
        while (true)
        {
            Console.Write("Введіть число m (m > n): ");
            if (int.TryParse(Console.ReadLine(), out m) && m > n)
            {
                break; 
            }
            else
            {
                Console.WriteLine("Помилка: введіть ціле число, яке більше за n.");
            }
        }

        int sum = 0;
        Console.WriteLine($"Кратні 4 числа від {n} до {m}:");

        for (int i = n; i <= m; i++)
        {
            if (i % 4 == 0)
            {
                Console.WriteLine(i);
                sum += i;
            }
        }

        Console.WriteLine($"Сума кратних 4 чисел від {n} до {m} дорівнює: {sum}");

        
        Console.WriteLine("\nВиконуємо обчислення суми ряду (Завдання 2):");
        SumRyadu();

        
        Console.WriteLine("\nВиконуємо обчислення функцій (Завдання 3):");
        ObchyslenniaFunktsii();

        
        Console.WriteLine("\nНатисніть будь-яку клавішу для завершення програми...");
        Console.ReadKey();
    }

    // Завдання 2: Обчислення суми ряду
    static void SumRyadu()
    {
        double x = 2.05;  
        double epsilon = 1e-3;  
        double sum = 0.0;  
        double term;  
        int n = 0; 
        double factorial = 1;  

        do
        {
            
            term = Math.Pow(x, n) / factorial;          
            sum += term;
           
            Console.WriteLine($"Ітерація {n}: Поточний член = {term}, Сума = {sum}");

            n++;
            factorial *= n;

        } while (Math.Abs(term / sum) >= epsilon);

        Console.WriteLine($"Накопичена сума ряду S1 = {sum} після {n} ітерацій");

    }

    // Завдання 3: Обчислення функцій e^(3(x - 0.6)) та arcsin(x)
    static void ObchyslenniaFunktsii()
    {
        double a = -1.0;  
        double b = 1.0;   
        double h = 0.05;  

        Console.WriteLine(" x\t\te^(3(x - 0.6))\t\tarcsin(x)");
        Console.WriteLine("------------------------------------------------");

        for (double x = a; x <= b; x += h)
        {
            double expValue = Math.Exp(3 * (x - 0.6)); 
            double arcsinValue = Math.Asin(x);         

            
            Console.WriteLine($"{x:F2}\t\t{expValue:F6}\t\t{arcsinValue:F6}");
        }
    }
}
