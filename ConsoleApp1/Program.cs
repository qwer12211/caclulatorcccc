using System;
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("1. Сложить 2 слагаемых");
                Console.WriteLine("2. Вычесть вычитаемое из уменьшаемого");
                Console.WriteLine("3. Перемножить два множителя");
                Console.WriteLine("4. Разделить делимое на делитель");
                Console.WriteLine("5. Возвести в степень n первое число");
                Console.WriteLine("6. Найти квадратный корень из числа");
                Console.WriteLine("7. Найти процент от числа");
                Console.WriteLine("8. Найти факториал из числа");
                Console.WriteLine("9. Выход");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Введите первое слагеиое: ");
                    double num1 = double.Parse(Console.ReadLine());
                    Console.Write("Введите второе слагаемое: ");
                    double num2 = double.Parse(Console.ReadLine());
                    double result = num1 + num2;
                    Console.WriteLine($"Результат: {result}");
                }
                else if (choice == 2)
                {
                    Console.Write("Введите уменьшаемое: ");
                    double num1 = double.Parse(Console.ReadLine());
                    Console.Write("Введите второе вычитаемое: ");
                    double num2 = double.Parse(Console.ReadLine());
                    double result = num2 - num1;
                    Console.WriteLine($"Результат: {result}");
                }
                else if (choice == 3)
                {
                    Console.Write("Введите первый множитель: ");
                    double num1 = double.Parse(Console.ReadLine());
                    Console.Write("Введите второй множитель: ");
                    double num2 = double.Parse(Console.ReadLine());
                    double result = num1 * num2;
                    Console.WriteLine($"Результат: {result}");
                }
                else if (choice == 4)
                {
                    Console.Write("Введите делимое: ");
                    double num1 = double.Parse(Console.ReadLine());
                    Console.Write("Введите делитель: ");
                    double num2 = double.Parse(Console.ReadLine());
                    if (num2 != 0)
                    {
                         double result = num1 / num2;
                        Console.WriteLine($"Результат: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Делить на ноль нелдьзя");
                    }
                }
                else if (choice == 5)
                {
                    Console.Write("Введите число: ");
                    double num = double.Parse(Console.ReadLine());
                    Console.Write("Введите степень: ");
                    double power = double.Parse(Console.ReadLine());
                    double result = Math.Pow(num, power);
                    Console.WriteLine($"Результат: {result}");
                }
                else if (choice == 6)
                {
                    Console.Write("Введите число: ");
                    double num = double.Parse(Console.ReadLine());
                    double result = Math.Sqrt(num);
                    Console.WriteLine($"Результат: {result}");
                }
                else if (choice == 7)
                {
                    Console.Write("Введите число: ");
                    double num = double.Parse(Console.ReadLine());
                    double result = num / 100;
                    Console.WriteLine($"Результат: {result}");
                }
                else if (choice == 8)
                {
                    Console.Write("Введите число: ");
                    int num = int.Parse(Console.ReadLine());
                    int result = 1;
                    for (int i = 1; i <= num; i++)
                    {
                        result *= i;
                    }
                    Console.WriteLine($"Результат: {result}");
                }
                else if (choice == 9)
                {
                    break;
                }
            }
        }
    }


